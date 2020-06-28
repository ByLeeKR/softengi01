namespace SOSIL_POS
{
    partial class MainLogin
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtPW = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnOffline = new System.Windows.Forms.Button();
            this.PicLogin = new System.Windows.Forms.PictureBox();
            this.BtnGuide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLabel
            // 
            this.TxtLabel.AutoSize = true;
            this.TxtLabel.Location = new System.Drawing.Point(12, 142);
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.Size = new System.Drawing.Size(63, 12);
            this.TxtLabel.TabIndex = 0;
            this.TxtLabel.Text = "MYSQL ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "SQL PORT";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(91, 139);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(153, 21);
            this.TxtID.TabIndex = 3;
            // 
            // TxtPW
            // 
            this.TxtPW.Location = new System.Drawing.Point(91, 170);
            this.TxtPW.Name = "TxtPW";
            this.TxtPW.PasswordChar = '*';
            this.TxtPW.Size = new System.Drawing.Size(153, 21);
            this.TxtPW.TabIndex = 4;
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(91, 201);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(153, 21);
            this.TxtPort.TabIndex = 5;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(250, 139);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(88, 83);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnOffline
            // 
            this.BtnOffline.Location = new System.Drawing.Point(344, 139);
            this.BtnOffline.Name = "BtnOffline";
            this.BtnOffline.Size = new System.Drawing.Size(88, 83);
            this.BtnOffline.TabIndex = 7;
            this.BtnOffline.Text = "OFFLINE  MODE";
            this.BtnOffline.UseVisualStyleBackColor = true;
            this.BtnOffline.Click += new System.EventHandler(this.BtnOffline_Click);
            // 
            // PicLogin
            // 
            this.PicLogin.Image = global::SOSIL_POS.Properties.Resources.SchoolLogo;
            this.PicLogin.Location = new System.Drawing.Point(12, 12);
            this.PicLogin.Name = "PicLogin";
            this.PicLogin.Size = new System.Drawing.Size(417, 105);
            this.PicLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogin.TabIndex = 8;
            this.PicLogin.TabStop = false;
            // 
            // BtnGuide
            // 
            this.BtnGuide.Location = new System.Drawing.Point(14, 231);
            this.BtnGuide.Name = "BtnGuide";
            this.BtnGuide.Size = new System.Drawing.Size(418, 23);
            this.BtnGuide.TabIndex = 9;
            this.BtnGuide.Text = "MySQL 다운로드 (인터넷 연결 필요)";
            this.BtnGuide.UseVisualStyleBackColor = true;
            this.BtnGuide.Click += new System.EventHandler(this.BtnGuide_Click);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 266);
            this.Controls.Add(this.BtnGuide);
            this.Controls.Add(this.PicLogin);
            this.Controls.Add(this.BtnOffline);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.TxtPW);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtLabel);
            this.Name = "MainLogin";
            this.Text = "SOSIL_POS: LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtPW;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnOffline;
        private System.Windows.Forms.PictureBox PicLogin;
        private System.Windows.Forms.Button BtnGuide;
    }
}

