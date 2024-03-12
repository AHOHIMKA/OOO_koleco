using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Test
{
    internal class ForTestingData
    {

        public void EmailAndPasswordIsEmpty(string loginData, string passwsordData) //метод проверки на пустые данные в email или пароле
        {
            string login = loginData;
            string password = passwsordData;

            try
            {
                
                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) // Проверяет пустые ли строки
                {
                    throw new Exception("Необходимо ввести логин и пароль");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void SendDataAboutManagerFromAnotherForm()
        {
            int managerID = 1;
            AcceptDataAboutManager(managerID);
        }
        public void AcceptDataAboutManager(int managerID)
        {
            int manID = managerID;
            if (manID == managerID)
            {
                Message.Equals(true, managerID);
            }
        }

        public void SendDataAboutClientFromAnotherForm()
        {
            int ClientID = 1;
            AcceptDataAboutClient(ClientID);

        }
        public void AcceptDataAboutClient(int ClientID)
        {
            int clID = ClientID;
            if (clID == ClientID)
            {
                Message.Equals(true, ClientID);
            }
        }

        public void EmailandPassCorrectlyorNot(string loginData, string passwsordData) //Прворека есть ли данные польщователя или нет
        {
            DataUsers datausers = new DataUsers();

            try
            {
                if (!datausers.IsValidCredentials(loginData, passwsordData))
                {
                    throw new Exception("Пользователь не найден - нет такой комбинации логина и пароля");
                }
                else
                {
                    Console.WriteLine("Вход выполнен успешно!");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
