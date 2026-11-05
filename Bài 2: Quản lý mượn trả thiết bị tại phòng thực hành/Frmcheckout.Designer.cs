namespace BT4._10
{
    partial class Frmcheckout
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
            this.tslTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslOverdue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslShown = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblBorrow = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.lblDue = new System.Windows.Forms.Label();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.chkReturned = new System.Windows.Forms.CheckBox();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkReturned = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuFile });
            this.menuStrip1.Name = "menuStrip1";

            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mnuExport, this.mnuSep1, this.mnuExit });
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "Tệp";

            this.mnuExport.Name = "mnuExport";
            this.mnuExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuExport.Text = "Xuất phiếu đang lọc ra CSV...";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);

            this.mnuSep1.Name = "mnuSep1";

            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tslTotal, this.tslOverdue, this.tslShown });
            this.statusStrip1.Name = "statusStrip1";

            this.tslTotal.Name = "tslTotal";
            this.tslTotal.Text = "Tổng số phiếu: 0";

            this.tslOverdue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslOverdue.ForeColor = System.Drawing.Color.Firebrick;
            this.tslOverdue.Name = "tslOverdue";
            this.tslOverdue.Text = "Quá hạn: 0";

            this.tslShown.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslShown.Name = "tslShown";
            this.tslShown.Text = "Đang hiển thị: 0";

            this.grpInput.Controls.Add(this.lblId);
            this.grpInput.Controls.Add(this.txtId);
            this.grpInput.Controls.Add(this.lblStudentId);
            this.grpInput.Controls.Add(this.txtStudentId);
            this.grpInput.Controls.Add(this.lblStudentName);
            this.grpInput.Controls.Add(this.txtStudentName);
            this.grpInput.Controls.Add(this.lblEquipment);
            this.grpInput.Controls.Add(this.cboEquipment);
            this.grpInput.Controls.Add(this.lblQuantity);
            this.grpInput.Controls.Add(this.numQuantity);
            this.grpInput.Controls.Add(this.lblBorrow);
            this.grpInput.Controls.Add(this.dtpBorrow);
            this.grpInput.Controls.Add(this.lblDue);
            this.grpInput.Controls.Add(this.dtpDue);
            this.grpInput.Controls.Add(this.chkReturned);
            this.grpInput.Controls.Add(this.dtpReturn);
            this.grpInput.Controls.Add(this.lblStatusCaption);
            this.grpInput.Controls.Add(this.lblStatusValue);
            this.grpInput.Controls.Add(this.btnAdd);
            this.grpInput.Controls.Add(this.btnUpdate);
            this.grpInput.Controls.Add(this.btnDelete);
            this.grpInput.Controls.Add(this.btnMarkReturned);
            this.grpInput.Controls.Add(this.btnClear);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(900, 225);
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Phiếu mượn thiết bị";

            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 33);
            this.lblId.Name = "lblId";
            this.lblId.Text = "Mã phiếu:";

            this.txtId.Location = new System.Drawing.Point(130, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(170, 23);
            this.txtId.TabIndex = 0;

            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(20, 68);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Text = "Mã sinh viên:";

            this.txtStudentId.Location = new System.Drawing.Point(130, 65);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(170, 23);
            this.txtStudentId.TabIndex = 1;

            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(20, 103);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Text = "Họ tên sinh viên:";

            this.txtStudentName.Location = new System.Drawing.Point(130, 100);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(170, 23);
            this.txtStudentName.TabIndex = 2;

            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(20, 138);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Text = "Thiết bị:";

            this.cboEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipment.Items.AddRange(new object[] {
                "Oscilloscope", "Máy đo vạn năng", "Bo mạch Arduino", "Máy hàn", "Laptop thực hành", "Máy chiếu" });
            this.cboEquipment.Location = new System.Drawing.Point(130, 135);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(170, 23);
            this.cboEquipment.TabIndex = 3;

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 173);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Text = "Số lượng:";

            this.numQuantity.Location = new System.Drawing.Point(130, 170);
            this.numQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(170, 23);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.lblBorrow.AutoSize = true;
            this.lblBorrow.Location = new System.Drawing.Point(340, 33);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Text = "Ngày mượn:";

            this.dtpBorrow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrow.Location = new System.Drawing.Point(450, 30);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(130, 23);
            this.dtpBorrow.TabIndex = 5;

            this.lblDue.AutoSize = true;
            this.lblDue.Location = new System.Drawing.Point(340, 68);
            this.lblDue.Name = "lblDue";
            this.lblDue.Text = "Hạn trả:";

            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(450, 65);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(130, 23);
            this.dtpDue.TabIndex = 6;

            this.chkReturned.AutoSize = true;
            this.chkReturned.Location = new System.Drawing.Point(340, 103);
            this.chkReturned.Name = "chkReturned";
            this.chkReturned.TabIndex = 7;
            this.chkReturned.Text = "Đã trả, ngày trả:";
            this.chkReturned.UseVisualStyleBackColor = true;
            this.chkReturned.CheckedChanged += new System.EventHandler(this.chkReturned_CheckedChanged);

            this.dtpReturn.Enabled = false;                           
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(450, 135);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(130, 23);
            this.dtpReturn.TabIndex = 8;

            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.Location = new System.Drawing.Point(340, 173);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Text = "Tình trạng:";

            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.Location = new System.Drawing.Point(450, 171);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Text = "--";

            System.Windows.Forms.AnchorStyles topRight = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.btnAdd.Anchor = topRight;
            this.btnAdd.Location = new System.Drawing.Point(700, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm phiếu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Anchor = topRight;
            this.btnUpdate.Location = new System.Drawing.Point(700, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Anchor = topRight;
            this.btnDelete.Location = new System.Drawing.Point(700, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnMarkReturned.Anchor = topRight;
            this.btnMarkReturned.Location = new System.Drawing.Point(700, 136);
            this.btnMarkReturned.Name = "btnMarkReturned";
            this.btnMarkReturned.Size = new System.Drawing.Size(170, 30);
            this.btnMarkReturned.TabIndex = 12;
            this.btnMarkReturned.Text = "Đánh dấu đã trả";
            this.btnMarkReturned.UseVisualStyleBackColor = true;
            this.btnMarkReturned.Click += new System.EventHandler(this.btnMarkReturned_Click);

            this.btnClear.Anchor = topRight;
            this.btnClear.Location = new System.Drawing.Point(700, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 30);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Controls.Add(this.cboFilter);
            this.pnlFilter.Controls.Add(this.btnResetFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(900, 46);

            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(15, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Tìm (mã SV / tên thiết bị):";

            this.txtSearch.Location = new System.Drawing.Point(180, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.Filter_Changed);     

            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(405, 15);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Text = "Lọc tình trạng:";

            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
            this.cboFilter.Location = new System.Drawing.Point(505, 11);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(130, 23);
            this.cboFilter.TabIndex = 15;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);

            this.btnResetFilter.Location = new System.Drawing.Point(650, 9);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(90, 27);
            this.btnResetFilter.TabIndex = 16;
            this.btnResetFilter.Text = "Xóa lọc";
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);

            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.RowHeadersVisible = false;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.TabIndex = 17;
            this.dgvLoans.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLoans_CellFormatting);
            this.dgvLoans.SelectionChanged += new System.EventHandler(this.dgvLoans_SelectionChanged);

            this.errorProvider.ContainerControl = this;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Equipment Checkout - Quản lý mượn trả thiết bị";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel tslTotal;
        private System.Windows.Forms.ToolStripStatusLabel tslOverdue;
        private System.Windows.Forms.ToolStripStatusLabel tslShown;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblBorrow;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.CheckBox chkReturned;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMarkReturned;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
