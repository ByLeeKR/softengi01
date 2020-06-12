namespace SOSIL_POS
{
    partial class POSSalescheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesView = new System.Windows.Forms.DataGridView();
            this.ComboDay = new System.Windows.Forms.ComboBox();
            this.ComboMonth = new System.Windows.Forms.ComboBox();
            this.ComboYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.TxtTotalsales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesView
            // 
            this.SalesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesView.Location = new System.Drawing.Point(13, 13);
            this.SalesView.Name = "SalesView";
            this.SalesView.RowTemplate.Height = 23;
            this.SalesView.Size = new System.Drawing.Size(223, 366);
            this.SalesView.TabIndex = 0;
            // 
            // ComboDay
            // 
            this.ComboDay.BackColor = System.Drawing.Color.White;
            this.ComboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboDay.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboDay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboDay.FormattingEnabled = true;
            this.ComboDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ComboDay.Location = new System.Drawing.Point(333, 42);
            this.ComboDay.Name = "ComboDay";
            this.ComboDay.Size = new System.Drawing.Size(43, 24);
            this.ComboDay.TabIndex = 2;
            // 
            // ComboMonth
            // 
            this.ComboMonth.BackColor = System.Drawing.Color.White;
            this.ComboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboMonth.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboMonth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboMonth.FormattingEnabled = true;
            this.ComboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ComboMonth.Location = new System.Drawing.Point(256, 42);
            this.ComboMonth.Name = "ComboMonth";
            this.ComboMonth.Size = new System.Drawing.Size(43, 24);
            this.ComboMonth.TabIndex = 3;
            this.ComboMonth.SelectedIndexChanged += new System.EventHandler(this.ComboMonth_SelectedIndexChanged);
            // 
            // ComboYear
            // 
            this.ComboYear.BackColor = System.Drawing.Color.White;
            this.ComboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboYear.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ComboYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboYear.FormattingEnabled = true;
            this.ComboYear.Location = new System.Drawing.Point(256, 12);
            this.ComboYear.Name = "ComboYear";
            this.ComboYear.Size = new System.Drawing.Size(120, 24);
            this.ComboYear.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(382, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "년";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(305, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "월";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(382, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "일";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(257, 73);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(148, 70);
            this.BtnCheck.TabIndex = 8;
            this.BtnCheck.Text = "매출 조회";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // TxtTotalsales
            // 
            this.TxtTotalsales.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtTotalsales.Location = new System.Drawing.Point(256, 353);
            this.TxtTotalsales.Name = "TxtTotalsales";
            this.TxtTotalsales.ReadOnly = true;
            this.TxtTotalsales.Size = new System.Drawing.Size(126, 26);
            this.TxtTotalsales.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(253, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "일일 총 매출";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(388, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "원";
            // 
            // POSSalescheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTotalsales);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboYear);
            this.Controls.Add(this.ComboMonth);
            this.Controls.Add(this.ComboDay);
            this.Controls.Add(this.SalesView);
            this.Name = "POSSalescheck";
            this.Text = "POSSalescheck";
            ((System.ComponentModel.ISupportInitialize)(this.SalesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesView;
        private System.Windows.Forms.ComboBox ComboDay;
        private System.Windows.Forms.ComboBox ComboMonth;
        private System.Windows.Forms.ComboBox ComboYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.TextBox TxtTotalsales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}