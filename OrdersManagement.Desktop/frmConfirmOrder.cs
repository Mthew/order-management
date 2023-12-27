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
using System.Drawing.Printing;

namespace OrdersManagement.Desktop
{
    public partial class frmConfirmOrder : Form
    {
        OrderRepository Repository;
        OrderDTO currentOrder;
        int detailOrderID = 0;
        int quantityToPrint = 0;
        int quantityPrinted = 0;


        public frmConfirmOrder(int? orderID)
        {
            InitializeComponent();
            initializeData(orderID);
        }

        private void frmConfirmOrder_Load(object sender, EventArgs e)
        {
            pnlPrinter.Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            updateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addConfirmedItem();
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

                this.detailOrderID = Convert.ToInt32(row.Cells["id"].Value);

                int confirmedQuantity = Convert.ToInt32(row.Cells["confirmedQuantity"].Value);

                int realQuantity = Convert.ToInt32(row.Cells["RealQuantity"].Value);

                if (confirmedQuantity == realQuantity)
                {
                    MessageBox.Show("¡La cantidad real y el conteo actual deben de ser iguales!");
                    return;
                }

                getDetailOrder(detailOrderID);
            }
        }

        private void getDetailOrder(int detailOrderId)
        {
            pnlPrinter.Visible = true;

            var detailOrder = currentOrder.Details.FirstOrDefault(x => x.Id.Equals(detailOrderId));

            if (detailOrder == null)
            {
                MessageBox.Show("Sucedio un error mientras se imprimia");
                RestoreValues();
                return;
            }

            lblVariant.Text = detailOrder.Variant;
            lblQuantity.Text = detailOrder.ConfirmedQuantity.ToString();
            lblPrintedQuantity.Text = detailOrder.PrintedQuantity.ToString();
            lblSize.Text = detailOrder.Size.ToString();
            lblColor.Text = detailOrder.ColorCode;
            lblBarCode.Text = detailOrder.BarCode;
            lblSKU.Text = detailOrder.Sku;
            lblRealQuantity.Text = detailOrder.RealQuantity.ToString();
            lblBillAccountNumber.Text = new BillAccountRepository().getLastbillAccountNumber().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProgrammingLabel form = new frmProgrammingLabel(currentOrder.Id);
            form.Show();
            this.Hide();
        }

        private void setCurrentOrder(int? orderID)
        {
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

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                addConfirmedItem();
            }
        }

        private void addConfirmedItem()
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
                DetailRepo.AddQuantity(currentOrder.Id, txtBarCode.Text, 1);

                setCurrentOrder(currentOrder.Id);
                updateGrid();

                lblStatus.Text = "¡Producto confirmado!";

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Producto no encontrado";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtBarCode.Text = String.Empty;
                button1.Enabled = true;
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {

            if (this.detailOrderID == 0)
            {
                MessageBox.Show("No se puede imprimir, por favor vuelva a presionar el bton");
            }

            var black = new SolidBrush(Color.Black);

            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            drawFormat.Alignment = StringAlignment.Center;

            Font font = new Font("Arial Narrow", 10, FontStyle.Regular, GraphicsUnit.Point);

            var detailOrder = currentOrder.Details.FirstOrDefault(x => x.Id.Equals(this.detailOrderID));

            if (detailOrder == null)
            {
                MessageBox.Show("No se puede Imprimir");
            }


            //for (int i = 0, j = 0; i < 40; i++, j += 40)
            //{
            //    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(j, 40, 40, 40));
            //    e.Graphics.DrawString($"X-{j}", font, black, new RectangleF(j, 40, 40, 40));
            //}

            //for (int i = 0, j = 0; i < 40; i++, j += 40)
            //{
            //    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(250, j, 40, 40));
            //    e.Graphics.DrawString($"Y-{j}", font, black, new RectangleF(250, j, 40, 40));
            //}


            //////vertical
            const float heigthBox = 40, aumentoY = 0;

            //Proveedor
            e.Graphics.DrawString("Wilmer Mauricio Aguirre Lopez", font, black, new RectangleF(550, 20, 30, 400), drawFormat);
            e.Graphics.DrawString("9000031248", font, black, new RectangleF(570, 300, 25, 200), drawFormat);

            //Campaña
            e.Graphics.DrawString(currentOrder.CampaignNumber, font, black, new RectangleF(510, 85 + aumentoY, heigthBox, 85), drawFormat);

            //Pedido de Compra
            e.Graphics.DrawString(currentOrder.OmNumber, font, black, new RectangleF(510, 280 + aumentoY, heigthBox, 110), drawFormat);

            //# De Factura => 2995 Aqui va un consecutivo
            e.Graphics.DrawString(new BillAccountRepository().getLastbillAccountNumber().ToString(), font, black, new RectangleF(510, 455 + aumentoY, heigthBox, 90), drawFormat);

            //Generico
            e.Graphics.DrawString(currentOrder.Generic, font, black, new RectangleF(440, 85 + aumentoY, heigthBox, 85), drawFormat);

            //Variante
            e.Graphics.DrawString(detailOrder!.Variant, font, black, new RectangleF(440, 280 + aumentoY, heigthBox, 110), drawFormat);

            //Cantidad
            e.Graphics.DrawString(detailOrder!.ConfirmedQuantity.ToString(), font, black, new RectangleF(440, 455 + aumentoY, heigthBox, 90), drawFormat);

            //Talla
            e.Graphics.DrawString(detailOrder!.Size, font, black, new RectangleF(375, 85 + aumentoY, heigthBox, 85), drawFormat);

            //Color
            e.Graphics.DrawString(detailOrder!.ColorCode, font, black, new RectangleF(375, 280 + aumentoY, heigthBox, 110), drawFormat);

            ////#Caja
            //e.Graphics.DrawString("1", font, black, new RectangleF(375, 455 + aumentoY, heigthBox, 90), drawFormat);

            ////Lote
            //e.Graphics.DrawString("?", font, black, new RectangleF(315, 85 + aumentoY, heigthBox, 85), drawFormat);

            ////Fecha
            //e.Graphics.DrawString(DateTime.Now.ToShortDateString(), font, black, new RectangleF(315, 280 + aumentoY, heigthBox, 110), drawFormat);

            //Código de barras
            //e.Graphics.DrawString(detailOrder.BarCode, font, black, new RectangleF(315, 455 + aumentoY, heigthBox, 90), drawFormat);

            //# DOC CALIDAD EXTERNA
            //e.Graphics.DrawString("DOC CALIDAD", font, black, new RectangleF(240, 165 + aumentoY, heigthBox, 215), drawFormat);

            //# sku
            e.Graphics.DrawString(detailOrder.Sku, font, black, new RectangleF(240, 455 + aumentoY, heigthBox, 90), drawFormat);

            //e.HasMorePages = false;
            RestoreValues();
            MessageBox.Show("Preparando impresión de rotulos...");

            //Actualizar cantidad impresa en base de datos;

            OrderDetailRepository DetailRepo = new OrderDetailRepository();
            DetailRepo.AddQuantityPrinted(currentOrder.Id, detailOrder.BarCode);
            detailOrder.PrintedQuantity += detailOrder.ConfirmedQuantity;
            detailOrder.ConfirmedQuantity = 0;
            updateGrid();
            return;

            //////horizontal
            /////const float heigthBox = 40, aumentoY = 15;
            ////Campaña
            //e.Graphics.DrawString("Campaña", font, black, new RectangleF(205, 80 + aumentoY, 85, heigthBox));

            ////Pedido de Compra
            //e.Graphics.DrawString("Pedido Compra", font, black, new RectangleF(400, 80 + aumentoY, 110, heigthBox));

            ////# De Factura
            //e.Graphics.DrawString("# Factura", font, black, new RectangleF(580, 80 + aumentoY, 90, heigthBox));

            ////Generico
            //e.Graphics.DrawString("Gnerico", font, black, new RectangleF(205, 140 + aumentoY, 85, heigthBox));

            ////Variante
            //e.Graphics.DrawString("Variante", font, black, new RectangleF(400, 140 + aumentoY, 110, heigthBox));

            ////Catidad
            //e.Graphics.DrawString("Cantidad", font, black, new RectangleF(580, 140 + aumentoY, 90, heigthBox));

            ////Talla
            //e.Graphics.DrawString("Talla", font, black, new RectangleF(205, 202 + aumentoY, 85, heigthBox));

            ////Color
            //e.Graphics.DrawString("Color", font, black, new RectangleF(400, 202 + aumentoY, 110, heigthBox));

            ////#Caja
            //e.Graphics.DrawString("Caja", font, black, new RectangleF(580, 202 + aumentoY, 90, heigthBox));

            ////Lote
            //e.Graphics.DrawString("Lote", font, black, new RectangleF(205, 270 + aumentoY, 85, heigthBox));

            ////Fecha
            //e.Graphics.DrawString("Fecha", font, black, new RectangleF(400, 270 + aumentoY, 110, heigthBox));

            ////Código de barras
            //e.Graphics.DrawString("Código barras", font, black, new RectangleF(580, 270 + aumentoY, 90, heigthBox));

            ////# DOC CALIDAD EXTERNA
            //e.Graphics.DrawString("DOC CALIDAD", font, black, new RectangleF(290, 340 + aumentoY, 215, heigthBox));

            ////# sku
            //e.Graphics.DrawString("SKU", font, black, new RectangleF(580, 340 + aumentoY, 90, heigthBox));
        }

        private void doPrint()
        {
            pdConfirmLabel = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();

            pdConfirmLabel.PrinterSettings = ps;
            pdConfirmLabel.PrintPage += PrintPage;
            pdConfirmLabel.Print();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doPrint();
        }

        private void RestoreValues()
        {
            lblVariant.Text = string.Empty;
            lblQuantity.Text = string.Empty;
            lblSize.Text = string.Empty;
            lblColor.Text = string.Empty;
            lblBarCode.Text = string.Empty;
            lblSKU.Text = string.Empty;
            lblPrintedQuantity.Text = string.Empty;
            lblRealQuantity.Text = string.Empty;

            pnlPrinter.Visible = false;
            this.detailOrderID = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RestoreValues();
        }

        //TODO: Crear un interface grafica para gestionar el ultimo numero de facturación
        //lenar el datasource para imprimir el PDF de cuenta de cobro
        //Convertir el total a string en la factura (orden de compra)
    }
}
