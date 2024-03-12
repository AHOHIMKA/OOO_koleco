using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_koleco.Classes
{
    public class Documentation
    {
        public static void DocumentAllWomen()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();



                    SqlCommand sqlQuery = new SqlCommand(@"
                    Select Users.UsersFullName,Users.UsersEmail,Role.RoleName,Users.UsersPol
                    From Role inner join Users on Role.RoleID = Users.UsersRole where Users.UsersPol = 'Ж'", connection);


                    // Создаем объект для записи в файл
                    using (StreamWriter writer = new StreamWriter("Все клиенты в базе - женщины.txt"))
                    {
                        // Выполняем запрос и считываем результаты
                        using (SqlDataReader reader = sqlQuery.ExecuteReader())
                        {
                            // Проверяем, есть ли данные для чтения
                            if (reader.HasRows)
                            {
                                // Читаем данные построчно
                                while (reader.Read())
                                {
                                    // Формируем строку с данными
                                    string row = $"ФИО клиента: {reader["UsersFullName"]}\n " +
                                                 $"Почта: {reader["UsersEmail"]}\n " +
                                                 $"Роль: {reader["RoleName"]}\n " +
                                                 $"Пол: {reader["UsersPol"]}\n\n ";

                                    // Записываем строку в файл
                                    writer.WriteLine(row);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Информация о клиентах женского пола сохранена была в текстовый файл -> 'Все клиенты в базе - женщины.txt'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public static void DocumentAllMen()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();



                    SqlCommand sqlQuery = new SqlCommand(@"
                    Select Users.UsersFullName,Users.UsersEmail,Role.RoleName,Users.UsersPol
                    From Role inner join Users on Role.RoleID = Users.UsersRole where Users.UsersPol = 'М'", connection);


                    // Создаем объект для записи в файл
                    using (StreamWriter writer = new StreamWriter("Все клиенты в базе - мужчины.txt"))
                    {
                        // Выполняем запрос и считываем результаты
                        using (SqlDataReader reader = sqlQuery.ExecuteReader())
                        {
                            // Проверяем, есть ли данные для чтения
                            if (reader.HasRows)
                            {
                                // Читаем данные построчно
                                while (reader.Read())
                                {
                                    // Формируем строку с данными
                                    string row = $"ФИО клиента: {reader["UsersFullName"]}\n " +
                                                 $"Почта: {reader["UsersEmail"]}\n " +
                                                 $"Роль: {reader["RoleName"]}\n " +
                                                 $"Пол: {reader["UsersPol"]}\n\n ";

                                    // Записываем строку в файл
                                    writer.WriteLine(row);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Информация о клиентах мужского пола сохранена была в текстовый файл -> 'Все клиенты в базе - мужчины.txt'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        public static void DocumentAllUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();



                    SqlCommand sqlQuery = new SqlCommand(@"
                    Select Users.UsersFullName,Users.UsersEmail,Role.RoleName,Users.UsersPol
                    From Role inner join Users on Role.RoleID = Users.UsersRole", connection);


                    // Создаем объект для записи в файл
                    using (StreamWriter writer = new StreamWriter("Все клиенты в базе.txt"))
                    {
                        // Выполняем запрос и считываем результаты
                        using (SqlDataReader reader = sqlQuery.ExecuteReader())
                        {
                            // Проверяем, есть ли данные для чтения
                            if (reader.HasRows)
                            {
                                // Читаем данные построчно
                                while (reader.Read())
                                {
                                    // Формируем строку с данными
                                    string row = $"ФИО клиента: {reader["UsersFullName"]}\n " +
                                                 $"Почта: {reader["UsersEmail"]}\n " +
                                                 $"Роль: {reader["RoleName"]}\n " +
                                                 $"Пол: {reader["UsersPol"]}\n\n ";

                                    // Записываем строку в файл
                                    writer.WriteLine(row);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Информация о клиентах сохранена была в текстовый файл -> 'Все клиенты в базе.txt'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public static void DocumentAllAdmin()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();



                    SqlCommand sqlQuery = new SqlCommand(@"
                    Select Users.UsersFullName,Users.UsersEmail,Role.RoleName,Users.UsersPol
                    From Role inner join Users on Role.RoleID = Users.UsersRole where Role.RoleName= 'Администратор'", connection);


                    // Создаем объект для записи в файл
                    using (StreamWriter writer = new StreamWriter("Все в базе 'Администратор'.txt"))
                    {
                        // Выполняем запрос и считываем результаты
                        using (SqlDataReader reader = sqlQuery.ExecuteReader())
                        {
                            // Проверяем, есть ли данные для чтения
                            if (reader.HasRows)
                            {
                                // Читаем данные построчно
                                while (reader.Read())
                                {
                                    // Формируем строку с данными
                                    string row = $"ФИО администратора: {reader["UsersFullName"]}\n " +
                                                 $"Почта: {reader["UsersEmail"]}\n " +
                                                 $"Роль: {reader["RoleName"]}\n " +
                                                 $"Пол: {reader["UsersPol"]}\n\n ";

                                    // Записываем строку в файл
                                    writer.WriteLine(row);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Информация о пользователях с ролью 'Администратор' сохранена была в текстовый файл -> 'Все в базе 'Администратор'.txt'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        public static void DocumentAllManager()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();



                    SqlCommand sqlQuery = new SqlCommand(@"
                    Select Users.UsersFullName,Users.UsersEmail,Role.RoleName,Users.UsersPol
                    From Role inner join Users on Role.RoleID = Users.UsersRole where Role.RoleName= 'Менеджер'", connection);


                    // Создаем объект для записи в файл
                    using (StreamWriter writer = new StreamWriter("Все в базе 'Менеджер'.txt"))
                    {
                        // Выполняем запрос и считываем результаты
                        using (SqlDataReader reader = sqlQuery.ExecuteReader())
                        {
                            // Проверяем, есть ли данные для чтения
                            if (reader.HasRows)
                            {
                                // Читаем данные построчно
                                while (reader.Read())
                                {
                                    // Формируем строку с данными
                                    string row = $"ФИО менеджера: {reader["UsersFullName"]}\n " +
                                                 $"Почта: {reader["UsersEmail"]}\n " +
                                                 $"Роль: {reader["RoleName"]}\n " +
                                                 $"Пол: {reader["UsersPol"]}\n\n ";

                                    // Записываем строку в файл
                                    writer.WriteLine(row);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Информация о пользователях с ролью 'Менеджер' сохранена была в текстовый файл -> 'Все в базе 'Менеджер'.txt'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        public static void DocumentAllClient()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MDL0KP2;Initial Catalog=OOO_Koleco;Integrated Security=True"))
                {
                    connection.Open();



                    SqlCommand sqlQuery = new SqlCommand(@"
                    Select Users.UsersFullName,Users.UsersEmail,Role.RoleName,Users.UsersPol
                    From Role inner join Users on Role.RoleID = Users.UsersRole where Role.RoleName= 'Клиент'", connection);


                    // Создаем объект для записи в файл
                    using (StreamWriter writer = new StreamWriter("Все в базе 'Клиент'.txt"))
                    {
                        // Выполняем запрос и считываем результаты
                        using (SqlDataReader reader = sqlQuery.ExecuteReader())
                        {
                            // Проверяем, есть ли данные для чтения
                            if (reader.HasRows)
                            {
                                // Читаем данные построчно
                                while (reader.Read())
                                {
                                    // Формируем строку с данными
                                    string row = $"ФИО клиента: {reader["UsersFullName"]}\n " +
                                                 $"Почта: {reader["UsersEmail"]}\n " +
                                                 $"Роль: {reader["RoleName"]}\n " +
                                                 $"Пол: {reader["UsersPol"]}\n\n ";

                                    // Записываем строку в файл
                                    writer.WriteLine(row);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Информация о пользователях с ролью 'Клиент' сохранена была в текстовый файл -> 'Все в базе 'Клиент'.txt'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
