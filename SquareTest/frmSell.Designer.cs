namespace SquareTest
{
    partial class frmSell
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
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblBillNo = new MaterialSkin.Controls.MaterialLabel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveBill = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblDate = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colQuantity,
            this.colUnitPrice,
            this.colPrice});
            this.dataGridView1.Location = new System.Drawing.Point(83, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1190, 417);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.FillWeight = 61.54822F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colQuantity
            // 
            this.colQuantity.FillWeight = 61.54822F;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FillWeight = 61.54822F;
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colPrice
            // 
            this.colPrice.FillWeight = 61.54822F;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtNote.Location = new System.Drawing.Point(83, 592);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(436, 127);
            this.txtNote.TabIndex = 1;
            this.txtNote.Text = "Notes";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBillNo.Depth = 0;
            this.lblBillNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBillNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBillNo.Location = new System.Drawing.Point(1152, 107);
            this.lblBillNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(17, 19);
            this.lblBillNo.TabIndex = 2;
            this.lblBillNo.Text = "0";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCustomerName.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtCustomerName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCustomerName.Location = new System.Drawing.Point(83, 107);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(217, 32);
            this.txtCustomerName.TabIndex = 3;
            this.txtCustomerName.TabStop = false;
            this.txtCustomerName.Text = "Name";
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtAddress.Depth = 0;
            this.txtAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(532, 107);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(220, 23);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.TabStop = false;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtPhone.Depth = 0;
            this.txtPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPhone.Hint = "";
            this.txtPhone.Location = new System.Drawing.Point(306, 107);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.Size = new System.Drawing.Size(220, 23);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TabStop = false;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalPrice.Depth = 0;
            this.lblTotalPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(1067, 603);
            this.lblTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(73, 19);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "00000000";
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.AutoSize = true;
            this.btnSaveBill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveBill.Depth = 0;
            this.btnSaveBill.Icon = null;
            this.btnSaveBill.Location = new System.Drawing.Point(1218, 683);
            this.btnSaveBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Primary = true;
            this.btnSaveBill.Size = new System.Drawing.Size(55, 36);
            this.btnSaveBill.TabIndex = 6;
            this.btnSaveBill.Text = "Save";
            this.btnSaveBill.UseVisualStyleBackColor = true;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDate.Depth = 0;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(1152, 141);
            this.lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "00-00-0000";
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 732);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSell";
            this.Text = "frmSell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.TextBox txtNote;
        private MaterialSkin.Controls.MaterialLabel lblBillNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddress;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPhone;
        private MaterialSkin.Controls.MaterialLabel lblTotalPrice;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveBill;
        private MaterialSkin.Controls.MaterialLabel lblDate;
    }
}