using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HarryPotter.Domain;
using HarryPotter.Services;

namespace HarryPotter.StoreApp
{
    public partial class frmCart : Form
    {

        private Order _order;
        private IOrderService _orderService;

        public frmCart(Order order)
        {
            InitializeComponent();
            this._order = order;
            this._orderService = new OrderService();
        }

        private void lblEmail_TextChanged(object sender, EventArgs e)
        {
            this._order.ClientEmail = lblEmail.Text;
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                this._orderService.Create(this._order);
                MessageBox.Show("Su orden se ha generado correctamente", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se generó un error al crear su orden. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
