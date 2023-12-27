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

namespace OrdersManagement.Desktop
{
    public partial class Orders : Form
    {
        OrderRepository repository = new OrderRepository();

        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            this.Display();
        }

        public void Display()
        {
            List<OrderDTO> orders = repository.getAll();
            dataGridView1.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter = txtSearcher.Text;
            if (filter.Length == 0)
            {
                MessageBox.Show("Debe de digitar un concepto de busuqeda");
            }

            List<OrderDTO> orders = repository.filter(filter);
            dataGridView1.DataSource = orders;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DataGridViewRow row = senderGrid.Rows[e.RowIndex];
                int orderID = Convert.ToInt32(row.Cells["id"].Value);

                if (e.ColumnIndex == dataGridView1.Columns["ConfirmOrder"].Index)
                {
                    gotoConfirmOrder(orderID);
                    return;
                }

                if (e.ColumnIndex == dataGridView1.Columns["RemoveOrder"].Index)
                {
                    OrderDelete(orderID);
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gotoCreateOrder();
        }

        private void gotoConfirmOrder(int orderId)
        {
            frmConfirmOrder form = new frmConfirmOrder(orderId);
            form.Show();
            this.Hide();
        }

        private void gotoCreateOrder()
        {
            frmOrder form = new frmOrder();
            form.Show();
            this.Hide();
        }

        public void OrderDelete(int orderId)
        {
            if (MessageBox.Show("¿Esta seguro de eliminar la orden?", "Eliminar Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repository.Remove(orderId);
                Display();
                MessageBox.Show("¡Orden Eliminada!");
            }
        }
    }
}
