namespace Client
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbWCFDown = new System.Windows.Forms.ProgressBar();
            this.lbWCFDown = new System.Windows.Forms.Label();
            this.pbSocketDown = new System.Windows.Forms.ProgressBar();
            this.lbSocketDown = new System.Windows.Forms.Label();
            this.lbWCFDownPos = new System.Windows.Forms.Label();
            this.lbSocketDownPos = new System.Windows.Forms.Label();
            this.txtServerFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendMess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDown = new System.Windows.Forms.ProgressBar();
            this.lbDown = new System.Windows.Forms.Label();
            this.lbDownPos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbSocketAsyDown = new System.Windows.Forms.ProgressBar();
            this.lbSocketDownAsy = new System.Windows.Forms.Label();
            this.lbSocketAsyDownPos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(242, 334);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 34);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(48, 334);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(112, 34);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "WCF回调下载";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Socket下载";
            // 
            // pbWCFDown
            // 
            this.pbWCFDown.Location = new System.Drawing.Point(129, 146);
            this.pbWCFDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbWCFDown.Name = "pbWCFDown";
            this.pbWCFDown.Size = new System.Drawing.Size(351, 30);
            this.pbWCFDown.TabIndex = 4;
            // 
            // lbWCFDown
            // 
            this.lbWCFDown.AutoSize = true;
            this.lbWCFDown.Location = new System.Drawing.Point(572, 150);
            this.lbWCFDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWCFDown.Name = "lbWCFDown";
            this.lbWCFDown.Size = new System.Drawing.Size(26, 18);
            this.lbWCFDown.TabIndex = 5;
            this.lbWCFDown.Text = "0k";
            // 
            // pbSocketDown
            // 
            this.pbSocketDown.Location = new System.Drawing.Point(129, 201);
            this.pbSocketDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSocketDown.Name = "pbSocketDown";
            this.pbSocketDown.Size = new System.Drawing.Size(351, 30);
            this.pbSocketDown.TabIndex = 4;
            // 
            // lbSocketDown
            // 
            this.lbSocketDown.AutoSize = true;
            this.lbSocketDown.Location = new System.Drawing.Point(572, 206);
            this.lbSocketDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSocketDown.Name = "lbSocketDown";
            this.lbSocketDown.Size = new System.Drawing.Size(26, 18);
            this.lbSocketDown.TabIndex = 5;
            this.lbSocketDown.Text = "0k";
            // 
            // lbWCFDownPos
            // 
            this.lbWCFDownPos.AutoSize = true;
            this.lbWCFDownPos.Location = new System.Drawing.Point(489, 150);
            this.lbWCFDownPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWCFDownPos.Name = "lbWCFDownPos";
            this.lbWCFDownPos.Size = new System.Drawing.Size(26, 18);
            this.lbWCFDownPos.TabIndex = 5;
            this.lbWCFDownPos.Text = "0%";
            // 
            // lbSocketDownPos
            // 
            this.lbSocketDownPos.AutoSize = true;
            this.lbSocketDownPos.Location = new System.Drawing.Point(489, 206);
            this.lbSocketDownPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSocketDownPos.Name = "lbSocketDownPos";
            this.lbSocketDownPos.Size = new System.Drawing.Size(26, 18);
            this.lbSocketDownPos.TabIndex = 5;
            this.lbSocketDownPos.Text = "0%";
            // 
            // txtServerFileName
            // 
            this.txtServerFileName.Location = new System.Drawing.Point(129, 18);
            this.txtServerFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerFileName.Name = "txtServerFileName";
            this.txtServerFileName.Size = new System.Drawing.Size(349, 28);
            this.txtServerFileName.TabIndex = 6;
            this.txtServerFileName.Text = "EGSQL_GREEN.rar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "服务器文件";
            // 
            // btnSendMess
            // 
            this.btnSendMess.Location = new System.Drawing.Point(432, 334);
            this.btnSendMess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendMess.Name = "btnSendMess";
            this.btnSendMess.Size = new System.Drawing.Size(112, 34);
            this.btnSendMess.TabIndex = 7;
            this.btnSendMess.Text = "上传";
            this.btnSendMess.UseVisualStyleBackColor = true;
            this.btnSendMess.Click += new System.EventHandler(this.btnSendMess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "WCF同步下载";
            // 
            // pbDown
            // 
            this.pbDown.Location = new System.Drawing.Point(129, 88);
            this.pbDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(351, 30);
            this.pbDown.TabIndex = 4;
            // 
            // lbDown
            // 
            this.lbDown.AutoSize = true;
            this.lbDown.Location = new System.Drawing.Point(572, 93);
            this.lbDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDown.Name = "lbDown";
            this.lbDown.Size = new System.Drawing.Size(26, 18);
            this.lbDown.TabIndex = 5;
            this.lbDown.Text = "0k";
            // 
            // lbDownPos
            // 
            this.lbDownPos.AutoSize = true;
            this.lbDownPos.Location = new System.Drawing.Point(489, 93);
            this.lbDownPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDownPos.Name = "lbDownPos";
            this.lbDownPos.Size = new System.Drawing.Size(26, 18);
            this.lbDownPos.TabIndex = 5;
            this.lbDownPos.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Socket同步";
            // 
            // pbSocketAsyDown
            // 
            this.pbSocketAsyDown.Location = new System.Drawing.Point(129, 255);
            this.pbSocketAsyDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSocketAsyDown.Name = "pbSocketAsyDown";
            this.pbSocketAsyDown.Size = new System.Drawing.Size(351, 30);
            this.pbSocketAsyDown.TabIndex = 4;
            // 
            // lbSocketDownAsy
            // 
            this.lbSocketDownAsy.AutoSize = true;
            this.lbSocketDownAsy.Location = new System.Drawing.Point(572, 260);
            this.lbSocketDownAsy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSocketDownAsy.Name = "lbSocketDownAsy";
            this.lbSocketDownAsy.Size = new System.Drawing.Size(26, 18);
            this.lbSocketDownAsy.TabIndex = 5;
            this.lbSocketDownAsy.Text = "0k";
            // 
            // lbSocketAsyDownPos
            // 
            this.lbSocketAsyDownPos.AutoSize = true;
            this.lbSocketAsyDownPos.Location = new System.Drawing.Point(489, 260);
            this.lbSocketAsyDownPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSocketAsyDownPos.Name = "lbSocketAsyDownPos";
            this.lbSocketAsyDownPos.Size = new System.Drawing.Size(26, 18);
            this.lbSocketAsyDownPos.TabIndex = 5;
            this.lbSocketAsyDownPos.Text = "0%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 417);
            this.Controls.Add(this.btnSendMess);
            this.Controls.Add(this.txtServerFileName);
            this.Controls.Add(this.lbSocketAsyDownPos);
            this.Controls.Add(this.lbSocketDownPos);
            this.Controls.Add(this.lbSocketDownAsy);
            this.Controls.Add(this.lbSocketDown);
            this.Controls.Add(this.lbDownPos);
            this.Controls.Add(this.lbWCFDownPos);
            this.Controls.Add(this.lbDown);
            this.Controls.Add(this.lbWCFDown);
            this.Controls.Add(this.pbSocketAsyDown);
            this.Controls.Add(this.pbSocketDown);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbWCFDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbWCFDown;
        private System.Windows.Forms.Label lbWCFDown;
        private System.Windows.Forms.ProgressBar pbSocketDown;
        private System.Windows.Forms.Label lbSocketDown;
        private System.Windows.Forms.Label lbWCFDownPos;
        private System.Windows.Forms.Label lbSocketDownPos;
        private System.Windows.Forms.TextBox txtServerFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendMess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbDown;
        private System.Windows.Forms.Label lbDown;
        private System.Windows.Forms.Label lbDownPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbSocketAsyDown;
        private System.Windows.Forms.Label lbSocketDownAsy;
        private System.Windows.Forms.Label lbSocketAsyDownPos;
    }
}

