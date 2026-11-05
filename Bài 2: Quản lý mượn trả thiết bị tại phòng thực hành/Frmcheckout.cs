using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT4._10
{
    public class Loan
    {
        public string Id { get; set; } = "";
        public string StudentId { get; set; } = "";
        public string StudentName { get; set; } = "";
        public string Equipment { get; set; } = "";
        public int Quantity { get; set; } = 1;
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status
        {
            get
            {
                if (ReturnDate.HasValue) return "Đã trả";
                return DueDate.Date < DateTime.Today ? "Quá hạn" : "Đang mượn";
            }
        }
    }

    public partial class Frmcheckout : Form
    {
        private const char Delimiter = ';';

        private readonly BindingList<Loan> allLoans = new BindingList<Loan>();

        private readonly BindingSource bsLoans = new BindingSource();

        private bool isFiltering = false;

        public Frmcheckout()
        {
            InitializeComponent();
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            InitGrid();
            dgvLoans.DataSource = bsLoans;
            SeedData();

            cboFilter.SelectedIndex = 0;                         
            ApplyFilter();
            ClearForm();
        }

        private void InitGrid()
        {
            dgvLoans.AutoGenerateColumns = false;
            dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã phiếu", DataPropertyName = "Id", FillWeight = 10 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã SV", DataPropertyName = "StudentId", FillWeight = 10 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ tên sinh viên", DataPropertyName = "StudentName", FillWeight = 17 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thiết bị", DataPropertyName = "Equipment", FillWeight = 17 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "SL",
                DataPropertyName = "Quantity",
                FillWeight = 6,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày mượn",
                DataPropertyName = "BorrowDate",
                FillWeight = 11,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Hạn trả",
                DataPropertyName = "DueDate",
                FillWeight = 11,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày trả TT",
                DataPropertyName = "ReturnDate",
                FillWeight = 11,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy", NullValue = "" }   
            });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tình trạng", DataPropertyName = "Status", FillWeight = 11 });
        }

        private void dgvLoans_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Loan l = dgvLoans.Rows[e.RowIndex].DataBoundItem as Loan;
            if (l != null && l.Status == "Quá hạn")
                e.CellStyle.ForeColor = Color.Firebrick;
        }

        private void SeedData()
        {
            DateTime t = DateTime.Today;
            allLoans.Add(new Loan { Id = "PM001", StudentId = "SV001", StudentName = "Nguyễn Văn An", Equipment = "Oscilloscope", Quantity = 1, BorrowDate = t.AddDays(-10), DueDate = t.AddDays(-3) });
            allLoans.Add(new Loan { Id = "PM002", StudentId = "SV002", StudentName = "Trần Thị Bình", Equipment = "Máy hàn", Quantity = 2, BorrowDate = t.AddDays(-2), DueDate = t.AddDays(5) });
            allLoans.Add(new Loan { Id = "PM003", StudentId = "SV003", StudentName = "Lê Minh Châu", Equipment = "Laptop thực hành", Quantity = 1, BorrowDate = t.AddDays(-12), DueDate = t.AddDays(-5), ReturnDate = t.AddDays(-6) });
            allLoans.Add(new Loan { Id = "PM004", StudentId = "SV004", StudentName = "Phạm Quốc Dũng", Equipment = "Bo mạch Arduino", Quantity = 3, BorrowDate = t.AddDays(-1), DueDate = t.AddDays(13) });
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilter.SelectedIndex = 0;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword = Norm(txtSearch.Text.Trim());
            string status = cboFilter.SelectedIndex > 0 ? cboFilter.Text : null;

            Loan keep = GetSelected();

            List<Loan> result = new List<Loan>();
            foreach (Loan l in allLoans)
            {
                if (keyword != "" && !(Norm(l.StudentId).Contains(keyword) || Norm(l.Equipment).Contains(keyword)))
                    continue;
                if (status != null && l.Status != status)
                    continue;
                result.Add(l);
            }

            isFiltering = true;
            try
            {
                bsLoans.DataSource = new BindingList<Loan>(result);

                int index = keep != null ? result.IndexOf(keep) : -1;
                dgvLoans.ClearSelection();
                if (index >= 0)
                {
                    dgvLoans.Rows[index].Selected = true;
                    dgvLoans.CurrentCell = dgvLoans.Rows[index].Cells[0];
                }
            }
            finally
            {
                isFiltering = false;
            }

            UpdateStatusBar(result.Count);
        }

        private void UpdateStatusBar(int shown)
        {
            int overdue = allLoans.Count(l => l.Status == "Quá hạn");
            tslTotal.Text = "Tổng số phiếu: " + allLoans.Count;
            tslOverdue.Text = "Quá hạn: " + overdue;
            tslShown.Text = "Đang hiển thị: " + shown;
        }

        private static string Norm(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            string decomposed = text.ToLowerInvariant().Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            foreach (char c in decomposed)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            return sb.ToString().Replace('đ', 'd');
        }

        private void dgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (isFiltering) return;
            Loan l = GetSelected();
            if (l != null) FillForm(l);
        }

        private Loan GetSelected()
        {
            if (dgvLoans.SelectedRows.Count == 0) return null;
            return dgvLoans.SelectedRows[0].DataBoundItem as Loan;
        }

        private void FillForm(Loan l)
        {
            txtId.Text = l.Id;
            txtStudentId.Text = l.StudentId;
            txtStudentName.Text = l.StudentName;
            cboEquipment.SelectedItem = l.Equipment;
            numQuantity.Value = Math.Max(numQuantity.Minimum, Math.Min(numQuantity.Maximum, l.Quantity));
            dtpBorrow.Value = l.BorrowDate;
            dtpDue.Value = l.DueDate;
            chkReturned.Checked = l.ReturnDate.HasValue;
            dtpReturn.Value = l.ReturnDate ?? DateTime.Today;
            ShowStatus(l.Status);
            ClearErrors();
        }

        private void ShowStatus(string status)
        {
            lblStatusValue.Text = status;
            lblStatusValue.ForeColor = status == "Quá hạn" ? Color.Firebrick
                                     : status == "Đã trả" ? Color.Green
                                     : Color.Black;
        }

        private void chkReturned_CheckedChanged(object sender, EventArgs e)
        {
            dtpReturn.Enabled = chkReturned.Checked;             
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null)) return;

            Loan l = new Loan();
            ReadForm(l);
            allLoans.Add(l);

            ApplyFilter();
            ClearForm();
            MessageBox.Show("Đã thêm phiếu " + l.Id + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Loan l = GetSelected();
            if (l == null)
            {
                MessageBox.Show("Hãy chọn một phiếu trong danh sách để cập nhật!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(l)) return;

            ReadForm(l);
            ApplyFilter();                                       
            ShowStatus(l.Status);
            MessageBox.Show("Đã cập nhật phiếu " + l.Id + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Loan l = GetSelected();
            if (l == null)
            {
                MessageBox.Show("Hãy chọn một phiếu cần xóa!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu " + l.Id + "?", "Xác nhận xóa",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                allLoans.Remove(l);
                ApplyFilter();
                ClearForm();
            }
        }

        private void btnMarkReturned_Click(object sender, EventArgs e)
        {
            Loan l = GetSelected();
            if (l == null)
            {
                MessageBox.Show("Hãy chọn phiếu cần đánh dấu đã trả!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (l.ReturnDate.HasValue)
            {
                MessageBox.Show("Phiếu " + l.Id + " đã được trả ngày " + l.ReturnDate.Value.ToString("dd/MM/yyyy") + ".",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DateTime.Today < l.BorrowDate.Date)
            {
                MessageBox.Show("Ngày trả thực tế không được trước ngày mượn!", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            l.ReturnDate = DateTime.Today;
            ApplyFilter();                                       
            FillForm(l);
            MessageBox.Show("Đã ghi nhận phiếu " + l.Id + " được trả ngày " + DateTime.Today.ToString("dd/MM/yyyy") + ".",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvLoans.ClearSelection();
            ClearForm();
        }

        private void ReadForm(Loan l)
        {
            l.Id = txtId.Text.Trim();
            l.StudentId = txtStudentId.Text.Trim();
            l.StudentName = txtStudentName.Text.Trim();
            l.Equipment = cboEquipment.Text;
            l.Quantity = (int)numQuantity.Value;
            l.BorrowDate = dtpBorrow.Value.Date;
            l.DueDate = dtpDue.Value.Date;
            l.ReturnDate = chkReturned.Checked ? dtpReturn.Value.Date : (DateTime?)null;
        }

        private bool ValidateInput(Loan editing)
        {
            ClearErrors();
            bool ok = true;

            string id = txtId.Text.Trim();
            if (id == "")
            {
                errorProvider.SetError(txtId, "Mã phiếu không được để trống!");
                ok = false;
            }
            else if (allLoans.Any(x => x != editing && string.Equals(x.Id, id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtId, "Mã phiếu đã tồn tại!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProvider.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                ok = false;
            }

            if (cboEquipment.SelectedIndex < 0)
            {
                errorProvider.SetError(cboEquipment, "Vui lòng chọn thiết bị!");
                ok = false;
            }

            if (numQuantity.Value <= 0)
            {
                errorProvider.SetError(numQuantity, "Số lượng phải lớn hơn 0!");
                ok = false;
            }

            if (dtpDue.Value.Date < dtpBorrow.Value.Date)
            {
                errorProvider.SetError(dtpDue, "Hạn trả không được trước ngày mượn!");
                ok = false;
            }

            if (chkReturned.Checked && dtpReturn.Value.Date < dtpBorrow.Value.Date)
            {
                errorProvider.SetError(dtpReturn, "Ngày trả thực tế không được trước ngày mượn!");
                ok = false;
            }

            return ok;
        }

        private void ClearErrors()
        {
            errorProvider.SetError(txtId, "");
            errorProvider.SetError(txtStudentId, "");
            errorProvider.SetError(cboEquipment, "");
            errorProvider.SetError(numQuantity, "");
            errorProvider.SetError(dtpDue, "");
            errorProvider.SetError(dtpReturn, "");
        }

        private void ClearForm()
        {
            ClearErrors();

            int n = 1;
            while (allLoans.Any(x => x.Id == "PM" + n.ToString("000")))
                n++;
            txtId.Text = "PM" + n.ToString("000");

            txtStudentId.Clear();
            txtStudentName.Clear();
            cboEquipment.SelectedIndex = -1;
            numQuantity.Value = 1;
            dtpBorrow.Value = DateTime.Today;
            dtpDue.Value = DateTime.Today.AddDays(7);
            chkReturned.Checked = false;
            dtpReturn.Value = DateTime.Today;
            ShowStatus("--");
            txtStudentId.Focus();
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách phiếu mượn";
                sfd.Filter = "Tệp CSV (*.csv)|*.csv";
                sfd.FileName = "PhieuMuon_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                List<string> lines = new List<string>();
                lines.Add(string.Join(Delimiter.ToString(), "Id", "StudentId", "StudentName", "Equipment", "Quantity",
                                      "BorrowDate", "DueDate", "ReturnDate", "Status"));

                int count = 0;
                foreach (Loan l in bsLoans.List)
                {
                    lines.Add(string.Join(Delimiter.ToString(),
                        CsvEscape(l.Id),
                        CsvEscape(l.StudentId),
                        CsvEscape(l.StudentName),
                        CsvEscape(l.Equipment),
                        l.Quantity.ToString(),
                        l.BorrowDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        l.DueDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        l.ReturnDate.HasValue ? l.ReturnDate.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : "",
                        CsvEscape(l.Status)));
                    count++;
                }

                try
                {
                    File.WriteAllLines(sfd.FileName, lines, new UTF8Encoding(true));
                    MessageBox.Show("Đã xuất " + count + " phiếu ra file:\n" + sfd.FileName,
                                    "Xuất CSV thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string CsvEscape(string value)
        {
            if (value == null) return "";
            if (value.IndexOfAny(new char[] { Delimiter, '"', '\n', '\r' }) >= 0)
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
