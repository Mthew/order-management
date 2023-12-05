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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOmNumber = new System.Windows.Forms.TextBox();
            this.txtGeneric = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnProgramming = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.gbProgramming = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOfNumber = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtVariant = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRealQuantity = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUmQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnProgramming.SuspendLayout();
            this.gbProgramming.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 277);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OfNumber,
            this.SKU,
            this.Color,
            this.Size,
            this.Actions});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(734, 209);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "identificador";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // OfNumber
            // 
            this.OfNumber.DataPropertyName = "OfNumber";
            this.OfNumber.HeaderText = "No OF";
            this.OfNumber.Name = "OfNumber";
            this.OfNumber.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Talla";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Acciones";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            this.Actions.Text = "Eliminar";
            this.Actions.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pedidos";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(391, 536);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Guardar Pedido";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOmNumber);
            this.panel1.Controls.Add(this.txtGeneric);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 160);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(537, 106);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(221, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar Programación";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de Orden (OM)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Generico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de Pedido";
            // 
            // txtOmNumber
            // 
            this.txtOmNumber.Location = new System.Drawing.Point(408, 49);
            this.txtOmNumber.Name = "txtOmNumber";
            this.txtOmNumber.Size = new System.Drawing.Size(350, 23);
            this.txtOmNumber.TabIndex = 1;
            // 
            // txtGeneric
            // 
            this.txtGeneric.Location = new System.Drawing.Point(24, 111);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Size = new System.Drawing.Size(350, 23);
            this.txtGeneric.TabIndex = 1;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(24, 49);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(350, 23);
            this.txtOrderNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "INGRESAR PEDIDO";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(266, 536);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(3);
            this.button3.Size = new System.Drawing.Size(110, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnProgramming
            // 
            this.pnProgramming.BackColor = System.Drawing.Color.RosyBrown;
            this.pnProgramming.Controls.Add(this.label13);
            this.pnProgramming.Controls.Add(this.gbProgramming);
            this.pnProgramming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProgramming.Location = new System.Drawing.Point(0, 0);
            this.pnProgramming.Name = "pnProgramming";
            this.pnProgramming.Size = new System.Drawing.Size(815, 593);
            this.pnProgramming.TabIndex = 9;
            this.pnProgramming.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Cursor = System.Windows.Forms.Cursors.No;
            this.label13.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(19, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(461, 28);
            this.label13.TabIndex = 11;
            this.label13.Text = "AGREGAR PROGRAMACIÓN";
            // 
            // gbProgramming
            // 
            this.gbProgramming.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbProgramming.Controls.Add(this.txtSize);
            this.gbProgramming.Controls.Add(this.button5);
            this.gbProgramming.Controls.Add(this.label11);
            this.gbProgramming.Controls.Add(this.txtOfNumber);
            this.gbProgramming.Controls.Add(this.button4);
            this.gbProgramming.Controls.Add(this.txtColor);
            this.gbProgramming.Controls.Add(this.txtVariant);
            this.gbProgramming.Controls.Add(this.label16);
            this.gbProgramming.Controls.Add(this.label8);
            this.gbProgramming.Controls.Add(this.label10);
            this.gbProgramming.Controls.Add(this.txtRealQuantity);
            this.gbProgramming.Controls.Add(this.txtSKU);
            this.gbProgramming.Controls.Add(this.txtColorCode);
            this.gbProgramming.Controls.Add(this.label14);
            this.gbProgramming.Controls.Add(this.label7);
            this.gbProgramming.Controls.Add(this.label9);
            this.gbProgramming.Controls.Add(this.txtUmQuantity);
            this.gbProgramming.Controls.Add(this.label12);
            this.gbProgramming.Controls.Add(this.txtBarCode);
            this.gbProgramming.Controls.Add(this.label6);
            this.gbProgramming.Location = new System.Drawing.Point(19, 159);
            this.gbProgramming.Name = "gbProgramming";
            this.gbProgramming.Size = new System.Drawing.Size(776, 275);
            this.gbProgramming.TabIndex = 10;
            this.gbProgramming.TabStop = false;
            this.gbProgramming.Text = "Programación";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(522, 114);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(236, 23);
            this.txtSize.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(448, 223);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(3);
            this.button5.Size = new System.Drawing.Size(110, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(522, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Talla";
            // 
            // txtOfNumber
            // 
            this.txtOfNumber.Location = new System.Drawing.Point(522, 180);
            this.txtOfNumber.Name = "txtOfNumber";
            this.txtOfNumber.Size = new System.Drawing.Size(236, 23);
            this.txtOfNumber.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuText;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(568, 223);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(3);
            this.button4.Size = new System.Drawing.Size(190, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Agregar programación";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(522, 52);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(236, 23);
            this.txtColor.TabIndex = 1;
            // 
            // txtVariant
            // 
            this.txtVariant.Location = new System.Drawing.Point(272, 114);
            this.txtVariant.Name = "txtVariant";
            this.txtVariant.Size = new System.Drawing.Size(236, 23);
            this.txtVariant.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(522, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "No. OF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Variante";
            // 
            // txtRealQuantity
            // 
            this.txtRealQuantity.Location = new System.Drawing.Point(272, 180);
            this.txtRealQuantity.Name = "txtRealQuantity";
            this.txtRealQuantity.Size = new System.Drawing.Size(236, 23);
            this.txtRealQuantity.TabIndex = 1;
            // 
            // txtSKU
            // 
            this.txtSKU.Location = new System.Drawing.Point(272, 52);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(236, 23);
            this.txtSKU.TabIndex = 1;
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(24, 114);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(236, 23);
            this.txtColorCode.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cantidad Real";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "SKU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cod. Color";
            // 
            // txtUmQuantity
            // 
            this.txtUmQuantity.Location = new System.Drawing.Point(24, 180);
            this.txtUmQuantity.Name = "txtUmQuantity";
            this.txtUmQuantity.Size = new System.Drawing.Size(236, 23);
            this.txtUmQuantity.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Cantidad/UM";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(24, 52);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(236, 23);
            this.txtBarCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Código de Barras";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 593);
            this.Controls.Add(this.pnProgramming);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnProgramming.ResumeLayout(false);
            this.pnProgramming.PerformLayout();
            this.gbProgramming.ResumeLayout(false);
            this.gbProgramming.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}