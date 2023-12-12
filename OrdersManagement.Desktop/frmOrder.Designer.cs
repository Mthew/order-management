namespace OrdersManagement.Desktop
{
    partial class frmOrder
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
            OfNumber = new DataGridViewTextBoxColumn();
            SKU = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Actions = new DataGridViewButtonColumn();
            label3 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtOmNumber = new TextBox();
            txtGeneric = new TextBox();
            txtOrderNumber = new TextBox();
            label1 = new Label();
            button3 = new Button();
            pnProgramming = new Panel();
            label13 = new Label();
            gbProgramming = new GroupBox();
            txtSize = new TextBox();
            button5 = new Button();
            label11 = new Label();
            txtOfNumber = new TextBox();
            button4 = new Button();
            txtColor = new TextBox();
            txtVariant = new TextBox();
            label16 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtRealQuantity = new TextBox();
            txtSKU = new TextBox();
            txtColorCode = new TextBox();
            label14 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtUmQuantity = new TextBox();
            label12 = new Label();
            txtBarCode = new TextBox();
            label6 = new Label();
            txtCampaingNumber = new TextBox();
            label15 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            pnProgramming.SuspendLayout();
            gbProgramming.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(14, 338);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 369);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, OfNumber, SKU, Color, Size, Actions });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(27, 68);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
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
            dataGridView1.Size = new Size(839, 279);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "identificador";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // OfNumber
            // 
            OfNumber.DataPropertyName = "OfNumber";
            OfNumber.HeaderText = "No OF";
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
            // Color
            // 
            Color.DataPropertyName = "Color";
            Color.HeaderText = "Color";
            Color.MinimumWidth = 6;
            Color.Name = "Color";
            Color.ReadOnly = true;
            Color.Width = 125;
            // 
            // Size
            // 
            Size.DataPropertyName = "Size";
            Size.HeaderText = "Talla";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            Size.Resizable = DataGridViewTriState.True;
            Size.Width = 125;
            // 
            // Actions
            // 
            Actions.HeaderText = "Acciones";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Text = "Eliminar";
            Actions.UseColumnTextForButtonValue = true;
            Actions.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 20);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Pedidos";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new Point(447, 715);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(3, 4, 3, 4);
            button2.Size = new Size(126, 40);
            button2.TabIndex = 3;
            button2.Text = "Guardar Pedido";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtOmNumber);
            panel1.Controls.Add(txtCampaingNumber);
            panel1.Controls.Add(txtGeneric);
            panel1.Controls.Add(txtOrderNumber);
            panel1.Location = new Point(14, 64);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 266);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new Point(613, 205);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(3, 4, 3, 4);
            button1.Size = new Size(253, 40);
            button1.TabIndex = 3;
            button1.Text = "Agregar Programación";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 35);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 2;
            label4.Text = "Número de Orden (OM)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 117);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 2;
            label5.Text = "Generico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 35);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 2;
            label2.Text = "Número de Pedido";
            // 
            // txtOmNumber
            // 
            txtOmNumber.Location = new Point(466, 65);
            txtOmNumber.Margin = new Padding(3, 4, 3, 4);
            txtOmNumber.Name = "txtOmNumber";
            txtOmNumber.Size = new Size(399, 27);
            txtOmNumber.TabIndex = 1;
            // 
            // txtGeneric
            // 
            txtGeneric.Location = new Point(27, 148);
            txtGeneric.Margin = new Padding(3, 4, 3, 4);
            txtGeneric.Name = "txtGeneric";
            txtGeneric.Size = new Size(399, 27);
            txtGeneric.TabIndex = 1;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(27, 65);
            txtOrderNumber.Margin = new Padding(3, 4, 3, 4);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(399, 27);
            txtOrderNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 37);
            label1.TabIndex = 5;
            label1.Text = "INGRESAR PEDIDO";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.Black;
            button3.Location = new Point(304, 715);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(3, 4, 3, 4);
            button3.Size = new Size(126, 40);
            button3.TabIndex = 8;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnProgramming
            // 
            pnProgramming.BackColor = SystemColors.ActiveCaption;
            pnProgramming.Controls.Add(label13);
            pnProgramming.Controls.Add(gbProgramming);
            pnProgramming.Location = new Point(408, 485);
            pnProgramming.Margin = new Padding(3, 4, 3, 4);
            pnProgramming.Name = "pnProgramming";
            pnProgramming.Size = new Size(523, 306);
            pnProgramming.TabIndex = 9;
            pnProgramming.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Cursor = Cursors.No;
            label13.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = System.Drawing.Color.Black;
            label13.Location = new Point(22, 164);
            label13.Name = "label13";
            label13.Size = new Size(419, 37);
            label13.TabIndex = 11;
            label13.Text = "AGREGAR PROGRAMACIÓN";
            // 
            // gbProgramming
            // 
            gbProgramming.BackColor = SystemColors.GradientActiveCaption;
            gbProgramming.Controls.Add(txtSize);
            gbProgramming.Controls.Add(button5);
            gbProgramming.Controls.Add(label11);
            gbProgramming.Controls.Add(txtOfNumber);
            gbProgramming.Controls.Add(button4);
            gbProgramming.Controls.Add(txtColor);
            gbProgramming.Controls.Add(txtVariant);
            gbProgramming.Controls.Add(label16);
            gbProgramming.Controls.Add(label8);
            gbProgramming.Controls.Add(label10);
            gbProgramming.Controls.Add(txtRealQuantity);
            gbProgramming.Controls.Add(txtSKU);
            gbProgramming.Controls.Add(txtColorCode);
            gbProgramming.Controls.Add(label14);
            gbProgramming.Controls.Add(label7);
            gbProgramming.Controls.Add(label9);
            gbProgramming.Controls.Add(txtUmQuantity);
            gbProgramming.Controls.Add(label12);
            gbProgramming.Controls.Add(txtBarCode);
            gbProgramming.Controls.Add(label6);
            gbProgramming.Location = new Point(22, 212);
            gbProgramming.Margin = new Padding(3, 4, 3, 4);
            gbProgramming.Name = "gbProgramming";
            gbProgramming.Padding = new Padding(3, 4, 3, 4);
            gbProgramming.Size = new Size(887, 367);
            gbProgramming.TabIndex = 10;
            gbProgramming.TabStop = false;
            gbProgramming.Text = "Programación";
            // 
            // txtSize
            // 
            txtSize.Location = new Point(597, 152);
            txtSize.Margin = new Padding(3, 4, 3, 4);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(269, 27);
            txtSize.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.InactiveCaption;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = System.Drawing.Color.Black;
            button5.Location = new Point(512, 297);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(3, 4, 3, 4);
            button5.Size = new Size(126, 40);
            button5.TabIndex = 8;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(597, 121);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 2;
            label11.Text = "Talla";
            // 
            // txtOfNumber
            // 
            txtOfNumber.Location = new Point(597, 240);
            txtOfNumber.Margin = new Padding(3, 4, 3, 4);
            txtOfNumber.Name = "txtOfNumber";
            txtOfNumber.Size = new Size(269, 27);
            txtOfNumber.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuText;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.White;
            button4.Location = new Point(649, 297);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(3, 4, 3, 4);
            button4.Size = new Size(217, 40);
            button4.TabIndex = 3;
            button4.Text = "Agregar programación";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(597, 69);
            txtColor.Margin = new Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(269, 27);
            txtColor.TabIndex = 1;
            // 
            // txtVariant
            // 
            txtVariant.Location = new Point(311, 152);
            txtVariant.Margin = new Padding(3, 4, 3, 4);
            txtVariant.Name = "txtVariant";
            txtVariant.Size = new Size(269, 27);
            txtVariant.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(597, 209);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
            label16.TabIndex = 2;
            label16.Text = "No. OF";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(597, 39);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 2;
            label8.Text = "Color";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(311, 121);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 2;
            label10.Text = "Variante";
            // 
            // txtRealQuantity
            // 
            txtRealQuantity.Location = new Point(311, 240);
            txtRealQuantity.Margin = new Padding(3, 4, 3, 4);
            txtRealQuantity.Name = "txtRealQuantity";
            txtRealQuantity.Size = new Size(269, 27);
            txtRealQuantity.TabIndex = 1;
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(311, 69);
            txtSKU.Margin = new Padding(3, 4, 3, 4);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(269, 27);
            txtSKU.TabIndex = 1;
            // 
            // txtColorCode
            // 
            txtColorCode.Location = new Point(27, 152);
            txtColorCode.Margin = new Padding(3, 4, 3, 4);
            txtColorCode.Name = "txtColorCode";
            txtColorCode.Size = new Size(269, 27);
            txtColorCode.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(311, 209);
            label14.Name = "label14";
            label14.Size = new Size(102, 20);
            label14.TabIndex = 2;
            label14.Text = "Cantidad Real";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(311, 39);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 2;
            label7.Text = "SKU";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 121);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 2;
            label9.Text = "Cod. Color";
            // 
            // txtUmQuantity
            // 
            txtUmQuantity.Location = new Point(27, 240);
            txtUmQuantity.Margin = new Padding(3, 4, 3, 4);
            txtUmQuantity.Name = "txtUmQuantity";
            txtUmQuantity.Size = new Size(269, 27);
            txtUmQuantity.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 209);
            label12.Name = "label12";
            label12.Size = new Size(98, 20);
            label12.TabIndex = 2;
            label12.Text = "Cantidad/UM";
            // 
            // txtBarCode
            // 
            txtBarCode.Location = new Point(27, 69);
            txtBarCode.Margin = new Padding(3, 4, 3, 4);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(269, 27);
            txtBarCode.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 39);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 2;
            label6.Text = "Código de Barras";
            // 
            // txtCampaingNumber
            // 
            txtCampaingNumber.Location = new Point(466, 148);
            txtCampaingNumber.Margin = new Padding(3, 4, 3, 4);
            txtCampaingNumber.Name = "txtCampaingNumber";
            txtCampaingNumber.Size = new Size(399, 27);
            txtCampaingNumber.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(466, 117);
            label15.Name = "label15";
            label15.Size = new Size(72, 20);
            label15.TabIndex = 2;
            label15.Text = "Campaña";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(931, 791);
            Controls.Add(pnProgramming);
            Controls.Add(button3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnProgramming.ResumeLayout(false);
            pnProgramming.PerformLayout();
            gbProgramming.ResumeLayout(false);
            gbProgramming.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private TextBox txtOrderNumber;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtOmNumber;
        private TextBox txtGeneric;
        private Button button3;
        private Panel pnProgramming;
        private GroupBox gbProgramming;
        private TextBox txtSize;
        private Button button5;
        private Label label11;
        private TextBox txtOfNumber;
        private Button button4;
        private TextBox txtColor;
        private TextBox txtVariant;
        private Label label16;
        private Label label8;
        private Label label10;
        private TextBox txtRealQuantity;
        private TextBox txtSKU;
        private TextBox txtColorCode;
        private Label label14;
        private Label label7;
        private Label label9;
        private TextBox txtUmQuantity;
        private Label label12;
        private TextBox txtBarCode;
        private Label label6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn OfNumber;
        private DataGridViewTextBoxColumn SKU;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewButtonColumn Actions;
        private Label label13;
        private Label label15;
        private TextBox txtCampaingNumber;
    }
}