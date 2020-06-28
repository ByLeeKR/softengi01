namespace SOSIL_POS
{
    partial class POSSend
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
            this.MenuList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenuList
            // 
            this.MenuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.AmountColumn,
            this.PriceColumn});
            this.MenuList.HideSelection = false;
            this.MenuList.Location = new System.Drawing.Point(12, 35);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(237, 337);
            this.MenuList.TabIndex = 2;
            this.MenuList.UseCompatibleStateImageBehavior = false;
            this.MenuList.View = System.Windows.Forms.View.Details;
            this.MenuList.DoubleClick += new System.EventHandler(this.MenuList_DoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "메뉴 이름";
            this.NameColumn.Width = 116;
            // 
            // AmountColumn
            // 
            this.AmountColumn.Text = "수량";
            this.AmountColumn.Width = 38;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Text = "가격";
            this.PriceColumn.Width = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "주방에 전송";
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(12, 400);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(237, 38);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "전부 보내기";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "메뉴 더블 클릭 시 주방으로 전송됩니다.";
            // 
            // POSSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuList);
            this.Name = "POSSend";
            this.Text = "SOSIL_POS: 주방에 전송";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView MenuList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader AmountColumn;
        private System.Windows.Forms.ColumnHeader PriceColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label2;
    }
}