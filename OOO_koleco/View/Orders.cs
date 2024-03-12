using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_koleco.View
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            try
            {
                classes.DBHelper.DB = new Model.OOO_KolecoEntities();
            }
            catch
            {

            }

            pictureBoxIcon.ImageLocation = Environment.CurrentDirectory + "/Resources/koleco.png";
            pictureBoxIcon.BackColor = Color.Transparent;
            buttonExit.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            //buttonEntry.BackColor = ColorTranslator.FromHtml("#B3F4E9");

            List<Model.Orders> listdb = classes.DBHelper.DB.Orders.ToList();

            // Очистим сначала DataGridView перед добавлением новых данных
            dataGridViewOrders.Rows.Clear();

            foreach (var order in listdb)
            {
                int orderId = order.OrdersID;
                string userFullName = order.Users.UsersFullName;
                string carDetails = $"{order.Cars.CarsMake} {order.Cars.CarsModel} {order.Cars.CarsYear}";
                string orderDate = order.OrdersDate.ToString("yyyy-MM-dd");

                // Добавляем новую строку в DataGridView
                dataGridViewOrders.Rows.Add(orderId, userFullName, carDetails, orderDate);
            }

            //dataGridViewOrders.DataSource = listdb;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
