namespace SOSIL_POS
{
    partial class MenuSelect
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
            this.MenuList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSet = new SOSIL_POS.DataSet();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuView
            // 
            this.MenuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuView.Location = new System.Drawing.Point(255, 12);
            this.MenuView.Name = "MenuView";
            this.MenuView.ReadOnly = true;
            this.MenuView.RowTemplate.Height = 23;
            this.MenuView.Size = new System.Drawing.Size(237, 337);
            this.MenuView.TabIndex = 0;
            this.MenuView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuView_CellContentDoubleClicked);
            // 
            // MenuList
            // 
            this.MenuList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.AmountColumn,
            this.PriceColumn});
            this.MenuList.HideSelection = false;
            this.MenuList.Location = new System.Drawing.Point(12, 12);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(237, 337);
            this.MenuList.TabIndex = 1;
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
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(336, 362);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "확인";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(417, 362);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 397);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.MenuList);
            this.Controls.Add(this.MenuView);
            this.Name = "MenuSelect";
            this.Text = "MenuSelect";
            this.Load += new System.EventHandler(this.MenuSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MenuView;
        private System.Windows.Forms.ListView MenuList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader AmountColumn;
        private System.Windows.Forms.ColumnHeader PriceColumn;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
    }
}