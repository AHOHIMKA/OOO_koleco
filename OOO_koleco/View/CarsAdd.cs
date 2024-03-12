using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OOO_koleco.View
{
    public partial class CarsAdd : Form
    {
        public CarsAdd()
        {
            InitializeComponent();
        }

        private void buttonCreateNewClient_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand sqlQuery = new SqlCommand("INSERT INTO [Users] (UsersFullName,UsersEmail,UsersPassword,UsersRole,UsersPol) VALUES (@UsersFullName, @UsersEmail, @UsersPassword, @UsersRole,@UsersPol)", connection);

                    sqlQuery.Parameters.AddWithValue("@UsersFullName", textBoxFIOClient.Text);
                    sqlQuery.Parameters.AddWithValue("@UsersEmail", textBoxEmailNewUsers.Text);
                    sqlQuery.Parameters.AddWithValue("@UsersPassword", textBoxNewPassClient.Text);
                    sqlQuery.Parameters.AddWithValue("@UsersRole", "1");
                    sqlQuery.Parameters.AddWithValue("@UsersPol", textBoxPolClient.Text);


                    sqlQuery.ExecuteNonQuery();

                    MessageBox.Show($"Клиент успешно создан!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании клиента: " + ex.Message);
            }
        }

        private void CarsAdd_Load(object sender, EventArgs e)
        {
            pictureBoxIcon.ImageLocation = Environment.CurrentDirectory + "/Resources/koleco.png";
            pictureBoxIcon.BackColor = Color.Transparent;
            buttonExit.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            buttonDeleteDataClient.BackColor = ColorTranslator.FromHtml("#B3F4E9");
            buttonCreateNewClient.BackColor = ColorTranslator.FromHtml("#B3F4E9");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteDataClient_Click(object sender, EventArgs e)
        {
            int clientID = 0;
            try
            {
                // Создаем объект подключения к базе данных
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();

                    SqlCommand sqlQuery = new SqlCommand("SELECT UsersID FROM [Users] WHERE UsersFullName = @ClientFullName", connection);
                    sqlQuery.Parameters.AddWithValue("@ClientFullName", textBoxFIODeleteClient.Text);

                    // Выполняем запрос и получаем ID
                    try
                    {
                        clientID = (int)sqlQuery.ExecuteScalar();

                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Ошибка при удалении пользователя. Такой пользователь не найден!");

                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при удалении пользователя. Такой пользователь не найден!");
                    }


                    // Если пользователь найден, создаем запрос на удаление его записи
                    if (clientID != 0)
                    {
                        SqlCommand deleteQuery = new SqlCommand("DELETE FROM [Users] WHERE UsersID = @clientID", connection);
                        deleteQuery.Parameters.AddWithValue("@clientID", clientID);
                        deleteQuery.ExecuteNonQuery();

                        MessageBox.Show("Пользователь успешно удален из БД!");
                    }

                }
            }
            catch (System.NullReferenceException)
            {
                // Обработка исключения
                MessageBox.Show("Ошибка при удалении пользователя. Такой пользователь не найден!");
            }
        }

        private void buttonClientWomen_Click(object sender, EventArgs e) { Classes.Documentation.DocumentAllWomen(); }
        private void buttonClientMen_Click(object sender, EventArgs e) { Classes.Documentation.DocumentAllMen(); }
        private void buttonAlClient_Click(object sender, EventArgs e) { Classes.Documentation.DocumentAllUsers(); }
        private void buttonAllAdmin_Click(object sender, EventArgs e) { Classes.Documentation.DocumentAllAdmin(); }
        private void buttonAllManager_Click(object sender, EventArgs e) { Classes.Documentation.DocumentAllManager(); }
        private void buttonAllClientSaloon_Click(object sender, EventArgs e) { Classes.Documentation.DocumentAllClient(); }
    }
}
