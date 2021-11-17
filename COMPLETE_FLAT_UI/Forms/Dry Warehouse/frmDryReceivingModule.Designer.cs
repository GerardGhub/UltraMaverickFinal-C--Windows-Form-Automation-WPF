﻿
namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    partial class frmDryReceivingModule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDryReceivingModule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mattxtbarcode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mattxtexpirydate = new MetroFramework.Controls.MetroDateTime();
            this.dgvMajorCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.major_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.major_category_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mattxtmfgdate = new MetroFramework.Controls.MetroDateTime();
            this.mattxtcategory = new MaterialSkin.Controls.MaterialTextBox();
            this.matdaysExpiry = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtSupplier = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtitemdesc = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtreceivingdate = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtitemcode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnAddRejetModal = new System.Windows.Forms.Button();
            this.mattxtLotDescription = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSelectLot = new System.Windows.Forms.Button();
            this.mattxtupdatedstocks = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtponumber = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtqtyreject = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtqtyReceived = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtsoh = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtlotno = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtactualdelivery = new MaterialSkin.Controls.MaterialTextBox();
            this.mattxtqtyuom = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mattxtReceived = new MaterialSkin.Controls.MaterialButton();
            this.matbtnCancel = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.crV1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dgvReceivedID = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorCategory)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedID)).BeginInit();
            this.SuspendLayout();
            // 
            // mattxtbarcode
            // 
            this.mattxtbarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtbarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtbarcode.Depth = 0;
            this.mattxtbarcode.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtbarcode.Hint = "Scan the Barcode";
            this.mattxtbarcode.Location = new System.Drawing.Point(22, 9);
            this.mattxtbarcode.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtbarcode.MaxLength = 50;
            this.mattxtbarcode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtbarcode.Multiline = false;
            this.mattxtbarcode.Name = "mattxtbarcode";
            this.mattxtbarcode.Size = new System.Drawing.Size(682, 36);
            this.mattxtbarcode.TabIndex = 0;
            this.mattxtbarcode.Text = "";
            this.mattxtbarcode.UseTallSize = false;
            this.mattxtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mattxtbarcode_KeyDown);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.mattxtbarcode);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard1.Size = new System.Drawing.Size(726, 52);
            this.materialCard1.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.bunifuCustomLabel2);
            this.materialCard2.Controls.Add(this.bunifuCustomLabel1);
            this.materialCard2.Controls.Add(this.mattxtexpirydate);
            this.materialCard2.Controls.Add(this.dgvMajorCategory);
            this.materialCard2.Controls.Add(this.mattxtmfgdate);
            this.materialCard2.Controls.Add(this.mattxtcategory);
            this.materialCard2.Controls.Add(this.matdaysExpiry);
            this.materialCard2.Controls.Add(this.mattxtSupplier);
            this.materialCard2.Controls.Add(this.mattxtitemdesc);
            this.materialCard2.Controls.Add(this.mattxtreceivingdate);
            this.materialCard2.Controls.Add(this.mattxtitemcode);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(22, 142);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard2.Size = new System.Drawing.Size(726, 264);
            this.materialCard2.TabIndex = 1;
            this.materialCard2.Visible = false;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(254, 202);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(61, 13);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "Expiry Date";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(10, 202);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "MFTG. Date";
            // 
            // mattxtexpirydate
            // 
            this.mattxtexpirydate.Enabled = false;
            this.mattxtexpirydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mattxtexpirydate.Location = new System.Drawing.Point(256, 223);
            this.mattxtexpirydate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mattxtexpirydate.Name = "mattxtexpirydate";
            this.mattxtexpirydate.Size = new System.Drawing.Size(213, 29);
            this.mattxtexpirydate.TabIndex = 29;
            // 
            // dgvMajorCategory
            // 
            this.dgvMajorCategory.AllowUserToAddRows = false;
            this.dgvMajorCategory.AllowUserToDeleteRows = false;
            this.dgvMajorCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMajorCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMajorCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMajorCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMajorCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMajorCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMajorCategory.ColumnHeadersHeight = 35;
            this.dgvMajorCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMajorCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.major_category_id,
            this.major_category_desc,
            this.mc_added_at,
            this.mc_added_by,
            this.mc_updated_at,
            this.mc_updated_by});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMajorCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMajorCategory.EnableHeadersVisualStyles = false;
            this.dgvMajorCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.Location = new System.Drawing.Point(151, 257);
            this.dgvMajorCategory.MultiSelect = false;
            this.dgvMajorCategory.Name = "dgvMajorCategory";
            this.dgvMajorCategory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMajorCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMajorCategory.RowHeadersVisible = false;
            this.dgvMajorCategory.RowHeadersWidth = 102;
            this.dgvMajorCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMajorCategory.RowTemplate.DividerHeight = 5;
            this.dgvMajorCategory.RowTemplate.Height = 40;
            this.dgvMajorCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMajorCategory.Size = new System.Drawing.Size(653, 21);
            this.dgvMajorCategory.TabIndex = 594;
            this.dgvMajorCategory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMajorCategory.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMajorCategory.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMajorCategory.ThemeStyle.ReadOnly = true;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMajorCategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvMajorCategory.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMajorCategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvMajorCategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMajorCategory.CurrentCellChanged += new System.EventHandler(this.dgvMajorCategory_CurrentCellChanged);
            // 
            // major_category_id
            // 
            this.major_category_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.major_category_id.DataPropertyName = "major_category_id";
            this.major_category_id.FillWeight = 40.60914F;
            this.major_category_id.HeaderText = "ID";
            this.major_category_id.MinimumWidth = 12;
            this.major_category_id.Name = "major_category_id";
            this.major_category_id.ReadOnly = true;
            this.major_category_id.Width = 12;
            // 
            // major_category_desc
            // 
            this.major_category_desc.DataPropertyName = "major_category_desc";
            this.major_category_desc.FillWeight = 99.49239F;
            this.major_category_desc.HeaderText = "ITEM CLASS";
            this.major_category_desc.MinimumWidth = 12;
            this.major_category_desc.Name = "major_category_desc";
            this.major_category_desc.ReadOnly = true;
            // 
            // mc_added_at
            // 
            this.mc_added_at.DataPropertyName = "mc_added_at";
            this.mc_added_at.FillWeight = 99.49239F;
            this.mc_added_at.HeaderText = "CREATED DATE";
            this.mc_added_at.MinimumWidth = 12;
            this.mc_added_at.Name = "mc_added_at";
            this.mc_added_at.ReadOnly = true;
            // 
            // mc_added_by
            // 
            this.mc_added_by.DataPropertyName = "mc_added_by";
            this.mc_added_by.FillWeight = 99.49239F;
            this.mc_added_by.HeaderText = "CREATED BY";
            this.mc_added_by.MinimumWidth = 12;
            this.mc_added_by.Name = "mc_added_by";
            this.mc_added_by.ReadOnly = true;
            // 
            // mc_updated_at
            // 
            this.mc_updated_at.DataPropertyName = "mc_updated_at";
            this.mc_updated_at.FillWeight = 99.49239F;
            this.mc_updated_at.HeaderText = "UPDATED DATE";
            this.mc_updated_at.MinimumWidth = 12;
            this.mc_updated_at.Name = "mc_updated_at";
            this.mc_updated_at.ReadOnly = true;
            // 
            // mc_updated_by
            // 
            this.mc_updated_by.DataPropertyName = "mc_updated_by";
            this.mc_updated_by.HeaderText = "UPDATED BY";
            this.mc_updated_by.MinimumWidth = 12;
            this.mc_updated_by.Name = "mc_updated_by";
            this.mc_updated_by.ReadOnly = true;
            // 
            // mattxtmfgdate
            // 
            this.mattxtmfgdate.Enabled = false;
            this.mattxtmfgdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mattxtmfgdate.Location = new System.Drawing.Point(8, 223);
            this.mattxtmfgdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.mattxtmfgdate.Name = "mattxtmfgdate";
            this.mattxtmfgdate.Size = new System.Drawing.Size(215, 29);
            this.mattxtmfgdate.TabIndex = 28;
            // 
            // mattxtcategory
            // 
            this.mattxtcategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtcategory.Depth = 0;
            this.mattxtcategory.Enabled = false;
            this.mattxtcategory.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtcategory.Hint = "Category";
            this.mattxtcategory.Location = new System.Drawing.Point(256, 37);
            this.mattxtcategory.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtcategory.MaxLength = 50;
            this.mattxtcategory.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtcategory.Multiline = false;
            this.mattxtcategory.Name = "mattxtcategory";
            this.mattxtcategory.Size = new System.Drawing.Size(215, 50);
            this.mattxtcategory.TabIndex = 26;
            this.mattxtcategory.Text = "";
            // 
            // matdaysExpiry
            // 
            this.matdaysExpiry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.matdaysExpiry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matdaysExpiry.Depth = 0;
            this.matdaysExpiry.Enabled = false;
            this.matdaysExpiry.Font = new System.Drawing.Font("Roboto", 12F);
            this.matdaysExpiry.Hint = "Expiry Days";
            this.matdaysExpiry.Location = new System.Drawing.Point(501, 203);
            this.matdaysExpiry.Margin = new System.Windows.Forms.Padding(1);
            this.matdaysExpiry.MaxLength = 50;
            this.matdaysExpiry.MouseState = MaterialSkin.MouseState.OUT;
            this.matdaysExpiry.Multiline = false;
            this.matdaysExpiry.Name = "matdaysExpiry";
            this.matdaysExpiry.Size = new System.Drawing.Size(215, 50);
            this.matdaysExpiry.TabIndex = 7;
            this.matdaysExpiry.Text = "";
            // 
            // mattxtSupplier
            // 
            this.mattxtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtSupplier.Depth = 0;
            this.mattxtSupplier.Enabled = false;
            this.mattxtSupplier.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtSupplier.Hint = "Suppliers";
            this.mattxtSupplier.Location = new System.Drawing.Point(8, 144);
            this.mattxtSupplier.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtSupplier.MaxLength = 50;
            this.mattxtSupplier.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtSupplier.Multiline = false;
            this.mattxtSupplier.Name = "mattxtSupplier";
            this.mattxtSupplier.Size = new System.Drawing.Size(708, 50);
            this.mattxtSupplier.TabIndex = 5;
            this.mattxtSupplier.Text = "";
            // 
            // mattxtitemdesc
            // 
            this.mattxtitemdesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mattxtitemdesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtitemdesc.Depth = 0;
            this.mattxtitemdesc.Enabled = false;
            this.mattxtitemdesc.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtitemdesc.Hint = "Description";
            this.mattxtitemdesc.Location = new System.Drawing.Point(8, 91);
            this.mattxtitemdesc.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtitemdesc.MaxLength = 50;
            this.mattxtitemdesc.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtitemdesc.Multiline = false;
            this.mattxtitemdesc.Name = "mattxtitemdesc";
            this.mattxtitemdesc.Size = new System.Drawing.Size(708, 50);
            this.mattxtitemdesc.TabIndex = 4;
            this.mattxtitemdesc.Text = "";
            // 
            // mattxtreceivingdate
            // 
            this.mattxtreceivingdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtreceivingdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtreceivingdate.Depth = 0;
            this.mattxtreceivingdate.Enabled = false;
            this.mattxtreceivingdate.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtreceivingdate.Hint = "Receiving Date";
            this.mattxtreceivingdate.Location = new System.Drawing.Point(501, 37);
            this.mattxtreceivingdate.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtreceivingdate.MaxLength = 50;
            this.mattxtreceivingdate.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtreceivingdate.Multiline = false;
            this.mattxtreceivingdate.Name = "mattxtreceivingdate";
            this.mattxtreceivingdate.Size = new System.Drawing.Size(215, 50);
            this.mattxtreceivingdate.TabIndex = 3;
            this.mattxtreceivingdate.Text = "";
            // 
            // mattxtitemcode
            // 
            this.mattxtitemcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtitemcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtitemcode.Depth = 0;
            this.mattxtitemcode.Enabled = false;
            this.mattxtitemcode.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtitemcode.Hint = "Item Code";
            this.mattxtitemcode.Location = new System.Drawing.Point(8, 37);
            this.mattxtitemcode.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtitemcode.MaxLength = 50;
            this.mattxtitemcode.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtitemcode.Multiline = false;
            this.mattxtitemcode.Name = "mattxtitemcode";
            this.mattxtitemcode.Size = new System.Drawing.Size(215, 50);
            this.mattxtitemcode.TabIndex = 1;
            this.mattxtitemcode.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 6);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(181, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Raw Material Information";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnAddRejetModal);
            this.materialCard3.Controls.Add(this.mattxtLotDescription);
            this.materialCard3.Controls.Add(this.btnSelectLot);
            this.materialCard3.Controls.Add(this.mattxtupdatedstocks);
            this.materialCard3.Controls.Add(this.mattxtponumber);
            this.materialCard3.Controls.Add(this.mattxtqtyreject);
            this.materialCard3.Controls.Add(this.mattxtqtyReceived);
            this.materialCard3.Controls.Add(this.mattxtsoh);
            this.materialCard3.Controls.Add(this.mattxtlotno);
            this.materialCard3.Controls.Add(this.mattxtactualdelivery);
            this.materialCard3.Controls.Add(this.mattxtqtyuom);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(22, 419);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialCard3.Size = new System.Drawing.Size(726, 218);
            this.materialCard3.TabIndex = 10;
            this.materialCard3.Visible = false;
            // 
            // btnAddRejetModal
            // 
            this.btnAddRejetModal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddRejetModal.FlatAppearance.BorderSize = 0;
            this.btnAddRejetModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRejetModal.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRejetModal.Image")));
            this.btnAddRejetModal.Location = new System.Drawing.Point(176, 151);
            this.btnAddRejetModal.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddRejetModal.Name = "btnAddRejetModal";
            this.btnAddRejetModal.Size = new System.Drawing.Size(41, 31);
            this.btnAddRejetModal.TabIndex = 27;
            this.btnAddRejetModal.UseVisualStyleBackColor = true;
            this.btnAddRejetModal.Click += new System.EventHandler(this.btnAddRejetModal_Click);
            // 
            // mattxtLotDescription
            // 
            this.mattxtLotDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtLotDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtLotDescription.Depth = 0;
            this.mattxtLotDescription.Enabled = false;
            this.mattxtLotDescription.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtLotDescription.Hint = "Lot Description";
            this.mattxtLotDescription.Location = new System.Drawing.Point(502, 156);
            this.mattxtLotDescription.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtLotDescription.MaxLength = 50;
            this.mattxtLotDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtLotDescription.Multiline = false;
            this.mattxtLotDescription.Name = "mattxtLotDescription";
            this.mattxtLotDescription.Size = new System.Drawing.Size(215, 50);
            this.mattxtLotDescription.TabIndex = 26;
            this.mattxtLotDescription.Text = "";
            // 
            // btnSelectLot
            // 
            this.btnSelectLot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectLot.FlatAppearance.BorderSize = 0;
            this.btnSelectLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLot.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectLot.Image")));
            this.btnSelectLot.Location = new System.Drawing.Point(428, 147);
            this.btnSelectLot.Margin = new System.Windows.Forms.Padding(1);
            this.btnSelectLot.Name = "btnSelectLot";
            this.btnSelectLot.Size = new System.Drawing.Size(41, 31);
            this.btnSelectLot.TabIndex = 25;
            this.btnSelectLot.UseVisualStyleBackColor = true;
            this.btnSelectLot.Click += new System.EventHandler(this.btnSelectLot_Click);
            // 
            // mattxtupdatedstocks
            // 
            this.mattxtupdatedstocks.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtupdatedstocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtupdatedstocks.Depth = 0;
            this.mattxtupdatedstocks.Enabled = false;
            this.mattxtupdatedstocks.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtupdatedstocks.Hint = "Updated Stocks";
            this.mattxtupdatedstocks.Location = new System.Drawing.Point(256, 92);
            this.mattxtupdatedstocks.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtupdatedstocks.MaxLength = 50;
            this.mattxtupdatedstocks.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtupdatedstocks.Multiline = false;
            this.mattxtupdatedstocks.Name = "mattxtupdatedstocks";
            this.mattxtupdatedstocks.Size = new System.Drawing.Size(215, 50);
            this.mattxtupdatedstocks.TabIndex = 23;
            this.mattxtupdatedstocks.Text = "";
            // 
            // mattxtponumber
            // 
            this.mattxtponumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtponumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtponumber.Depth = 0;
            this.mattxtponumber.Enabled = false;
            this.mattxtponumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtponumber.Hint = "PO Number";
            this.mattxtponumber.Location = new System.Drawing.Point(256, 34);
            this.mattxtponumber.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtponumber.MaxLength = 50;
            this.mattxtponumber.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtponumber.Multiline = false;
            this.mattxtponumber.Name = "mattxtponumber";
            this.mattxtponumber.Size = new System.Drawing.Size(215, 50);
            this.mattxtponumber.TabIndex = 22;
            this.mattxtponumber.Text = "";
            // 
            // mattxtqtyreject
            // 
            this.mattxtqtyreject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtqtyreject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtqtyreject.Depth = 0;
            this.mattxtqtyreject.Enabled = false;
            this.mattxtqtyreject.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtqtyreject.Hint = "QTY. Reject";
            this.mattxtqtyreject.Location = new System.Drawing.Point(9, 156);
            this.mattxtqtyreject.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtqtyreject.MaxLength = 50;
            this.mattxtqtyreject.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtqtyreject.Multiline = false;
            this.mattxtqtyreject.Name = "mattxtqtyreject";
            this.mattxtqtyreject.Size = new System.Drawing.Size(163, 50);
            this.mattxtqtyreject.TabIndex = 21;
            this.mattxtqtyreject.Text = "";
            this.mattxtqtyreject.TextChanged += new System.EventHandler(this.mattxtqtyreject_TextChanged);
            // 
            // mattxtqtyReceived
            // 
            this.mattxtqtyReceived.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtqtyReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtqtyReceived.Depth = 0;
            this.mattxtqtyReceived.Enabled = false;
            this.mattxtqtyReceived.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtqtyReceived.ForeColor = System.Drawing.Color.Yellow;
            this.mattxtqtyReceived.Hint = "QTY. Received";
            this.mattxtqtyReceived.Location = new System.Drawing.Point(502, 92);
            this.mattxtqtyReceived.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtqtyReceived.MaxLength = 50;
            this.mattxtqtyReceived.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtqtyReceived.Multiline = false;
            this.mattxtqtyReceived.Name = "mattxtqtyReceived";
            this.mattxtqtyReceived.Size = new System.Drawing.Size(215, 50);
            this.mattxtqtyReceived.TabIndex = 20;
            this.mattxtqtyReceived.Text = "";
            this.mattxtqtyReceived.TextChanged += new System.EventHandler(this.mattxtqtyReceived_TextChanged);
            this.mattxtqtyReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mattxtqtyReceived_KeyPress);
            // 
            // mattxtsoh
            // 
            this.mattxtsoh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtsoh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtsoh.Depth = 0;
            this.mattxtsoh.Enabled = false;
            this.mattxtsoh.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtsoh.Hint = "Stock on Hand";
            this.mattxtsoh.Location = new System.Drawing.Point(9, 92);
            this.mattxtsoh.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtsoh.MaxLength = 50;
            this.mattxtsoh.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtsoh.Multiline = false;
            this.mattxtsoh.Name = "mattxtsoh";
            this.mattxtsoh.Size = new System.Drawing.Size(215, 50);
            this.mattxtsoh.TabIndex = 19;
            this.mattxtsoh.Text = "";
            // 
            // mattxtlotno
            // 
            this.mattxtlotno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtlotno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtlotno.Depth = 0;
            this.mattxtlotno.Enabled = false;
            this.mattxtlotno.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtlotno.Hint = "Lot No.";
            this.mattxtlotno.Location = new System.Drawing.Point(256, 156);
            this.mattxtlotno.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtlotno.MaxLength = 50;
            this.mattxtlotno.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtlotno.Multiline = false;
            this.mattxtlotno.Name = "mattxtlotno";
            this.mattxtlotno.Size = new System.Drawing.Size(168, 50);
            this.mattxtlotno.TabIndex = 18;
            this.mattxtlotno.Text = "";
            // 
            // mattxtactualdelivery
            // 
            this.mattxtactualdelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mattxtactualdelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtactualdelivery.Depth = 0;
            this.mattxtactualdelivery.Enabled = false;
            this.mattxtactualdelivery.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtactualdelivery.Hint = "Actual Delivery";
            this.mattxtactualdelivery.Location = new System.Drawing.Point(502, 34);
            this.mattxtactualdelivery.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtactualdelivery.MaxLength = 50;
            this.mattxtactualdelivery.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtactualdelivery.Multiline = false;
            this.mattxtactualdelivery.Name = "mattxtactualdelivery";
            this.mattxtactualdelivery.Size = new System.Drawing.Size(215, 50);
            this.mattxtactualdelivery.TabIndex = 17;
            this.mattxtactualdelivery.Text = "";
            this.mattxtactualdelivery.TextChanged += new System.EventHandler(this.mattxtactualdelivery_TextChanged);
            // 
            // mattxtqtyuom
            // 
            this.mattxtqtyuom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mattxtqtyuom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mattxtqtyuom.Depth = 0;
            this.mattxtqtyuom.Enabled = false;
            this.mattxtqtyuom.Font = new System.Drawing.Font("Roboto", 12F);
            this.mattxtqtyuom.Hint = "Unit of Measure";
            this.mattxtqtyuom.Location = new System.Drawing.Point(9, 34);
            this.mattxtqtyuom.Margin = new System.Windows.Forms.Padding(1);
            this.mattxtqtyuom.MaxLength = 50;
            this.mattxtqtyuom.MouseState = MaterialSkin.MouseState.OUT;
            this.mattxtqtyuom.Multiline = false;
            this.mattxtqtyuom.Name = "mattxtqtyuom";
            this.mattxtqtyuom.Size = new System.Drawing.Size(215, 50);
            this.mattxtqtyuom.TabIndex = 15;
            this.mattxtqtyuom.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(10, 8);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(267, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Warehouse Dry Receiving Information";
            // 
            // mattxtReceived
            // 
            this.mattxtReceived.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mattxtReceived.Depth = 0;
            this.mattxtReceived.DrawShadows = true;
            this.mattxtReceived.HighEmphasis = true;
            this.mattxtReceived.Icon = null;
            this.mattxtReceived.Location = new System.Drawing.Point(571, 642);
            this.mattxtReceived.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mattxtReceived.MouseState = MaterialSkin.MouseState.HOVER;
            this.mattxtReceived.Name = "mattxtReceived";
            this.mattxtReceived.Size = new System.Drawing.Size(89, 36);
            this.mattxtReceived.TabIndex = 11;
            this.mattxtReceived.Text = "Received";
            this.mattxtReceived.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mattxtReceived.UseAccentColor = false;
            this.mattxtReceived.UseVisualStyleBackColor = true;
            this.mattxtReceived.Visible = false;
            this.mattxtReceived.Click += new System.EventHandler(this.mattxtReceived_Click_1);
            // 
            // matbtnCancel
            // 
            this.matbtnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matbtnCancel.Depth = 0;
            this.matbtnCancel.DrawShadows = true;
            this.matbtnCancel.HighEmphasis = true;
            this.matbtnCancel.Icon = null;
            this.matbtnCancel.Location = new System.Drawing.Point(670, 642);
            this.matbtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.matbtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.matbtnCancel.Name = "matbtnCancel";
            this.matbtnCancel.Size = new System.Drawing.Size(77, 36);
            this.matbtnCancel.TabIndex = 12;
            this.matbtnCancel.Text = "Cancel";
            this.matbtnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.matbtnCancel.UseAccentColor = false;
            this.matbtnCancel.UseVisualStyleBackColor = true;
            this.matbtnCancel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(308, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 595;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crV1
            // 
            this.crV1.ActiveViewIndex = -1;
            this.crV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crV1.Location = new System.Drawing.Point(654, 31);
            this.crV1.Margin = new System.Windows.Forms.Padding(1);
            this.crV1.Name = "crV1";
            this.crV1.Size = new System.Drawing.Size(92, 47);
            this.crV1.TabIndex = 597;
            this.crV1.ToolPanelWidth = 1;
            // 
            // dgvReceivedID
            // 
            this.dgvReceivedID.AllowUserToAddRows = false;
            this.dgvReceivedID.AllowUserToDeleteRows = false;
            this.dgvReceivedID.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvReceivedID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReceivedID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceivedID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvReceivedID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceivedID.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceivedID.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivedID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReceivedID.ColumnHeadersHeight = 35;
            this.dgvReceivedID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceivedID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceivedID.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReceivedID.EnableHeadersVisualStyles = false;
            this.dgvReceivedID.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvReceivedID.Location = new System.Drawing.Point(519, 31);
            this.dgvReceivedID.MultiSelect = false;
            this.dgvReceivedID.Name = "dgvReceivedID";
            this.dgvReceivedID.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceivedID.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReceivedID.RowHeadersVisible = false;
            this.dgvReceivedID.RowHeadersWidth = 102;
            this.dgvReceivedID.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReceivedID.RowTemplate.DividerHeight = 5;
            this.dgvReceivedID.RowTemplate.Height = 40;
            this.dgvReceivedID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceivedID.Size = new System.Drawing.Size(52, 47);
            this.dgvReceivedID.TabIndex = 595;
            this.dgvReceivedID.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvReceivedID.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceivedID.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReceivedID.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReceivedID.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReceivedID.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReceivedID.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvReceivedID.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvReceivedID.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvReceivedID.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReceivedID.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvReceivedID.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvReceivedID.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReceivedID.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvReceivedID.ThemeStyle.ReadOnly = true;
            this.dgvReceivedID.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceivedID.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceivedID.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReceivedID.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvReceivedID.ThemeStyle.RowsStyle.Height = 40;
            this.dgvReceivedID.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.dgvReceivedID.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReceivedID.CurrentCellChanged += new System.EventHandler(this.dgvReceivedID_CurrentCellChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 40.60914F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 12;
            // 
            // frmDryReceivingModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 768);
            this.Controls.Add(this.dgvReceivedID);
            this.Controls.Add(this.crV1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.matbtnCancel);
            this.Controls.Add(this.mattxtReceived);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmDryReceivingModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dry RM  Receiving Module";
            this.Load += new System.EventHandler(this.frmDryReceivingModule_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMajorCategory)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceivedID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox mattxtbarcode;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox mattxtSupplier;
        private MaterialSkin.Controls.MaterialTextBox mattxtitemdesc;
        private MaterialSkin.Controls.MaterialTextBox mattxtreceivingdate;
        private MaterialSkin.Controls.MaterialTextBox mattxtitemcode;
        private MaterialSkin.Controls.MaterialTextBox matdaysExpiry;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox mattxtupdatedstocks;
        private MaterialSkin.Controls.MaterialTextBox mattxtponumber;
        private MaterialSkin.Controls.MaterialTextBox mattxtqtyReceived;
        private MaterialSkin.Controls.MaterialTextBox mattxtsoh;
        private MaterialSkin.Controls.MaterialTextBox mattxtactualdelivery;
        private MaterialSkin.Controls.MaterialTextBox mattxtqtyuom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnSelectLot;
        private MaterialSkin.Controls.MaterialButton mattxtReceived;
        private MaterialSkin.Controls.MaterialButton matbtnCancel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMajorCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn major_category_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc_updated_by;
        public System.Windows.Forms.TextBox textBox1;
        public MaterialSkin.Controls.MaterialTextBox mattxtlotno;
        public MaterialSkin.Controls.MaterialTextBox mattxtLotDescription;
        private System.Windows.Forms.Button btnAddRejetModal;
        public MaterialSkin.Controls.MaterialTextBox mattxtqtyreject;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crV1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReceivedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private MaterialSkin.Controls.MaterialTextBox mattxtcategory;
        private MetroFramework.Controls.MetroDateTime mattxtmfgdate;
        private MetroFramework.Controls.MetroDateTime mattxtexpirydate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}