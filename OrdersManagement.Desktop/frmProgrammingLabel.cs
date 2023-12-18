﻿using OrdersManagement.Desktop.DataSets.BiilingAccountDataSetTableAdapters;
using OrdersManagement.Entity.DTO;
using OrdersManagement.Entity.Models;
using OrdersManagement.Entity.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersManagement.Desktop
{
    public partial class frmProgrammingLabel : Form
    {
        int orderID = 0;
        public frmProgrammingLabel(int? orderId)
        {
            InitializeComponent();
            this.orderID = (int)orderId!;
        }

        private void frmProgrammingLabel_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportEmbeddedResource = "OrdersManagement.Desktop.ReportDefinitions.FacturaReport.rdlc";

            //DataSets.BiilingAccountDataSet.DataSet1DataTable dt = new DataSets.BiilingAccountDataSet.DataSet1DataTable();
            //adapter.Fill(dt, this.orderID);


            //reportViewer1.RefreshReport();

            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

            DataSets.BiilingAccountDataSet dataset = new DataSets.BiilingAccountDataSet();

            dataset.BeginInit();

            reportDataSource1.Name = "DetailTableDataSet";
            reportDataSource1.Value = dataset.DataSet1;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            reportViewer1.LocalReport.ReportEmbeddedResource = "OrdersManagement.Desktop.ReportDefinitions.FacturaReport.rdlc";

            dataset.EndInit();

            DataSet1TableAdapter adapter = new DataSet1TableAdapter();

            adapter.ClearBeforeFill = true;
            DataSets.BiilingAccountDataSet.DataSet1DataTable dt = new DataSets.BiilingAccountDataSet.DataSet1DataTable();
            adapter.Fill(dt, this.orderID);

            reportViewer1.RefreshReport();
        }
    }
}
