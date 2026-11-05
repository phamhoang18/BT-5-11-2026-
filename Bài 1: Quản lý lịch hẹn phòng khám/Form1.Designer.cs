namespace BT4._9
{
    partial class Form1
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cboDoctor = new System.Windows.Forms.ComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkFilterDate = new System.Windows.Forms.CheckBox();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.tlpInput.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.flpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            System.Windows.Forms.AnchorStyles leftRight = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            System.Windows.Forms.Padding inputMargin = new System.Windows.Forms.Padding(3, 4, 28, 4);

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

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tslCount });
            this.statusStrip1.Name = "statusStrip1";

            this.tslCount.Name = "tslCount";
            this.tslCount.Text = "Số lịch hẹn sau khi lọc: 0";

            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpInput, 0, 0);
            this.tlpMain.Controls.Add(this.flpFilter, 0, 1);
            this.tlpMain.Controls.Add(this.dgvAppointments, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(8);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));   
            this.tlpMain.TabIndex = 0;

            this.grpInput.AutoSize = true;
            this.grpInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpInput.Controls.Add(this.tlpInput);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(6);
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin lịch hẹn";

            this.tlpInput.AutoSize = true;
            this.tlpInput.ColumnCount = 4;
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.Controls.Add(this.lblId, 0, 0);
            this.tlpInput.Controls.Add(this.txtId, 1, 0);
            this.tlpInput.Controls.Add(this.lblTime, 2, 0);
            this.tlpInput.Controls.Add(this.dtpTime, 3, 0);
            this.tlpInput.Controls.Add(this.lblPatient, 0, 1);
            this.tlpInput.Controls.Add(this.txtPatient, 1, 1);
            this.tlpInput.Controls.Add(this.lblDoctor, 2, 1);
            this.tlpInput.Controls.Add(this.cboDoctor, 3, 1);
            this.tlpInput.Controls.Add(this.lblPhone, 0, 2);
            this.tlpInput.Controls.Add(this.txtPhone, 1, 2);
            this.tlpInput.Controls.Add(this.lblStatus, 2, 2);
            this.tlpInput.Controls.Add(this.cboStatus, 3, 2);
            this.tlpInput.Controls.Add(this.lblReason, 0, 3);
            this.tlpInput.Controls.Add(this.txtReason, 1, 3);
            this.tlpInput.Controls.Add(this.flpButtons, 0, 4);
            this.tlpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInput.Name = "tlpInput";
            this.tlpInput.RowCount = 5;
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tlpInput.SetColumnSpan(this.txtReason, 3);
            this.tlpInput.SetColumnSpan(this.flpButtons, 4);

            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId.AutoSize = true;
            this.lblId.Name = "lblId";
            this.lblId.Text = "Mã lịch hẹn:";

            this.txtId.Anchor = leftRight;
            this.txtId.Margin = inputMargin;
            this.txtId.Name = "txtId";
            this.txtId.TabIndex = 0;

            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTime.AutoSize = true;
            this.lblTime.Name = "lblTime";
            this.lblTime.Text = "Ngày giờ hẹn:";

            this.dtpTime.Anchor = leftRight;
            this.dtpTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Margin = inputMargin;
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.TabIndex = 1;

            this.lblPatient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPatient.AutoSize = true;
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Text = "Họ tên bệnh nhân:";

            this.txtPatient.Anchor = leftRight;
            this.txtPatient.Margin = inputMargin;
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.TabIndex = 2;

            this.lblDoctor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Text = "Bác sĩ:";

            this.cboDoctor.Anchor = leftRight;
            this.cboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctor.Items.AddRange(new object[] { "BS. Nguyễn Văn Hùng", "BS. Trần Thị Lan", "BS. Lê Minh Quân" });
            this.cboDoctor.Margin = inputMargin;
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.TabIndex = 3;

            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Số điện thoại:";

            this.txtPhone.Anchor = leftRight;
            this.txtPhone.Margin = inputMargin;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.TabIndex = 4;

            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Trạng thái:";

            this.cboStatus.Anchor = leftRight;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            this.cboStatus.Margin = inputMargin;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.TabIndex = 5;

            this.lblReason.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReason.AutoSize = true;
            this.lblReason.Name = "lblReason";
            this.lblReason.Text = "Lý do khám:";

            this.txtReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReason.Margin = inputMargin;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.TabIndex = 6;

            this.flpButtons.AutoSize = true;
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.btnUpdate);
            this.flpButtons.Controls.Add(this.btnDelete);
            this.flpButtons.Controls.Add(this.btnClear);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Name = "flpButtons";

            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 32);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.flpFilter.AutoSize = true;
            this.flpFilter.Controls.Add(this.lblSearch);
            this.flpFilter.Controls.Add(this.txtSearch);
            this.flpFilter.Controls.Add(this.chkFilterDate);
            this.flpFilter.Controls.Add(this.dtpFilterDate);
            this.flpFilter.Controls.Add(this.lblFilterStatus);
            this.flpFilter.Controls.Add(this.cboFilterStatus);
            this.flpFilter.Controls.Add(this.btnResetFilter);
            this.flpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tìm (tên / SĐT):";

            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.Filter_Changed);     

            this.chkFilterDate.AutoSize = true;
            this.chkFilterDate.Margin = new System.Windows.Forms.Padding(16, 7, 3, 0);
            this.chkFilterDate.Name = "chkFilterDate";
            this.chkFilterDate.TabIndex = 12;
            this.chkFilterDate.Text = "Lọc theo ngày:";
            this.chkFilterDate.UseVisualStyleBackColor = true;
            this.chkFilterDate.CheckedChanged += new System.EventHandler(this.Filter_Changed);

            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(110, 23);
            this.dtpFilterDate.TabIndex = 13;
            this.dtpFilterDate.ValueChanged += new System.EventHandler(this.Filter_Changed);

            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Margin = new System.Windows.Forms.Padding(16, 7, 3, 0);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Text = "Trạng thái:";

            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.Size = new System.Drawing.Size(120, 23);
            this.cboFilterStatus.TabIndex = 14;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.btnResetFilter.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(90, 27);
            this.btnResetFilter.TabIndex = 15;
            this.btnResetFilter.Text = "Xóa lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.TabIndex = 16;
            this.dgvAppointments.SelectionChanged += new System.EventHandler(this.dgvAppointments_SelectionChanged);

            this.errorProvider.ContainerControl = this;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.tlpMain);                             
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(760, 560);
            this.Name = "frmClinic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Appointment Manager - Quản lý lịch hẹn phòng khám";
            this.Load += new System.EventHandler(this.frmClinic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.tlpInput.ResumeLayout(false);
            this.tlpInput.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.flpFilter.ResumeLayout(false);
            this.flpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cboDoctor;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
