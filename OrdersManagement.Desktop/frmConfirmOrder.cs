using Microsoft.EntityFrameworkCore.Diagnostics;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OrdersManagement.Desktop
{
    public partial class frmConfirmOrder : Form
    {
        OrderRepository Repository;
        OrderDTO currentOrder;


        public frmConfirmOrder(int? orderID)
        {
            InitializeComponent();
            initializeData(orderID);
        }

        private void frmConfirmOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            updateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBarCode.Text.Length == 0)
            {
                MessageBox.Show("Debe de ingresar el codigo de barras");
            }

            try
            {
                button1.Enabled = false;
                lblStatus.Text = "Actualizando la cantidad del producto...";

                OrderDetailRepository DetailRepo = new OrderDetailRepository();
                DetailRepo.AddQuantity(txtBarCode.Text, 1);

                setCurrentOrder(currentOrder.Id);
                updateGrid();

                lblStatus.Text = "¡Producto confirmado!";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private void initializeData(int? orderID)
        {
            Repository = new OrderRepository();
            currentOrder = new OrderDTO();

            if (orderID is null)
            {
                throw new Exception("¡No ha seleccionado ninguna orden!");
            }

            setCurrentOrder(orderID);

            lblOrderNumber.Text = currentOrder.OrderNumber;
            lblOmNumber.Text = currentOrder.OmNumber;
            lblGeneric.Text = currentOrder.Generic;

            //obtener la orden actual,
            //el grid se debe ede ir cargando a medida que se escaneen los productos, ir aumentando la columna de catidad a medida que se valla escanenando
            //hacer fucnionalidad de impresion
            //hacer funbcionañlida de impresion de detalle de rotulosss
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders frmOrders = new Orders();
            frmOrders.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                DataGridViewRow row = senderGrid.Rows[e.RowIndex];

                int orderID = Convert.ToInt32(row.Cells["id"].Value);

                // imprimirRotulo

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // imprimir fatura
        }

        private void setCurrentOrder(int? orderID) {
            currentOrder = Repository.getById((int)orderID);
        }

        private void updateGrid()
        {
            dataGridView1.CancelEdit();
            dataGridView1.DataSource = null;

            if (currentOrder.Details.Count > 0)
            {
                dataGridView1.DataSource = currentOrder.Details;
            }
        }


    }
}
