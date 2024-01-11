namespace OrdersManagement.Desktop
{
    partial class Orders
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
            label1 = new Label();
            txtSearcher = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            OrderNumber = new DataGridViewTextBoxColumn();
            OmNumber = new DataGridViewTextBoxColumn();
            Generic = new DataGridViewTextBoxColumn();
            OrderState = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            ConfirmOrder = new DataGridViewButtonColumn();
            RemoveOrder = new DataGridViewButtonColumn();
            button2 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            button3 = new Button();
            label4 = new Label();
            txtBillingNumber = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(371, 43);
            label1.TabIndex = 0;
            label1.Text = "TODOS LOS PEDIDOS";
            // 
            // txtSearcher
            // 
            txtSearcher.Location = new Point(24, 56);
            txtSearcher.Name = "txtSearcher";
            txtSearcher.Size = new Size(846, 31);
            txtSearcher.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearcher);
            panel1.Location = new Point(14, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 100);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(876, 56);
            button1.Name = "button1";
            button1.Padding = new Padding(3);
            button1.Size = new Size(110, 41);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 26);
            label2.Name = "label2";
            label2.Size = new Size(398, 25);
            label2.TabIndex = 2;
            label2.Text = "Buscar pedido (Número de orden, OM, generico)";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(14, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(1004, 560);
            panel2.TabIndex = 4;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, OrderNumber, OmNumber, Generic, OrderState, CreatedAt, ConfirmOrder, RemoveOrder });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(24, 51);
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
            dataGridView1.Size = new Size(962, 492);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.Frozen = true;
            Id.HeaderText = "identificador";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // OrderNumber
            // 
            OrderNumber.DataPropertyName = "OrderNumber";
            OrderNumber.Frozen = true;
            OrderNumber.HeaderText = "Número de Pedido";
            OrderNumber.MinimumWidth = 6;
            OrderNumber.Name = "OrderNumber";
            OrderNumber.ReadOnly = true;
            OrderNumber.Width = 125;
            // 
            // OmNumber
            // 
            OmNumber.DataPropertyName = "OmNumber";
            OmNumber.Frozen = true;
            OmNumber.HeaderText = "No. de Orden (OM)";
            OmNumber.MinimumWidth = 6;
            OmNumber.Name = "OmNumber";
            OmNumber.ReadOnly = true;
            OmNumber.Width = 125;
            // 
            // Generic
            // 
            Generic.DataPropertyName = "Generic";
            Generic.Frozen = true;
            Generic.HeaderText = "Generico";
            Generic.MinimumWidth = 6;
            Generic.Name = "Generic";
            Generic.ReadOnly = true;
            Generic.Width = 125;
            // 
            // OrderState
            // 
            OrderState.DataPropertyName = "OrderState";
            OrderState.Frozen = true;
            OrderState.HeaderText = "Estado";
            OrderState.MinimumWidth = 6;
            OrderState.Name = "OrderState";
            OrderState.ReadOnly = true;
            OrderState.Resizable = DataGridViewTriState.True;
            OrderState.Width = 125;
            // 
            // CreatedAt
            // 
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.Frozen = true;
            CreatedAt.HeaderText = "Fecha de Creación";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            CreatedAt.Width = 125;
            // 
            // ConfirmOrder
            // 
            ConfirmOrder.Frozen = true;
            ConfirmOrder.HeaderText = "Confirmar Orden";
            ConfirmOrder.MinimumWidth = 6;
            ConfirmOrder.Name = "ConfirmOrder";
            ConfirmOrder.ReadOnly = true;
            ConfirmOrder.Text = "Confirmar";
            ConfirmOrder.UseColumnTextForButtonValue = true;
            ConfirmOrder.Width = 125;
            // 
            // RemoveOrder
            // 
            RemoveOrder.HeaderText = "Eliminar Orden";
            RemoveOrder.MinimumWidth = 8;
            RemoveOrder.Name = "RemoveOrder";
            RemoveOrder.ReadOnly = true;
            RemoveOrder.Text = "Eliminar Orden";
            RemoveOrder.UseColumnTextForButtonValue = true;
            RemoveOrder.Width = 150;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(876, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(3);
            button2.Size = new Size(110, 42);
            button2.TabIndex = 3;
            button2.Text = "Crear Pedido";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 15);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Pedidos";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtBillingNumber);
            panel3.Location = new Point(14, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(572, 100);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(440, 51);
            button3.Name = "button3";
            button3.Padding = new Padding(3);
            button3.Size = new Size(110, 41);
            button3.TabIndex = 3;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 17);
            label4.Name = "label4";
            label4.Size = new Size(249, 25);
            label4.TabIndex = 2;
            label4.Text = "Ultimo número de facturación";
            // 
            // txtBillingNumber
            // 
            txtBillingNumber.Location = new Point(24, 56);
            txtBillingNumber.Name = "txtBillingNumber";
            txtBillingNumber.Size = new Size(398, 31);
            txtBillingNumber.TabIndex = 1;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 875);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearcher;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn OrderNumber;
        private DataGridViewTextBoxColumn OmNumber;
        private DataGridViewTextBoxColumn Generic;
        private DataGridViewTextBoxColumn OrderState;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewButtonColumn ConfirmOrder;
        private DataGridViewButtonColumn RemoveOrder;
        private Panel panel3;
        private Button button3;
        private Label label4;
        private TextBox txtBillingNumber;
    }
}