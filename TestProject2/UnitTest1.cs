using TestProject2.Test;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmailAndPassIsEmptyOrNot()      //проверка поиска введенного логина и пароля
        {
            string emailData = "userEmail2";
            string passwsordData = "passwordUser2";
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.EmailAndPasswordIsEmpty(emailData, passwsordData);
        }

        [Test]
        public void EmailAndPassIsNotCorrect()      //проверка поиска введенного логина и пароля, анные введены неверные, но есть исключение об ошиюки - тест будет выполнен
        {
            string emailData = "randomUserEmail";
            string passwsordData = "noCorrectPass";
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.EmailAndPasswordIsEmpty(emailData, passwsordData);
        }

        [Test]
        public void PassIsNotCorrect()      //проверка поиска введенного логина и пароля, Почта - верна, пароль - нет, но есть исключение об ошиюки - тест будет выполнен, так как общая проверка
        {
            string emailData = "randomUserEmail";
            string passwsordData = "noCorrectPass";
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.EmailAndPasswordIsEmpty(emailData, passwsordData);
        }


        [Test]
        public void DataAboutManagerSendToAnotherForms()        //Передача ID менеджера с одной формы на другую
        {
            int manid = 1;
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.SendDataAboutManagerFromAnotherForm();
            forTestingData.AcceptDataAboutManager(manid);
        }

        [Test]
        public void DataAboutClientSendToAnotherForms()     //Передача ID клиента с одной формы на другую
        {
            int clid = 1;
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.SendDataAboutClientFromAnotherForm();
            forTestingData.AcceptDataAboutClient(clid);
        }

        
    }
}