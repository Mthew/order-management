﻿using System;
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
        public frmProgrammingLabel()
        {
            InitializeComponent();
        }

        private void frmProgrammingLabel_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "OrdersManagement.OrdersManagement.Desktop.ReportDefinitions.LabelReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
