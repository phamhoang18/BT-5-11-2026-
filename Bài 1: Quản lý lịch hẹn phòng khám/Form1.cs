using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BT4._9
{
    public class Appointment
    {
        public string Id { get; set; } = "";
        public string PatientName { get; set; } = "";
        public string Phone { get; set; } = "";
        public DateTime AppointmentTime { get; set; }
        public string Doctor { get; set; } = "";
        public string Reason { get; set; } = "";
        public string Status { get; set; } = "Chờ khám";
    }
    public partial class Form1 : Form
    {
        private const char Delimiter = ';';

        private readonly BindingList<Appointment> allAppointments = new BindingList<Appointment>();
        private readonly BindingSource bsAppointments = new BindingSource();

        private bool isFiltering = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void frmClinic_Load(object sender, EventArgs e)
        {
            InitGrid();
            dgvAppointments.DataSource = bsAppointments;
            SeedData();

            cboFilterStatus.SelectedIndex = 0;                   
            ApplyFilter();
            ClearForm();
        }

        private void InitGrid()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã LH", DataPropertyName = "Id", FillWeight = 9 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bệnh nhân", DataPropertyName = "PatientName", FillWeight = 20 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", DataPropertyName = "Phone", FillWeight = 13 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày giờ hẹn",
                DataPropertyName = "AppointmentTime",
                FillWeight = 15,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bác sĩ", DataPropertyName = "Doctor", FillWeight = 17 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Lý do khám", DataPropertyName = "Reason", FillWeight = 26 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", DataPropertyName = "Status", FillWeight = 12 });
        }

        private void SeedData()
        {
            DateTime today = DateTime.Today;
            AddSeed("LH001", "Nguyễn Văn An", "0912345678", today.AddHours(8), "BS. Nguyễn Văn Hùng", "Khám tổng quát", "Hoàn tất");
            AddSeed("LH002", "Trần Thị Bình", "0987654321", today.AddHours(9.5), "BS. Trần Thị Lan", "Đau đầu kéo dài", "Đang khám");
            AddSeed("LH003", "Lê Minh Châu", "0903111222", today.AddHours(15), "BS. Lê Minh Quân", "Tái khám sau phẫu thuật", "Chờ khám");
            AddSeed("LH004", "Phạm Quốc Dũng", "0933444555", today.AddDays(1).AddHours(10), "BS. Nguyễn Văn Hùng", "Đau dạ dày", "Chờ khám");
            AddSeed("LH005", "Hoàng Thu Hà", "0977888999", today.AddDays(2).AddHours(14), "BS. Trần Thị Lan", "Khám da liễu", "Đã hủy");
        }

        private void AddSeed(string id, string name, string phone, DateTime time, string doctor, string reason, string status)
        {
            allAppointments.Add(new Appointment
            {
                Id = id,
                PatientName = name,
                Phone = phone,
                AppointmentTime = time,
                Doctor = doctor,
                Reason = reason,
                Status = status
            });
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            chkFilterDate.Checked = false;
            cboFilterStatus.SelectedIndex = 0;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            dtpFilterDate.Enabled = chkFilterDate.Checked;

            string keyword = Norm(txtSearch.Text.Trim());
            string keywordPhone = keyword.Replace(" ", "");
            string status = cboFilterStatus.SelectedIndex > 0 ? cboFilterStatus.Text : null;
            DateTime? date = chkFilterDate.Checked ? dtpFilterDate.Value.Date : (DateTime?)null;

            Appointment keep = GetSelected();                    

            List<Appointment> result = new List<Appointment>();
            foreach (Appointment a in allAppointments)
            {
                if (keyword != "" && !(Norm(a.PatientName).Contains(keyword) || a.Phone.Contains(keywordPhone)))
                    continue;
                if (status != null && a.Status != status)
                    continue;
                if (date.HasValue && a.AppointmentTime.Date != date.Value)
                    continue;
                result.Add(a);
            }

            isFiltering = true;
            try
            {
                bsAppointments.DataSource = new BindingList<Appointment>(result);

                int index = keep != null ? result.IndexOf(keep) : -1;
                dgvAppointments.ClearSelection();
                if (index >= 0)
                {
                    dgvAppointments.Rows[index].Selected = true;
                    dgvAppointments.CurrentCell = dgvAppointments.Rows[index].Cells[0];
                }
            }
            finally
            {
                isFiltering = false;
            }

            tslCount.Text = "Số lịch hẹn sau khi lọc: " + result.Count + " / " + allAppointments.Count;
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

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (isFiltering) return;
            Appointment a = GetSelected();
            if (a == null) return;

            txtId.Text = a.Id;
            txtPatient.Text = a.PatientName;
            txtPhone.Text = a.Phone;
            dtpTime.Value = a.AppointmentTime;
            cboDoctor.SelectedItem = a.Doctor;
            txtReason.Text = a.Reason;
            cboStatus.SelectedItem = a.Status;
            ClearErrors();
        }

        private Appointment GetSelected()
        {
            if (dgvAppointments.SelectedRows.Count == 0) return null;
            return dgvAppointments.SelectedRows[0].DataBoundItem as Appointment;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null)) return;                   

            Appointment a = new Appointment();
            ReadForm(a);
            allAppointments.Add(a);

            ApplyFilter();
            ClearForm();
            MessageBox.Show("Đã thêm lịch hẹn " + a.Id + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Appointment a = GetSelected();
            if (a == null)
            {
                MessageBox.Show("Hãy chọn một lịch hẹn trong danh sách để cập nhật!", "Chưa chọn dòng",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(a)) return;

            ReadForm(a);
            ApplyFilter();                                      
            MessageBox.Show("Đã cập nhật lịch hẹn " + a.Id + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Appointment a = GetSelected();
            if (a == null)
            {
                MessageBox.Show("Hãy chọn một lịch hẹn cần xóa!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lịch hẹn " + a.Id + " của " + a.PatientName + "?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                allAppointments.Remove(a);
                ApplyFilter();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvAppointments.ClearSelection();
            ClearForm();
        }

        private void ReadForm(Appointment a)
        {
            a.Id = txtId.Text.Trim();
            a.PatientName = txtPatient.Text.Trim();
            a.Phone = NormalizePhone(txtPhone.Text);
            a.AppointmentTime = TruncMinute(dtpTime.Value);
            a.Doctor = cboDoctor.Text;
            a.Reason = txtReason.Text.Trim();
            a.Status = cboStatus.Text;
        }

        private bool ValidateInput(Appointment editing)
        {
            ClearErrors();
            bool ok = true;

            string id = txtId.Text.Trim();
            if (id == "")
            {
                errorProvider.SetError(txtId, "Mã lịch hẹn không được để trống!");
                ok = false;
            }
            else if (allAppointments.Any(x => x != editing && string.Equals(x.Id, id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtId, "Mã lịch hẹn đã tồn tại!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtPatient.Text))
            {
                errorProvider.SetError(txtPatient, "Họ tên bệnh nhân không được để trống!");
                ok = false;
            }

            if (!Regex.IsMatch(NormalizePhone(txtPhone.Text), @"^(0|\+84)\d{9}$"))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại không hợp lệ (VD: 0912345678 hoặc +84912345678)!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProvider.SetError(txtReason, "Lý do khám không được để trống!");
                ok = false;
            }

            DateTime time = TruncMinute(dtpTime.Value);
            bool timeChanged = editing == null || time != editing.AppointmentTime;
            if (timeChanged && time.Date < DateTime.Today)
            {
                errorProvider.SetError(dtpTime, "Ngày hẹn không được nằm trong quá khứ!");
                ok = false;
            }

            return ok;
        }

        private void ClearErrors()
        {
            errorProvider.SetError(txtId, "");
            errorProvider.SetError(txtPatient, "");
            errorProvider.SetError(txtPhone, "");
            errorProvider.SetError(txtReason, "");
            errorProvider.SetError(dtpTime, "");
        }

        private static string NormalizePhone(string phone)
        {
            return Regex.Replace(phone ?? "", @"[\s\.\-\(\)]", "");
        }

        private static DateTime TruncMinute(DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0);
        }

        private void ClearForm()
        {
            ClearErrors();

            int n = 1;
            while (allAppointments.Any(x => x.Id == "LH" + n.ToString("000")))
                n++;
            txtId.Text = "LH" + n.ToString("000");

            txtPatient.Clear();
            txtPhone.Clear();
            dtpTime.Value = DateTime.Now;
            cboDoctor.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtReason.Clear();
            txtPatient.Focus();
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách lịch hẹn";
                sfd.Filter = "Tệp CSV (*.csv)|*.csv";
                sfd.FileName = "LichHen_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                List<string> lines = new List<string>();
                lines.Add(string.Join(Delimiter.ToString(), "Id", "PatientName", "Phone", "AppointmentTime", "Doctor", "Reason", "Status"));

                int count = 0;
                foreach (Appointment a in bsAppointments.List)   
                {
                    lines.Add(string.Join(Delimiter.ToString(),
                        CsvEscape(a.Id),
                        CsvEscape(a.PatientName),
                        CsvEscape(a.Phone),
                        a.AppointmentTime.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                        CsvEscape(a.Doctor),
                        CsvEscape(a.Reason),
                        CsvEscape(a.Status)));
                    count++;
                }

                try
                {
                    File.WriteAllLines(sfd.FileName, lines, new UTF8Encoding(true));
                    MessageBox.Show("Đã xuất " + count + " lịch hẹn ra file:\n" + sfd.FileName,
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
