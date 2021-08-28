using Lab03_3.Models;
using Microsoft.Reporting.WinForms;
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
            dtpViewByDay.Enabled = true;
            dtpViewByMonth.Enabled = false;
            tdpMinDeliveryDate.Enabled = false;
            tdpMaxDeliveryDate.Enabled = false;
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
                max = min;
                tdpMaxDeliveryDate.Value = tdpMinDeliveryDate.Value;
            }
        }

        void ChangeDeliveryDateFormat()
        {
            if (rdoViewFromDate.Checked)
            {
                tdpMinDeliveryDate.Value = tdpMinDeliveryDate.Value.AddDays(-tdpMinDeliveryDate.Value.Day + 1);
                int maxDayInMonth = DateTime.DaysInMonth(tdpMaxDeliveryDate.Value.Year, tdpMaxDeliveryDate.Value.Month);
                tdpMaxDeliveryDate.Value = tdpMaxDeliveryDate.Value.AddDays(-tdpMaxDeliveryDate.Value.Day + maxDayInMonth);
            }

        }

        private void chkXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDeliveryDateFormat();
        }
        private void DateTimePickerValueChange(object sender, EventArgs e)
        {
            ValidateDateTimePicker();
            ChangeDeliveryDateFormat();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void rdoViewByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpViewByDay.Enabled = true;
            dtpViewByMonth.Enabled = false;
            tdpMinDeliveryDate.Enabled = false;
            tdpMaxDeliveryDate.Enabled = false;

        }

        private void rdoViewByMonth_CheckedChanged(object sender, EventArgs e)
        {
            dtpViewByDay.Enabled = false;
            dtpViewByMonth.Enabled = true;
            tdpMinDeliveryDate.Enabled = false;
            tdpMaxDeliveryDate.Enabled = false;
        }

        private void rdoViewFromDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpViewByDay.Enabled = false;
            dtpViewByMonth.Enabled = false;
            tdpMinDeliveryDate.Enabled = true;
            tdpMaxDeliveryDate.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Visible = true;
            if (rdoViewByDay.Checked)
            {
                DateTime date = dtpViewByDay.Value;
                var ls = from s in db.Invoices.ToList()
                         where s.DeliveryDate.Date == date.Date
                         select new
                         {
                             InvoiceNo = s.InvoiceNo,
                             DeliveryDate = s.DeliveryDate.ToString("dd/MM/yyyy"),
                             Subtotal = s.Orders.Sum(a => a.Quantity * a.Price)
                         };
                //dgvDonHang.DataSource = ls.ToList();

                
                ReportParameter[] param = new ReportParameter[] {
                new ReportParameter("txtDatetime","Ngày " + date.ToString("dd") + " tháng " + date.ToString("MM") + " năm " + date.ToString("yyyy"))
            };
                this.reportViewer1.LocalReport.DataSources.Clear();

                this.reportViewer1.LocalReport.ReportPath = "InvoicesReport.rdlc";

                this.reportViewer1.LocalReport.SetParameters(param);
                var reportResource = new ReportDataSource("DataSetInvoice", ls);
                this.reportViewer1.LocalReport.DataSources.Add(reportResource);
                this.reportViewer1.Refresh();
                if(ls.Count() == 0)
                {
                    MessageBox.Show("Không có hoá đơn nào được tìm thấy");
                }
            }
            else if(rdoViewByMonth.Checked)
            {
                DateTime date = dtpViewByMonth.Value;
                var ls = from s in db.Invoices.ToList()
                         where s.DeliveryDate.Date.Month == date.Month
                         select new
                         {
                             InvoiceNo = s.InvoiceNo,
                             DeliveryDate = s.DeliveryDate.ToString("dd/MM/yyyy"),
                             Subtotal = s.Orders.Sum(a => a.Quantity * a.Price)
                         };
                //dgvDonHang.DataSource = ls.ToList();


                ReportParameter[] param = new ReportParameter[] {
                new ReportParameter("txtDatetime", "Tháng " + date.ToString("MM") + " năm " + date.ToString("yyyy"))
            };
                this.reportViewer1.LocalReport.DataSources.Clear();

                this.reportViewer1.LocalReport.ReportPath = "InvoicesReport.rdlc";

                this.reportViewer1.LocalReport.SetParameters(param);
                var reportResource = new ReportDataSource("DataSetInvoice", ls);
                this.reportViewer1.LocalReport.DataSources.Add(reportResource);
                this.reportViewer1.Refresh();
                if (ls.Count() == 0)
                {
                    MessageBox.Show("Không có hoá đơn nào được tìm thấy");
                }
            }
            else
            {
                var ls = from s in db.Invoices.ToList()
                         where FilterByDeliveryTime(s.DeliveryDate.Date)
                         select new
                         {
                             InvoiceNo = s.InvoiceNo,
                             DeliveryDate = s.DeliveryDate.ToString("dd/MM/yyyy"),
                             Subtotal = s.Orders.Sum(a => a.Quantity * a.Price)
                         };
                //dgvDonHang.DataSource = ls.ToList();

                DateTime max = tdpMaxDeliveryDate.Value.Date;
                DateTime min = tdpMinDeliveryDate.Value.Date;
                ReportParameter[] param = new ReportParameter[] {
                new ReportParameter("txtDatetime", "Từ " + min.ToString("dd/MM/yyyy") + " đến " + max.ToString("dd/MM/yyyy"))
            };
                this.reportViewer1.LocalReport.DataSources.Clear();

                this.reportViewer1.LocalReport.ReportPath = "InvoicesReport.rdlc";

                this.reportViewer1.LocalReport.SetParameters(param);
                var reportResource = new ReportDataSource("DataSetInvoice", ls);
                this.reportViewer1.LocalReport.DataSources.Add(reportResource);
                this.reportViewer1.Refresh();
                if (ls.Count() == 0)
                {
                    MessageBox.Show("Không có hoá đơn nào được tìm thấy");
                }
            }// khong lam van có an

            reportViewer1.RefreshReport();
        }
    }
}
