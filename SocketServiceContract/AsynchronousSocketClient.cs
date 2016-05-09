using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace SocketServiceContract
{
    public delegate void AsynchronousDownFilePos(long DownSize, int offset);
    public class AsynchronousSocketClient
    {
        public AsynchronousSocketClient(AsynchronousDownFilePos AsynchronousData)
        {
            this.AsynchronousData = AsynchronousData;
        }
        public AsynchronousSocketClient()
        {
            this.AsynchronousData = null;
        }
        private Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        AsynchronousDownFilePos AsynchronousData = null;
        public void Stop()
        {
            if (ClientSocket != null)
            {

                ClientSocket.Disconnect(false);
            }
        }


        public void Connect(string ConnectIP, int Port)
        {

            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ClientSocket.Connect(ConnectIP, Port);
            this.SendComand("Asynchronous");
            StateObject so = new StateObject();
            so.Client = ClientSocket;

        }
        public void DownFile(string FileName)
        {
            SendComand("SynchroGetFile " + FileName);
            byte[] byt = new byte[20400];
            int reviceLen = ClientSocket.Receive(byt);
            SocketError flags;
            while (reviceLen > 0)
            {
                try
                {
                    SocketFileInfo fileInfo = SocketFileInfo.DeSerialize(byt);
                    using (FileStream fs = new FileStream( fileInfo.FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                    {
                        fs.Position = fileInfo.CurrentOffset;
                        fs.Write(fileInfo.CurrentByte, 0, fileInfo.CurrentLen);
                        fs.Flush();
                        fs.Close();
                        fs.Dispose();
                    }
                    long downSize = fileInfo.CurrentOffset + fileInfo.CurrentLen;
                    int offset = (int)(downSize * 100 / fileInfo.FileLength);
                    if (AsynchronousData!=null)
                    { AsynchronousData.Invoke(downSize, offset); }
                   
                    SendComand("Success!");
                    if (downSize == fileInfo.FileLength)
                    {
                        break;
                    }
                }
                catch
                {
                    SendComand("Error!");
                }
                reviceLen = ClientSocket.Receive(byt, 0, byt.Length, SocketFlags.None, out flags);
            }
        }
        public void SendComand(string Comand)
        {
            byte[] byt = Encoding.ASCII.GetBytes(Comand);
            ClientSocket.Send(byt);
        }


        public void SynchroSendFile(string FileName)
        {
            SendComand("SynchroUpFile " + FileName);
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);

            SocketFileInfo socketSendFile = new SocketFileInfo(ClientSocket, fs, FileName);
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
                    ClientSocket.Send(Buff, 0, Buff.Length, SocketFlags.None);
                    ClientSocket.Receive(MessByte, SocketFlags.None);
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
            ClientSocket.Close();
        }
    }
}
