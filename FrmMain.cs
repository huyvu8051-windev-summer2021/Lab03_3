using Lab03_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_3
{
    public partial class FrmMain : Form
    {
        private DBModel db;
        public FrmMain()
        {
            db = new DBModel();
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            int i = 0;
            var ls = from s in db.Orders.ToList()
                     where FilterByDeliveryTime(s.Invoice.DeliveryDate.Date)
                     select new { STT = i++, s.InvoiceNo, OrderDate = s.Invoice.OrderDate.ToString("dd/MM/yyyy"), DeliveryDate = s.Invoice.DeliveryDate.ToString("dd/MM/yyyy"), SubtotalPrice = s.Quantity * s.Price};
            dgvDonHang.DataSource = ls.ToList();
            var tong = ls.Sum(s => s.SubtotalPrice);
            txtTongCong.Text = tong.ToString();
        }

        private bool FilterByDeliveryTime(DateTime dt)
        {
            DateTime min = tdpMinDeliveryDate.Value.Date;
            DateTime max = tdpMaxDeliveryDate.Value.Date;
            return dt >= min && dt <= max;
        }

        

        void ValidateDateTimePicker()
        {
            DateTime max = tdpMaxDeliveryDate.Value.Date;
            DateTime min = tdpMinDeliveryDate.Value.Date;
            errorProvider1.Clear();
            if (max < min)
            {
                errorProvider1.SetError(tdpMaxDeliveryDate, "Nhập thời gian lớn hơn field bên trái!");
            }
        }

        void ChangeDeliveryDateFormat()
        {
            if (chkXemTatCa.Checked)
            {
                tdpMinDeliveryDate.Value = tdpMinDeliveryDate.Value.AddDays(-tdpMinDeliveryDate.Value.Day + 1);
                int maxDayInMonth = DateTime.DaysInMonth(tdpMaxDeliveryDate.Value.Year, tdpMaxDeliveryDate.Value.Month);
                tdpMaxDeliveryDate.Value = tdpMaxDeliveryDate.Value.AddDays(-tdpMaxDeliveryDate.Value.Day + maxDayInMonth);
            }

        }

        private void chkXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDeliveryDateFormat();
            LoadData();
        }
        private void DateTimePickerValueChange(object sender, EventArgs e)
        {
            ValidateDateTimePicker();
            ChangeDeliveryDateFormat();
            LoadData();
        }
    }
}
