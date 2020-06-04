namespace SOSIL_POS
{
    partial class MenuManage
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
            this.components = new System.ComponentModel.Container();
            this.MenuView = new System.Windows.Forms.DataGridView();
            this.TxtMenuName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMenuPrice = new System.Windows.Forms.TextBox();
            this.BtnMenuAdd = new System.Windows.Forms.Button();
            this.BtnMenuDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataSet = new SOSIL_POS.DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MenuView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuView
            // 
            this.MenuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuView.Location = new System.Drawing.Point(13, 13);
            this.MenuView.Name = "MenuView";
            this.MenuView.ReadOnly = true;
            this.MenuView.RowTemplate.Height = 23;
            this.MenuView.Size = new System.Drawing.Size(387, 319);
            this.MenuView.TabIndex = 0;
            // 
            // TxtMenuName
            // 
            this.TxtMenuName.Location = new System.Drawing.Point(69, 14);
            this.TxtMenuName.Name = "TxtMenuName";
            this.TxtMenuName.Size = new System.Drawing.Size(207, 21);
            this.TxtMenuName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMenuPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtMenuName);
            this.groupBox1.Location = new System.Drawing.Point(12, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메뉴 추가";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "메뉴 이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "메뉴 가격";
            // 
            // TxtMenuPrice
            // 
            this.TxtMenuPrice.Location = new System.Drawing.Point(69, 42);
            this.TxtMenuPrice.Name = "TxtMenuPrice";
            this.TxtMenuPrice.Size = new System.Drawing.Size(207, 21);
            this.TxtMenuPrice.TabIndex = 5;
            // 
            // BtnMenuAdd
            // 
            this.BtnMenuAdd.Location = new System.Drawing.Point(301, 352);
            this.BtnMenuAdd.Name = "BtnMenuAdd";
            this.BtnMenuAdd.Size = new System.Drawing.Size(99, 49);
            this.BtnMenuAdd.TabIndex = 6;
            this.BtnMenuAdd.Text = "메뉴 추가";
            this.BtnMenuAdd.UseVisualStyleBackColor = true;
            this.BtnMenuAdd.Click += new System.EventHandler(this.BtnMenuAdd_Click);
            // 
            // BtnMenuDelete
            // 
            this.BtnMenuDelete.Location = new System.Drawing.Point(301, 407);
            this.BtnMenuDelete.Name = "BtnMenuDelete";
            this.BtnMenuDelete.Size = new System.Drawing.Size(99, 49);
            this.BtnMenuDelete.TabIndex = 7;
            this.BtnMenuDelete.Text = "메뉴 삭제";
            this.BtnMenuDelete.UseVisualStyleBackColor = true;
            this.BtnMenuDelete.Click += new System.EventHandler(this.BtnMenuDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "메뉴 삭제: 현재 선택된 메뉴를 DB에서 삭제합니다";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // MenuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnMenuDelete);
            this.Controls.Add(this.BtnMenuAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MenuView);
            this.Name = "MenuManage";
            this.Text = "SOSIL_POS: 메뉴 관리";
            this.Load += new System.EventHandler(this.MenuManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MenuView;
        private System.Windows.Forms.TextBox TxtMenuName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtMenuPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMenuAdd;
        private System.Windows.Forms.Button BtnMenuDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private DataSet dataSet;
    }
}