
namespace Lab03_3
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tdpMaxDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.tdpMinDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.chkXemTatCa = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 680);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDonHang);
            this.panel3.Location = new System.Drawing.Point(6, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 570);
            this.panel3.TabIndex = 1;
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.InvoiceNo,
            this.OrderDate,
            this.DeliveryDate,
            this.SubtotalPrice});
            this.dgvDonHang.Location = new System.Drawing.Point(0, 3);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(967, 564);
            this.dgvDonHang.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Số HD";
            this.InvoiceNo.MinimumWidth = 6;
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Ngày Đặt Hàng";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 175;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.DataPropertyName = "DeliveryDate";
            this.DeliveryDate.HeaderText = "Ngày Giao Hàng";
            this.DeliveryDate.MinimumWidth = 6;
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Width = 175;
            // 
            // SubtotalPrice
            // 
            this.SubtotalPrice.DataPropertyName = "SubtotalPrice";
            this.SubtotalPrice.HeaderText = "Thành Tiền";
            this.SubtotalPrice.MinimumWidth = 6;
            this.SubtotalPrice.Name = "SubtotalPrice";
            this.SubtotalPrice.Width = 175;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tdpMaxDeliveryDate);
            this.panel2.Controls.Add(this.tdpMinDeliveryDate);
            this.panel2.Controls.Add(this.chkXemTatCa);
            this.panel2.Location = new System.Drawing.Point(6, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 76);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "~";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // tdpMaxDeliveryDate
            // 
            this.tdpMaxDeliveryDate.CustomFormat = "dd/MM/yyyy";
            this.tdpMaxDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdpMaxDeliveryDate.Location = new System.Drawing.Point(456, 37);
            this.tdpMaxDeliveryDate.Name = "tdpMaxDeliveryDate";
            this.tdpMaxDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.tdpMaxDeliveryDate.TabIndex = 2;
            this.tdpMaxDeliveryDate.ValueChanged += new System.EventHandler(this.DateTimePickerValueChange);
            // 
            // tdpMinDeliveryDate
            // 
            this.tdpMinDeliveryDate.CustomFormat = "dd/MM/yyyy";
            this.tdpMinDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdpMinDeliveryDate.Location = new System.Drawing.Point(194, 37);
            this.tdpMinDeliveryDate.Name = "tdpMinDeliveryDate";
            this.tdpMinDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.tdpMinDeliveryDate.TabIndex = 1;
            this.tdpMinDeliveryDate.ValueChanged += new System.EventHandler(this.DateTimePickerValueChange);
            // 
            // chkXemTatCa
            // 
            this.chkXemTatCa.AutoSize = true;
            this.chkXemTatCa.Location = new System.Drawing.Point(57, 4);
            this.chkXemTatCa.Name = "chkXemTatCa";
            this.chkXemTatCa.Size = new System.Drawing.Size(174, 21);
            this.chkXemTatCa.TabIndex = 0;
            this.chkXemTatCa.Text = "Xem tất cả trong tháng";
            this.chkXemTatCa.UseVisualStyleBackColor = true;
            this.chkXemTatCa.CheckedChanged += new System.EventHandler(this.chkXemTatCa_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTongCong);
            this.panel1.Location = new System.Drawing.Point(12, 698);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 31);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(781, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng Cộng: ";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Location = new System.Drawing.Point(873, 3);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(100, 22);
            this.txtTongCong.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tdpMaxDeliveryDate;
        private System.Windows.Forms.DateTimePicker tdpMinDeliveryDate;
        private System.Windows.Forms.CheckBox chkXemTatCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}