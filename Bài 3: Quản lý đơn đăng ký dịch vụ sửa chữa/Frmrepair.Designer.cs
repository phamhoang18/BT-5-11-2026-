namespace BT4._11
{
    partial class Frmrepair
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCost = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picDevice = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuFile });
            this.menuStrip1.Name = "menuStrip1";

            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuExport, this.mnuSep1, this.mnuExit });
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "Tệp";

            this.mnuExport.Name = "mnuExport";
            this.mnuExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuExport.Text = "Xuất danh sách đang hiển thị ra CSV...";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);

            this.mnuSep1.Name = "mnuSep1";

            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tslCount, this.tslCost });
            this.statusStrip1.Name = "statusStrip1";

            this.tslCount.Name = "tslCount";
            this.tslCount.Text = "Số đơn theo bộ lọc: 0";

            this.tslCost.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslCost.Name = "tslCost";
            this.tslCost.Text = "Tổng chi phí dự kiến (đơn chưa hoàn tất): 0 đ";

            this.grpInput.Controls.Add(this.lblId);
            this.grpInput.Controls.Add(this.txtId);
            this.grpInput.Controls.Add(this.lblCustomer);
            this.grpInput.Controls.Add(this.txtCustomer);
            this.grpInput.Controls.Add(this.lblPhone);
            this.grpInput.Controls.Add(this.txtPhone);
            this.grpInput.Controls.Add(this.lblDevice);
            this.grpInput.Controls.Add(this.cboDevice);
            this.grpInput.Controls.Add(this.lblDate);
            this.grpInput.Controls.Add(this.dtpReceive);
            this.grpInput.Controls.Add(this.lblCost);
            this.grpInput.Controls.Add(this.txtCost);
            this.grpInput.Controls.Add(this.lblStatus);
            this.grpInput.Controls.Add(this.cboStatus);
            this.grpInput.Controls.Add(this.lblDesc);
            this.grpInput.Controls.Add(this.txtDescription);
            this.grpInput.Controls.Add(this.picDevice);
            this.grpInput.Controls.Add(this.btnChooseImage);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnClear);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(900, 265);
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin đơn sửa chữa";

            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 33);
            this.lblId.Name = "lblId";
            this.lblId.Text = "Mã đơn:";

            this.txtId.Location = new System.Drawing.Point(130, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(170, 23);
            this.txtId.TabIndex = 0;

            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(20, 68);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Text = "Tên khách hàng:";

            this.txtCustomer.Location = new System.Drawing.Point(130, 65);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(170, 23);
            this.txtCustomer.TabIndex = 1;

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 103);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Số điện thoại:";

            this.txtPhone.Location = new System.Drawing.Point(130, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(170, 23);
            this.txtPhone.TabIndex = 2;

            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(20, 138);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Text = "Loại thiết bị:";

            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Máy tính bảng", "Tivi", "Máy in", "Khác" });
            this.cboDevice.Location = new System.Drawing.Point(130, 135);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(170, 23);
            this.cboDevice.TabIndex = 3;

            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 173);
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Ngày tiếp nhận:";

            this.dtpReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceive.Location = new System.Drawing.Point(130, 170);
            this.dtpReceive.Name = "dtpReceive";
            this.dtpReceive.Size = new System.Drawing.Size(170, 23);
            this.dtpReceive.TabIndex = 4;

            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(330, 33);
            this.lblCost.Name = "lblCost";
            this.lblCost.Text = "Chi phí dự kiến:";

            this.txtCost.Location = new System.Drawing.Point(440, 30);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(160, 23);
            this.txtCost.TabIndex = 5;

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(330, 68);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Trạng thái:";

            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            this.cboStatus.Location = new System.Drawing.Point(440, 65);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(160, 23);
            this.cboStatus.TabIndex = 6;

            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(330, 103);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Text = "Mô tả lỗi:";

            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(330, 125);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(270, 70);
            this.txtDescription.TabIndex = 7;

            this.picDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDevice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDevice.Location = new System.Drawing.Point(660, 25);
            this.picDevice.Name = "picDevice";
            this.picDevice.Size = new System.Drawing.Size(200, 150);
            this.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;       
            this.picDevice.TabStop = false;

            this.btnChooseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseImage.Location = new System.Drawing.Point(660, 180);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(200, 28);
            this.btnChooseImage.TabIndex = 8;
            this.btnChooseImage.Text = "Chọn ảnh thiết bị";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);

            this.btnAdd.Location = new System.Drawing.Point(20, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(150, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 32);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(280, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 32);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Location = new System.Drawing.Point(410, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblFilterStatus);
            this.pnlFilter.Controls.Add(this.cboFilterStatus);
            this.pnlFilter.Controls.Add(this.btnResetFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(900, 46);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tìm (mã đơn / tên / SĐT):";

            this.txtSearch.Location = new System.Drawing.Point(175, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.Filter_Changed);     

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(400, 15);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Text = "Lọc trạng thái:";

            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            this.cboFilterStatus.Location = new System.Drawing.Point(500, 11);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(140, 23);
            this.cboFilterStatus.TabIndex = 14;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.btnResetFilter.Location = new System.Drawing.Point(655, 9);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(90, 27);
            this.btnResetFilter.TabIndex = 15;
            this.btnResetFilter.Text = "Xóa lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.TabIndex = 16;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);

            this.errorProvider.ContainerControl = this;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 660);
            this.Controls.Add(this.dgvOrders);                          
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);                         
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "frmRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Service Tracker - Quản lý đơn sửa chữa";
            this.Load += new System.EventHandler(this.frmRepair_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripSeparator mnuSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslCount;
        private System.Windows.Forms.ToolStripStatusLabel tslCost;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picDevice;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
