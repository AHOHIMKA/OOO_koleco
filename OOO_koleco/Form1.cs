using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_koleco
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // classes.DBHelper.DB = new Model.OOO_KolecoEntities();

            try
            {
                classes.DBHelper.DB = new Model.OOO_KolecoEntities();
                MessageBox.Show("Связь с БД успешно установлена!");
            }
            catch
            {
                MessageBox.Show("Связь с БД нарушена!!!");

            }

            pictureBoxIcon.ImageLocation = Environment.CurrentDirectory + "/Resources/koleco.png";
            pictureBoxIcon.BackColor = Color.Transparent;
            buttonExit.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            buttonEntry.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonEntry_Click(object sender, EventArgs e)
        {

            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            HandleLoginAttempt(login, password);
        }


        public void HandleLoginAttempt(string login, string password)
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                sb.AppendLine("Вы не ввели логин или пароль");
                if (sb.Length > 0)
                {
                    MessageBox.Show(sb.ToString());
                }
            }
            else
            {
                classes.DBHelper.User = classes.DBHelper.DB.Users
                    .Where(u => u.UsersEmail == login && u.UsersPassword == password)
                    .FirstOrDefault();

                sb = new StringBuilder();

                if (classes.DBHelper.User != null)
                {
                    sb.AppendLine("Здравствуйте, " + classes.DBHelper.User.UsersFullName);
                    sb.AppendLine("Вы вошли с ролью - " + classes.DBHelper.User.Role.RoleName);
                    MessageBox.Show(sb.ToString());
                    //GoToCatalog();
                    if (classes.DBHelper.User.Role.RoleName == "Администратор")
                    {
                        GoToCarsAdd();
                    }
                    else
                    {
                        GoToOrders();
                    }
                   

                }
                else
                {
                    sb.AppendLine("Такой пользователь отсутствует \nПовторите ввод логина и пароля");
                    MessageBox.Show(sb.ToString());
                }
            }
        }
        private void GoToCatalog() { View.Catalog catalog = new View.Catalog(); this.Hide(); catalog.ShowDialog(); this.Show(); }
        private void GoToOrders() { View.Orders orders = new View.Orders(); this.Hide(); orders.ShowDialog(); this.Show(); }
        private void GoToCarsAdd() { View.CarsAdd carssadd = new View.CarsAdd(); this.Hide(); carssadd.ShowDialog(); this.Show(); }

    }
}
