using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT4._11
{
    public class RepairOrder
    {
        public string Id { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string DeviceType { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime ReceiveDate { get; set; }
        public decimal EstimatedCost { get; set; }
        public string Status { get; set; } = "Mới tiếp nhận";
        public string ImagePath { get; set; } = "";
        public bool IsUnfinished
        {
            get { return Status != "Hoàn tất" && Status != "Đã hủy"; }
        }
    }

    public partial class Frmrepair : Form
    {
        private const char Delimiter = ';';
        private readonly BindingList<RepairOrder> allOrders = new BindingList<RepairOrder>();
        private readonly BindingSource bsOrders = new BindingSource();
        private bool isFiltering = false;
        private string currentImagePath = "";
        public Frmrepair()
        {
            InitializeComponent();
        }
        private void frmRepair_Load(object sender, EventArgs e)
        {
            InitGrid();
            dgvOrders.DataSource = bsOrders;
            SeedData();

            cboFilterStatus.SelectedIndex = 0;                 
            ApplyFilter();
            ClearForm();
        }

        private void InitGrid()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã đơn", DataPropertyName = "Id", FillWeight = 9 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Khách hàng", DataPropertyName = "CustomerName", FillWeight = 16 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số điện thoại", DataPropertyName = "Phone", FillWeight = 12 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Loại thiết bị", DataPropertyName = "DeviceType", FillWeight = 12 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mô tả lỗi", DataPropertyName = "Description", FillWeight = 22 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Ngày tiếp nhận",
                DataPropertyName = "ReceiveDate",
                FillWeight = 11,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Chi phí dự kiến",
                DataPropertyName = "EstimatedCost",
                FillWeight = 12,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", DataPropertyName = "Status", FillWeight = 12 });
        }

        private void SeedData()
        {
            DateTime t = DateTime.Today;
            allOrders.Add(new RepairOrder { Id = "SC001", CustomerName = "Nguyễn Văn An", Phone = "0912345678", DeviceType = "Điện thoại", Description = "Vỡ màn hình", ReceiveDate = t.AddDays(-3), EstimatedCost = 1200000, Status = "Đang sửa" });
            allOrders.Add(new RepairOrder { Id = "SC002", CustomerName = "Trần Thị Bình", Phone = "0987654321", DeviceType = "Laptop", Description = "Không lên nguồn", ReceiveDate = t.AddDays(-2), EstimatedCost = 850000, Status = "Chờ linh kiện" });
            allOrders.Add(new RepairOrder { Id = "SC003", CustomerName = "Lê Minh Châu", Phone = "0903111222", DeviceType = "Tivi", Description = "Mất hình, còn tiếng", ReceiveDate = t.AddDays(-7), EstimatedCost = 2000000, Status = "Hoàn tất" });
            allOrders.Add(new RepairOrder { Id = "SC004", CustomerName = "Phạm Quốc Dũng", Phone = "0933444555", DeviceType = "Máy in", Description = "Kẹt giấy liên tục", ReceiveDate = t, EstimatedCost = 300000, Status = "Mới tiếp nhận" });
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterStatus.SelectedIndex = 0;
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword = Norm(txtSearch.Text.Trim());
            string keywordPhone = keyword.Replace(" ", "");
            string status = cboFilterStatus.SelectedIndex > 0 ? cboFilterStatus.Text : null;

            RepairOrder keep = GetSelected();

            List<RepairOrder> result = new List<RepairOrder>();
            foreach (RepairOrder o in allOrders)
            {
                if (keyword != "" && !(Norm(o.Id).Contains(keyword) ||
                                       Norm(o.CustomerName).Contains(keyword) ||
                                       o.Phone.Contains(keywordPhone)))
                    continue;
                if (status != null && o.Status != status)
                    continue;
                result.Add(o);
            }

            isFiltering = true;
            try
            {
                bsOrders.DataSource = new BindingList<RepairOrder>(result);

                int index = keep != null ? result.IndexOf(keep) : -1;
                dgvOrders.ClearSelection();
                if (index >= 0)
                {
                    dgvOrders.Rows[index].Selected = true;
                    dgvOrders.CurrentCell = dgvOrders.Rows[index].Cells[0];
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
            decimal total = allOrders.Where(o => o.IsUnfinished).Sum(o => o.EstimatedCost);
            tslCount.Text = "Số đơn theo bộ lọc: " + shown + " / " + allOrders.Count;
            tslCost.Text = "Tổng chi phí dự kiến (đơn chưa hoàn tất): " + total.ToString("N0") + " đ";
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

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (isFiltering) return;
            RepairOrder o = GetSelected();
            if (o == null) return;

            txtId.Text = o.Id;
            txtCustomer.Text = o.CustomerName;
            txtPhone.Text = o.Phone;
            cboDevice.SelectedItem = o.DeviceType;
            dtpReceive.Value = o.ReceiveDate;
            txtCost.Text = o.EstimatedCost.ToString(CultureInfo.CurrentCulture);
            cboStatus.SelectedItem = o.Status;
            txtDescription.Text = o.Description;
            currentImagePath = o.ImagePath;
            ShowImage(currentImagePath);
            ClearErrors();
        }

        private RepairOrder GetSelected()
        {
            if (dgvOrders.SelectedRows.Count == 0) return null;
            return dgvOrders.SelectedRows[0].DataBoundItem as RepairOrder;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh thiết bị";
                ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = ofd.FileName;             
                    ShowImage(currentImagePath);
                }
            }
        }

        private void ShowImage(string path)
        {
            if (picDevice.Image != null)
            {
                picDevice.Image.Dispose();
                picDevice.Image = null;
            }

            if (string.IsNullOrEmpty(path) || !File.Exists(path)) return;

            try
            {
                using (Image temp = Image.FromFile(path))
                {
                    picDevice.Image = new Bitmap(temp);       
                }
            }
            catch (Exception)
            {}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(null, out decimal cost)) return;

            RepairOrder o = new RepairOrder();
            ReadForm(o, cost);
            allOrders.Add(o);

            ApplyFilter();
            ClearForm();
            MessageBox.Show("Đã thêm đơn " + o.Id + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RepairOrder o = GetSelected();
            if (o == null)
            {
                MessageBox.Show("Hãy chọn một đơn trong danh sách để cập nhật!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateInput(o, out decimal cost)) return;

            ReadForm(o, cost);
            ApplyFilter();                           
            MessageBox.Show("Đã cập nhật đơn " + o.Id + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RepairOrder o = GetSelected();
            if (o == null)
            {
                MessageBox.Show("Hãy chọn một đơn cần xóa!", "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa đơn " + o.Id + " của " + o.CustomerName + "?", "Xác nhận xóa",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                allOrders.Remove(o);
                ApplyFilter();
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvOrders.ClearSelection();
            ClearForm();
        }

        private void ReadForm(RepairOrder o, decimal cost)
        {
            o.Id = txtId.Text.Trim();
            o.CustomerName = txtCustomer.Text.Trim();
            o.Phone = txtPhone.Text.Trim();
            o.DeviceType = cboDevice.Text;
            o.Description = txtDescription.Text.Trim();
            o.ReceiveDate = dtpReceive.Value.Date;
            o.EstimatedCost = cost;
            o.Status = cboStatus.Text;
            o.ImagePath = currentImagePath;
        }

        private bool ValidateInput(RepairOrder editing, out decimal cost)
        {
            ClearErrors();
            bool ok = true;

            string id = txtId.Text.Trim();
            if (id == "")
            {
                errorProvider.SetError(txtId, "Mã đơn không được để trống!");
                ok = false;
            }
            else if (allOrders.Any(x => x != editing && string.Equals(x.Id, id, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider.SetError(txtId, "Mã đơn đã tồn tại!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                errorProvider.SetError(txtCustomer, "Tên khách hàng không được để trống!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại không được để trống!");
                ok = false;
            }

            if (cboDevice.SelectedIndex < 0)
            {
                errorProvider.SetError(cboDevice, "Vui lòng chọn loại thiết bị!");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Mô tả lỗi là bắt buộc!");
                ok = false;
            }

            if (!decimal.TryParse(txtCost.Text.Trim(), out cost) || cost < 0)
            {
                errorProvider.SetError(txtCost, "Chi phí dự kiến phải là số không âm!");
                ok = false;
            }

            return ok;
        }

        private void ClearErrors()
        {
            errorProvider.SetError(txtId, "");
            errorProvider.SetError(txtCustomer, "");
            errorProvider.SetError(txtPhone, "");
            errorProvider.SetError(cboDevice, "");
            errorProvider.SetError(txtDescription, "");
            errorProvider.SetError(txtCost, "");
        }

        private void ClearForm()
        {
            ClearErrors();

            int n = 1;
            while (allOrders.Any(x => x.Id == "SC" + n.ToString("000")))
                n++;
            txtId.Text = "SC" + n.ToString("000");

            txtCustomer.Clear();
            txtPhone.Clear();
            cboDevice.SelectedIndex = -1;
            dtpReceive.Value = DateTime.Today;
            txtCost.Text = "0";
            cboStatus.SelectedIndex = 0;
            txtDescription.Clear();
            currentImagePath = "";
            ShowImage("");
            txtCustomer.Focus();
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách đơn sửa chữa";
                sfd.Filter = "Tệp CSV (*.csv)|*.csv";
                sfd.FileName = "DonSuaChua_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                List<string> lines = new List<string>();
                lines.Add(string.Join(Delimiter.ToString(), "Id", "CustomerName", "Phone", "DeviceType", "Description",
                                      "ReceiveDate", "EstimatedCost", "Status", "ImagePath"));

                int count = 0;
                foreach (RepairOrder o in bsOrders.List)
                {
                    lines.Add(string.Join(Delimiter.ToString(),
                        CsvEscape(o.Id),
                        CsvEscape(o.CustomerName),
                        CsvEscape(o.Phone),
                        CsvEscape(o.DeviceType),
                        CsvEscape(o.Description),
                        o.ReceiveDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        o.EstimatedCost.ToString(CultureInfo.InvariantCulture),
                        CsvEscape(o.Status),
                        CsvEscape(o.ImagePath)));
                    count++;
                }

                try
                {
                    File.WriteAllLines(sfd.FileName, lines, new UTF8Encoding(true));
                    MessageBox.Show("Đã xuất " + count + " đơn ra file:\n" + sfd.FileName,
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
