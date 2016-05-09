using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace SocketServiceContract
{
    public class AsynchronousSocketServerProcess
    {
        Socket client = null;
       

        public AsynchronousSocketServerProcess(Socket client)
        {
            this.client = client;
            StateObject so = new StateObject();
            so.Client = client;
            client.BeginReceive(so.RevaceBuf, 0, StateObject.BufferSize, SocketFlags.None, out so.Error, new AsyncCallback(DoReadBuff), so);

        }

        private void DoReadBuff(IAsyncResult ar)
        {
            StateObject so = (StateObject)ar.AsyncState;
            Socket Client = so.Client;
            try
            {
                int ReadSize = Client.EndReceive(ar);
                if (ReadSize > 0)
                {
                    ReviceBuffer Buffer = new ReviceBuffer(so.RevaceBuf, Client, so.Error);
                    ProcessMess(Buffer);
                }
                so.RevaceBuf = null;
                so.RevaceBuf = new byte[StateObject.BufferSize];
            }
            catch (SocketException)
            {

                Client.Close();

            }
        }
        void ProcessMess(ReviceBuffer buff)
        {
            byte[] byt = buff.ReviceByte;
            string Mess = Encoding.ASCII.GetString(byt).Trim().Trim((char)'\0');
            if (Mess.StartsWith("SynchroGetFile ", StringComparison.InvariantCultureIgnoreCase))
            {
                string FileName = Mess.Replace("SynchroGetFile ", "").Trim().Trim((char)0);
                SynchroSendFile(FileName);
            }
            if (Mess.StartsWith("SynchroUpFile ", StringComparison.InvariantCultureIgnoreCase))
            {
                string FileName = Mess.Replace("SynchroUpFile ", "").Trim().Trim((char)0);
                SynchroRecieveFile(FileName);
            }
        }

        private IAsyncResult re()
        {
            return null;
        }
        private void SynchroRecieveFile(string fileName)
        {

         

            byte[] byt = new byte[20400];
            int reviceLen = client.Receive(byt);
            SocketError flags;
            while (reviceLen > 0)
            {
                try
                {
                    SocketFileInfo fileInfo = SocketFileInfo.DeSerialize(byt);
                    using (FileStream fs = new FileStream(fileInfo.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                    {
                        fs.Position = fileInfo.CurrentOffset;
                        fs.Write(fileInfo.CurrentByte, 0, fileInfo.CurrentLen);
                        fs.Flush();
                        fs.Close();
                        fs.Dispose();
                    }
                    long downSize = fileInfo.CurrentOffset + fileInfo.CurrentLen;
                    int offset = (int)(downSize * 100 / fileInfo.FileLength);
                    SendComand(client,"Success!");


                    if (downSize == fileInfo.FileLength)
                    {
                        break;
                    }
                }
                catch
                {
                    SendComand(client,"Error!");

                }
                reviceLen = client.Receive(byt, 0, byt.Length, SocketFlags.None, out flags);
            }
        
        }

        void SynchroSendFile(string FileName)
        {
            
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);

            SocketFileInfo socketSendFile = new SocketFileInfo(client, fs, FileName);
            socketSendFile.FileLength = fs.Length;
            int currentLen = fs.Read(socketSendFile.CurrentByte, 0, socketSendFile.MaxLength);
            byte[] MessByte = new byte[1024];

            while (currentLen > 0)
            {
                socketSendFile.CurrentLen = currentLen;
                socketSendFile.CurrentOffset = socketSendFile.FileStream.Position - currentLen;
                byte[] Buff = SocketFileInfo.GetSendByte(socketSendFile);
                while (true)
                {
                    client.Send(Buff, 0, Buff.Length, SocketFlags.None);
                    client.Receive(MessByte, SocketFlags.None);
                    string Mess = Encoding.ASCII.GetString(MessByte).Trim().Trim((char)'\0');
                    if (Mess.Equals("Success!", StringComparison.InvariantCultureIgnoreCase))
                    {
                        break;
                    }
                }
                currentLen = fs.Read(socketSendFile.CurrentByte, 0, socketSendFile.MaxLength);
            }
            fs.Close();
            fs.Dispose();
            client.Close();
        }
        public void CloseClient(Socket Client)
        {
            Client.Close();
            Client = null;
        }
        public void SendComand(Socket ClientSocket, string Comand)
        {
            byte[] byt = Encoding.ASCII.GetBytes(Comand);
            ClientSocket.Send(byt);
        }
    }
}
