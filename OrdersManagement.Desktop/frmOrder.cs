using OrdersManagement.Entity.DTO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OrdersManagement.Desktop
{
    public partial class frmOrder : Form
    {
        List<OrderDetailDTO> details;

        public frmOrder()
        {
            details = new List<OrderDetailDTO>();
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            showProgrammingPanel(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showProgrammingPanel(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showProgrammingPanel(false);
        }

        private void showProgrammingPanel(bool state)
        {
            cleanFields();
            pnProgramming.Visible = state;
            if (state)
            {
                txtBarCode.Focus();
            }
        }

        private void cleanFields()
        {
            txtBarCode.Text = String.Empty;
            txtSKU.Text = String.Empty;
            txtColor.Text = String.Empty;
            txtColorCode.Text = String.Empty;
            txtVariant.Text = String.Empty;
            txtSize.Text = String.Empty;
            txtRealQuantity.Text = String.Empty;
            txtUmQuantity.Text = String.Empty;
            txtOfNumber.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gotoOrders();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderDetailDTO detail = new OrderDetailDTO();

            detail.Id = details.Count;
            detail.BarCode = txtBarCode.Text;
            detail.Sku = txtSKU.Text;
            detail.Color = txtColor.Text;
            detail.ColorCode = txtColorCode.Text;
            detail.Variant = txtVariant.Text;
            detail.Size = txtSize.Text;
            detail.RealQuantity = Convert.ToInt32(txtRealQuantity.Text);
            detail.UmQuantity = Convert.ToInt32(txtUmQuantity.Text);
            detail.OfNumber = txtOfNumber.Text;

            details.Add(detail);

            updateGrid();
            showProgrammingPanel(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Guardar todo
            OrderDTO order = new OrderDTO();
            order.OrderNumber = txtOrderNumber.Text;
            order.OmNumber = txtOmNumber.Text;
            order.Generic = txtGeneric.Text;
            order.OrderState = OrderStateDTO.NEW;
            order.Details = details;
            order.CampaignNumber = txtCampaingNumber.Text;

            OrderRepository Repo = new OrderRepository();
            Repo.Create(order);

            MessageBox.Show("¡Pedido creado exitosamente!");

            gotoOrders();
        }

        private void updateGrid()
        {
            dataGridView1.CancelEdit();
            dataGridView1.DataSource = null;
            if (details.Count > 0)
            {
                dataGridView1.DataSource = details;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                DataGridViewRow row = senderGrid.Rows[e.RowIndex];

                int orderDetailID = Convert.ToInt32(row.Cells["id"].Value);
                removeItem(orderDetailID);

            }


        }

        private void removeItem(int orderDetailID)
        {
            OrderDetailDTO item = details.First(x => x.Id == orderDetailID);
            if (item != null)
            {
                details.Remove(item);
                updateGrid();
            }

        }

        private void gotoOrders()
        {
            Orders frm = new Orders();
            frm.Show();
            this.Hide();
        }
    }
}
