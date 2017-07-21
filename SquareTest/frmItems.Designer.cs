namespace SquareTest
{
    partial class frmItems
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtItemQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemSellPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemBuyingPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemNote = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnItemImage = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEdit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(931, 612);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Depth = 0;
            this.txtItemQuantity.Hint = "Quantity";
            this.txtItemQuantity.Location = new System.Drawing.Point(17, 327);
            this.txtItemQuantity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtItemQuantity.MaxLength = 32767;
            this.txtItemQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.PasswordChar = '\0';
            this.txtItemQuantity.SelectedText = "";
            this.txtItemQuantity.SelectionLength = 0;
            this.txtItemQuantity.SelectionStart = 0;
            this.txtItemQuantity.Size = new System.Drawing.Size(325, 23);
            this.txtItemQuantity.TabIndex = 15;
            this.txtItemQuantity.TabStop = false;
            this.txtItemQuantity.UseSystemPasswordChar = false;
            // 
            // txtItemSellPrice
            // 
            this.txtItemSellPrice.Depth = 0;
            this.txtItemSellPrice.Hint = "SellPrice";
            this.txtItemSellPrice.Location = new System.Drawing.Point(17, 378);
            this.txtItemSellPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtItemSellPrice.MaxLength = 32767;
            this.txtItemSellPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemSellPrice.Name = "txtItemSellPrice";
            this.txtItemSellPrice.PasswordChar = '\0';
            this.txtItemSellPrice.SelectedText = "";
            this.txtItemSellPrice.SelectionLength = 0;
            this.txtItemSellPrice.SelectionStart = 0;
            this.txtItemSellPrice.Size = new System.Drawing.Size(325, 23);
            this.txtItemSellPrice.TabIndex = 14;
            this.txtItemSellPrice.TabStop = false;
            this.txtItemSellPrice.UseSystemPasswordChar = false;
            // 
            // txtItemBuyingPrice
            // 
            this.txtItemBuyingPrice.Depth = 0;
            this.txtItemBuyingPrice.Hint = "BuyingPrice";
            this.txtItemBuyingPrice.Location = new System.Drawing.Point(17, 430);
            this.txtItemBuyingPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtItemBuyingPrice.MaxLength = 32767;
            this.txtItemBuyingPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemBuyingPrice.Name = "txtItemBuyingPrice";
            this.txtItemBuyingPrice.PasswordChar = '\0';
            this.txtItemBuyingPrice.SelectedText = "";
            this.txtItemBuyingPrice.SelectionLength = 0;
            this.txtItemBuyingPrice.SelectionStart = 0;
            this.txtItemBuyingPrice.Size = new System.Drawing.Size(325, 23);
            this.txtItemBuyingPrice.TabIndex = 13;
            this.txtItemBuyingPrice.TabStop = false;
            this.txtItemBuyingPrice.UseSystemPasswordChar = false;
            // 
            // txtItemNote
            // 
            this.txtItemNote.Depth = 0;
            this.txtItemNote.Hint = "Note";
            this.txtItemNote.Location = new System.Drawing.Point(17, 481);
            this.txtItemNote.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtItemNote.MaxLength = 32767;
            this.txtItemNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemNote.Name = "txtItemNote";
            this.txtItemNote.PasswordChar = '\0';
            this.txtItemNote.SelectedText = "";
            this.txtItemNote.SelectionLength = 0;
            this.txtItemNote.SelectionStart = 0;
            this.txtItemNote.Size = new System.Drawing.Size(325, 23);
            this.txtItemNote.TabIndex = 12;
            this.txtItemNote.TabStop = false;
            this.txtItemNote.UseSystemPasswordChar = false;
            // 
            // txtItemName
            // 
            this.txtItemName.Depth = 0;
            this.txtItemName.Hint = "ItemName";
            this.txtItemName.Location = new System.Drawing.Point(17, 276);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.Size = new System.Drawing.Size(325, 23);
            this.txtItemName.TabIndex = 11;
            this.txtItemName.TabStop = false;
            this.txtItemName.UseSystemPasswordChar = false;
            // 
            // btnItemImage
            // 
            this.btnItemImage.AutoSize = true;
            this.btnItemImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnItemImage.Depth = 0;
            this.btnItemImage.Icon = null;
            this.btnItemImage.Location = new System.Drawing.Point(128, 207);
            this.btnItemImage.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.btnItemImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnItemImage.Name = "btnItemImage";
            this.btnItemImage.Primary = false;
            this.btnItemImage.Size = new System.Drawing.Size(94, 36);
            this.btnItemImage.TabIndex = 10;
            this.btnItemImage.Text = "add image";
            this.btnItemImage.UseVisualStyleBackColor = true;
            this.btnItemImage.Click += new System.EventHandler(this.btnItemImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "Search";
            this.txtSearch.Location = new System.Drawing.Point(25, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(450, 23);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(2424, 147);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(72, 36);
            this.materialRaisedButton1.TabIndex = 20;
            this.materialRaisedButton1.Text = "Report";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(180, 573);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = false;
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(95, 573);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = false;
            this.btnDelete.Size = new System.Drawing.Size(69, 36);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(29, 525);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = true;
            this.btnEdit.Size = new System.Drawing.Size(50, 36);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(294, 525);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(48, 36);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.Controls.Add(this.btnItemImage);
            this.panelMain.Controls.Add(this.btnDelete);
            this.panelMain.Controls.Add(this.txtItemName);
            this.panelMain.Controls.Add(this.btnEdit);
            this.panelMain.Controls.Add(this.txtItemNote);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.txtItemBuyingPrice);
            this.panelMain.Controls.Add(this.txtItemSellPrice);
            this.panelMain.Controls.Add(this.txtItemQuantity);
            this.panelMain.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(15, 134);
            this.panelMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(370, 612);
            this.panelMain.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(685, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 33);
            this.panel1.TabIndex = 26;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmItems";
            this.Text = "frmItems";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemQuantity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemSellPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemBuyingPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemNote;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemName;
        private MaterialSkin.Controls.MaterialFlatButton btnItemImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton btnCancel;
        private MaterialSkin.Controls.MaterialFlatButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnEdit;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
    }
}