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
            panel2.Location = new Point(14, 288);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1005, 387);
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
            dataGridView1.Location = new Point(27, 68);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
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
            dataGridView1.Size = new Size(963, 283);
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
            label3.Location = new Point(27, 20);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "PROGRAMACIÓN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBarCode);
            panel1.Location = new Point(63, 108);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 133);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(667, 69);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(3, 4, 3, 4);
            button1.Size = new Size(199, 40);
            button1.TabIndex = 3;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 35);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Código de Barras";
            // 
            // txtBarCode
            // 
            txtBarCode.Location = new Point(27, 75);
            txtBarCode.Margin = new Padding(3, 4, 3, 4);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(633, 27);
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
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 37);
            label1.TabIndex = 5;
            label1.Text = "CONFIRMAR PEDIDO";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(285, 683);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(3, 4, 3, 4);
            button3.Size = new Size(126, 40);
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
            button4.Location = new Point(431, 683);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(3, 4, 3, 4);
            button4.Size = new Size(197, 40);
            button4.TabIndex = 3;
            button4.Text = "Imprimir Factura";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(62, 69);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 2;
            label4.Text = "Número de Pedido:";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Location = new Point(212, 69);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(21, 20);
            lblOrderNumber.TabIndex = 2;
            lblOrderNumber.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(364, 69);
            label5.Name = "label5";
            label5.Size = new Size(180, 20);
            label5.TabIndex = 2;
            label5.Text = "Número de Orden (OM):";
            // 
            // lblOmNumber
            // 
            lblOmNumber.AutoSize = true;
            lblOmNumber.Location = new Point(550, 69);
            lblOmNumber.Name = "lblOmNumber";
            lblOmNumber.Size = new Size(21, 20);
            lblOmNumber.TabIndex = 2;
            lblOmNumber.Text = "--";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(681, 69);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 2;
            label7.Text = "Genérico:";
            // 
            // lblGeneric
            // 
            lblGeneric.AutoSize = true;
            lblGeneric.Location = new Point(762, 69);
            lblGeneric.Name = "lblGeneric";
            lblGeneric.Size = new Size(21, 20);
            lblGeneric.TabIndex = 2;
            lblGeneric.Text = "--";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(401, 245);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(21, 20);
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
            pnlPrinter.Controls.Add(lblVariant);
            pnlPrinter.Controls.Add(label12);
            pnlPrinter.Controls.Add(label8);
            pnlPrinter.Controls.Add(label9);
            pnlPrinter.Controls.Add(label13);
            pnlPrinter.Controls.Add(label14);
            pnlPrinter.Controls.Add(button5);
            pnlPrinter.Controls.Add(button2);
            pnlPrinter.Controls.Add(label6);
            pnlPrinter.Location = new Point(550, 217);
            pnlPrinter.Name = "pnlPrinter";
            pnlPrinter.Size = new Size(481, 385);
            pnlPrinter.TabIndex = 8;
            pnlPrinter.Visible = false;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Location = new Point(461, 312);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(21, 20);
            lblSKU.TabIndex = 10;
            lblSKU.Text = "--";
            // 
            // lblBarCode
            // 
            lblBarCode.AutoSize = true;
            lblBarCode.Location = new Point(461, 264);
            lblBarCode.Name = "lblBarCode";
            lblBarCode.Size = new Size(21, 20);
            lblBarCode.TabIndex = 10;
            lblBarCode.Text = "--";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(461, 220);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(21, 20);
            lblColor.TabIndex = 10;
            lblColor.Text = "--";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(461, 177);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(21, 20);
            lblSize.TabIndex = 10;
            lblSize.Text = "--";
            // 
            // lblPrintedQuantity
            // 
            lblPrintedQuantity.AutoSize = true;
            lblPrintedQuantity.Location = new Point(461, 398);
            lblPrintedQuantity.Name = "lblPrintedQuantity";
            lblPrintedQuantity.Size = new Size(21, 20);
            lblPrintedQuantity.TabIndex = 11;
            lblPrintedQuantity.Text = "--";
            // 
            // lblRealQuantity
            // 
            lblRealQuantity.AutoSize = true;
            lblRealQuantity.Location = new Point(461, 356);
            lblRealQuantity.Name = "lblRealQuantity";
            lblRealQuantity.Size = new Size(21, 20);
            lblRealQuantity.TabIndex = 11;
            lblRealQuantity.Text = "--";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(461, 442);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(21, 20);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "--";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(285, 312);
            label19.Name = "label19";
            label19.Size = new Size(42, 20);
            label19.TabIndex = 13;
            label19.Text = "SKU:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(285, 264);
            label17.Name = "label17";
            label17.Size = new Size(128, 20);
            label17.TabIndex = 13;
            label17.Text = "Código de Barras";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(285, 220);
            label15.Name = "label15";
            label15.Size = new Size(51, 20);
            label15.TabIndex = 13;
            label15.Text = "Color:";
            // 
            // lblVariant
            // 
            lblVariant.AutoSize = true;
            lblVariant.Location = new Point(461, 134);
            lblVariant.Name = "lblVariant";
            lblVariant.Size = new Size(21, 20);
            lblVariant.TabIndex = 12;
            lblVariant.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(285, 177);
            label12.Name = "label12";
            label12.Size = new Size(45, 20);
            label12.TabIndex = 13;
            label12.Text = "Talla:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(285, 398);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 14;
            label8.Text = "Catidad Impresa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(285, 356);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 14;
            label9.Text = "Cantidad Total:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(285, 442);
            label13.Name = "label13";
            label13.Size = new Size(154, 20);
            label13.TabIndex = 14;
            label13.Text = "Cantidad a Imprimir:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(285, 134);
            label14.Name = "label14";
            label14.Size = new Size(71, 20);
            label14.TabIndex = 15;
            label14.Text = "Variante:";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(285, 555);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(3, 4, 3, 4);
            button5.Size = new Size(167, 40);
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
            button2.Location = new Point(475, 555);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(3, 4, 3, 4);
            button2.Size = new Size(189, 40);
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
            label6.Location = new Point(285, 76);
            label6.Name = "label6";
            label6.Size = new Size(283, 28);
            label6.TabIndex = 6;
            label6.Text = "DETALLES DE IMPRESIÓN";
            label6.Click += label6_Click;
            // 
            // frmConfirmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1031, 739);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}