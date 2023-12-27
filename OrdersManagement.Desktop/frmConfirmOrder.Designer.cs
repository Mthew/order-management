namespace OrdersManagement.Desktop
{
    partial class frmConfirmOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            BarCode = new DataGridViewTextBoxColumn();
            OfNumber = new DataGridViewTextBoxColumn();
            SKU = new DataGridViewTextBoxColumn();
            RealQuantity = new DataGridViewTextBoxColumn();
            PrintedQuantity = new DataGridViewTextBoxColumn();
            confirmedQuantity = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            txtBarCode = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            lblOrderNumber = new Label();
            label5 = new Label();
            lblOmNumber = new Label();
            label7 = new Label();
            lblGeneric = new Label();
            lblStatus = new Label();
            pdConfirmLabel = new System.Drawing.Printing.PrintDocument();
            pnlPrinter = new Panel();
            lblSKU = new Label();
            lblBarCode = new Label();
            lblColor = new Label();
            lblSize = new Label();
            lblPrintedQuantity = new Label();
            lblRealQuantity = new Label();
            lblQuantity = new Label();
            label19 = new Label();
            label17 = new Label();
            label15 = new Label();
            lblVariant = new Label();
            label12 = new Label();
            label8 = new Label();
            label9 = new Label();
            label13 = new Label();
            label14 = new Label();
            button5 = new Button();
            button2 = new Button();
            label6 = new Label();
            label10 = new Label();
            lblBillAccountNumber = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            pnlPrinter.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumOrchid;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(18, 360);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1256, 484);
            panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, BarCode, OfNumber, SKU, RealQuantity, PrintedQuantity, confirmedQuantity, Actions });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(34, 85);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1204, 354);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Identificator";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // BarCode
            // 
            BarCode.DataPropertyName = "BarCode";
            BarCode.HeaderText = "Código de Barras";
            BarCode.MinimumWidth = 6;
            BarCode.Name = "BarCode";
            BarCode.ReadOnly = true;
            BarCode.Width = 125;
            // 
            // OfNumber
            // 
            OfNumber.DataPropertyName = "OfNumber";
            OfNumber.HeaderText = "No. OF";
            OfNumber.MinimumWidth = 6;
            OfNumber.Name = "OfNumber";
            OfNumber.ReadOnly = true;
            OfNumber.Width = 125;
            // 
            // SKU
            // 
            SKU.DataPropertyName = "SKU";
            SKU.HeaderText = "SKU";
            SKU.MinimumWidth = 6;
            SKU.Name = "SKU";
            SKU.ReadOnly = true;
            SKU.Width = 125;
            // 
            // RealQuantity
            // 
            RealQuantity.DataPropertyName = "RealQuantity";
            RealQuantity.HeaderText = "Cantidad Real";
            RealQuantity.MinimumWidth = 6;
            RealQuantity.Name = "RealQuantity";
            RealQuantity.ReadOnly = true;
            RealQuantity.Width = 125;
            // 
            // PrintedQuantity
            // 
            PrintedQuantity.DataPropertyName = "PrintedQuantity";
            PrintedQuantity.HeaderText = "Cantidad Impresa";
            PrintedQuantity.MinimumWidth = 6;
            PrintedQuantity.Name = "PrintedQuantity";
            PrintedQuantity.ReadOnly = true;
            PrintedQuantity.Width = 125;
            // 
            // confirmedQuantity
            // 
            confirmedQuantity.DataPropertyName = "ConfirmedQuantity";
            confirmedQuantity.HeaderText = "Conteo Actual";
            confirmedQuantity.MinimumWidth = 6;
            confirmedQuantity.Name = "confirmedQuantity";
            confirmedQuantity.ReadOnly = true;
            confirmedQuantity.Width = 125;
            // 
            // Actions
            // 
            Actions.HeaderText = "Acciones";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Text = "Imprimir Rotulo";
            Actions.UseColumnTextForButtonValue = true;
            Actions.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 2;
            label3.Text = "PROGRAMACIÓN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBarCode);
            panel1.Location = new Point(79, 135);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 166);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(834, 86);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Padding = new Padding(4, 5, 4, 5);
            button1.Size = new Size(249, 50);
            button1.TabIndex = 3;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 2;
            label2.Text = "Código de Barras";
            // 
            // txtBarCode
            // 
            txtBarCode.Location = new Point(34, 94);
            txtBarCode.Margin = new Padding(4, 5, 4, 5);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(790, 31);
            txtBarCode.TabIndex = 1;
            txtBarCode.KeyDown += txtBarCode_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(371, 43);
            label1.TabIndex = 5;
            label1.Text = "CONFIRMAR PEDIDO";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(356, 854);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Padding = new Padding(4, 5, 4, 5);
            button3.Size = new Size(158, 50);
            button3.TabIndex = 3;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(539, 854);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Padding = new Padding(4, 5, 4, 5);
            button4.Size = new Size(246, 50);
            button4.TabIndex = 3;
            button4.Text = "Imprimir Factura";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(78, 86);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 2;
            label4.Text = "Número de Pedido:";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(265, 86);
            lblOrderNumber.Margin = new Padding(4, 0, 4, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(26, 25);
            lblOrderNumber.TabIndex = 2;
            lblOrderNumber.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(455, 86);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(220, 25);
            label5.TabIndex = 2;
            label5.Text = "Número de Orden (OM):";
            // 
            // lblOmNumber
            // 
            lblOmNumber.AutoSize = true;
            lblOmNumber.Location = new Point(688, 86);
            lblOmNumber.Margin = new Padding(4, 0, 4, 0);
            lblOmNumber.Name = "lblOmNumber";
            lblOmNumber.Size = new Size(26, 25);
            lblOmNumber.TabIndex = 2;
            lblOmNumber.Text = "--";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(851, 86);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 2;
            label7.Text = "Genérico:";
            // 
            // lblGeneric
            // 
            lblGeneric.AutoSize = true;
            lblGeneric.Location = new Point(952, 86);
            lblGeneric.Margin = new Padding(4, 0, 4, 0);
            lblGeneric.Name = "lblGeneric";
            lblGeneric.Size = new Size(26, 25);
            lblGeneric.TabIndex = 2;
            lblGeneric.Text = "--";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(501, 306);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(26, 25);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "--";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pdConfirmLabel
            // 
            pdConfirmLabel.PrintPage += PrintPage;
            // 
            // pnlPrinter
            // 
            pnlPrinter.BackColor = Color.Plum;
            pnlPrinter.Controls.Add(lblSKU);
            pnlPrinter.Controls.Add(lblBarCode);
            pnlPrinter.Controls.Add(lblColor);
            pnlPrinter.Controls.Add(lblSize);
            pnlPrinter.Controls.Add(lblPrintedQuantity);
            pnlPrinter.Controls.Add(lblRealQuantity);
            pnlPrinter.Controls.Add(lblQuantity);
            pnlPrinter.Controls.Add(label19);
            pnlPrinter.Controls.Add(label17);
            pnlPrinter.Controls.Add(label15);
            pnlPrinter.Controls.Add(lblBillAccountNumber);
            pnlPrinter.Controls.Add(lblVariant);
            pnlPrinter.Controls.Add(label12);
            pnlPrinter.Controls.Add(label8);
            pnlPrinter.Controls.Add(label9);
            pnlPrinter.Controls.Add(label13);
            pnlPrinter.Controls.Add(label10);
            pnlPrinter.Controls.Add(label14);
            pnlPrinter.Controls.Add(button5);
            pnlPrinter.Controls.Add(button2);
            pnlPrinter.Controls.Add(label6);
            pnlPrinter.Dock = DockStyle.Fill;
            pnlPrinter.Location = new Point(0, 0);
            pnlPrinter.Margin = new Padding(4, 4, 4, 4);
            pnlPrinter.Name = "pnlPrinter";
            pnlPrinter.Size = new Size(1289, 924);
            pnlPrinter.TabIndex = 8;
            pnlPrinter.Visible = false;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Location = new Point(576, 443);
            lblSKU.Margin = new Padding(4, 0, 4, 0);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(26, 25);
            lblSKU.TabIndex = 10;
            lblSKU.Text = "--";
            // 
            // lblBarCode
            // 
            lblBarCode.AutoSize = true;
            lblBarCode.Location = new Point(576, 383);
            lblBarCode.Margin = new Padding(4, 0, 4, 0);
            lblBarCode.Name = "lblBarCode";
            lblBarCode.Size = new Size(26, 25);
            lblBarCode.TabIndex = 10;
            lblBarCode.Text = "--";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(576, 328);
            lblColor.Margin = new Padding(4, 0, 4, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(26, 25);
            lblColor.TabIndex = 10;
            lblColor.Text = "--";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(576, 274);
            lblSize.Margin = new Padding(4, 0, 4, 0);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(26, 25);
            lblSize.TabIndex = 10;
            lblSize.Text = "--";
            // 
            // lblPrintedQuantity
            // 
            lblPrintedQuantity.AutoSize = true;
            lblPrintedQuantity.Location = new Point(576, 551);
            lblPrintedQuantity.Margin = new Padding(4, 0, 4, 0);
            lblPrintedQuantity.Name = "lblPrintedQuantity";
            lblPrintedQuantity.Size = new Size(26, 25);
            lblPrintedQuantity.TabIndex = 11;
            lblPrintedQuantity.Text = "--";
            // 
            // lblRealQuantity
            // 
            lblRealQuantity.AutoSize = true;
            lblRealQuantity.Location = new Point(576, 498);
            lblRealQuantity.Margin = new Padding(4, 0, 4, 0);
            lblRealQuantity.Name = "lblRealQuantity";
            lblRealQuantity.Size = new Size(26, 25);
            lblRealQuantity.TabIndex = 11;
            lblRealQuantity.Text = "--";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(576, 605);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(26, 25);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "--";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(356, 443);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(52, 25);
            label19.TabIndex = 13;
            label19.Text = "SKU:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(356, 383);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(157, 25);
            label17.TabIndex = 13;
            label17.Text = "Código de Barras";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(356, 328);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(63, 25);
            label15.TabIndex = 13;
            label15.Text = "Color:";
            // 
            // lblVariant
            // 
            lblVariant.AutoSize = true;
            lblVariant.Location = new Point(576, 221);
            lblVariant.Margin = new Padding(4, 0, 4, 0);
            lblVariant.Name = "lblVariant";
            lblVariant.Size = new Size(26, 25);
            lblVariant.TabIndex = 12;
            lblVariant.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(356, 274);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(56, 25);
            label12.TabIndex = 13;
            label12.Text = "Talla:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(356, 551);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(155, 25);
            label8.TabIndex = 14;
            label8.Text = "Catidad Impresa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(356, 498);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 25);
            label9.TabIndex = 14;
            label9.Text = "Cantidad Total:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(356, 605);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(187, 25);
            label13.TabIndex = 14;
            label13.Text = "Cantidad a Imprimir:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(356, 221);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(88, 25);
            label14.TabIndex = 15;
            label14.Text = "Variante:";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(356, 694);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Padding = new Padding(4, 5, 4, 5);
            button5.Size = new Size(209, 50);
            button5.TabIndex = 9;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(594, 694);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Padding = new Padding(4, 5, 4, 5);
            button2.Size = new Size(236, 50);
            button2.TabIndex = 9;
            button2.Text = "Imprimir Rotulos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Cursor = Cursors.No;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(356, 95);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(336, 34);
            label6.TabIndex = 6;
            label6.Text = "DETALLES DE IMPRESIÓN";
            label6.Click += label6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(356, 173);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(179, 25);
            label10.TabIndex = 15;
            label10.Text = "Número de Factura:";
            // 
            // lblBillAccountNumber
            // 
            lblBillAccountNumber.AutoSize = true;
            lblBillAccountNumber.Location = new Point(576, 173);
            lblBillAccountNumber.Margin = new Padding(4, 0, 4, 0);
            lblBillAccountNumber.Name = "lblBillAccountNumber";
            lblBillAccountNumber.Size = new Size(26, 25);
            lblBillAccountNumber.TabIndex = 12;
            lblBillAccountNumber.Text = "--";
            // 
            // frmConfirmOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1289, 924);
            Controls.Add(pnlPrinter);
            Controls.Add(panel2);
            Controls.Add(lblGeneric);
            Controls.Add(lblOmNumber);
            Controls.Add(lblOrderNumber);
            Controls.Add(label7);
            Controls.Add(lblStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmConfirmOrder";
            Text = "frmConfirmOrder";
            Load += frmConfirmOrder_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlPrinter.ResumeLayout(false);
            pnlPrinter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private TextBox txtBarCode;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label lblOrderNumber;
        private Label label5;
        private Label lblOmNumber;
        private Label label7;
        private Label lblGeneric;
        private Label lblStatus;
        private System.Drawing.Printing.PrintDocument pdConfirmLabel;
        private Panel pnlPrinter;
        private Label label6;
        private Button button2;
        private Label lblSize;
        private Label lblQuantity;
        private Label lblVariant;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblSKU;
        private Label lblBarCode;
        private Label lblColor;
        private Label label19;
        private Label label17;
        private Label label15;
        private Button button5;
        private Label lblPrintedQuantity;
        private Label label8;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BarCode;
        private DataGridViewTextBoxColumn OfNumber;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn RealQuantity;
        private DataGridViewTextBoxColumn PrintedQuantity;
        private DataGridViewTextBoxColumn confirmedQuantity;
        private DataGridViewButtonColumn Actions;
        private Label lblRealQuantity;
        private Label label9;
        private Label lblBillAccountNumber;
        private Label label10;
    }
}