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
        public void EmailAndPassIsEmptyOrNot()      //�������� ������ ���������� ������ � ������
        {
            string emailData = "userEmail2";
            string passwsordData = "passwordUser2";
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.EmailAndPasswordIsEmpty(emailData, passwsordData);
        }

        [Test]
        public void EmailAndPassIsNotCorrect()      //�������� ������ ���������� ������ � ������, ����� ������� ��������, �� ���� ���������� �� ������ - ���� ����� ��������
        {
            string emailData = "randomUserEmail";
            string passwsordData = "noCorrectPass";
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.EmailAndPasswordIsEmpty(emailData, passwsordData);
        }

        [Test]
        public void PassIsNotCorrect()      //�������� ������ ���������� ������ � ������, ����� - �����, ������ - ���, �� ���� ���������� �� ������ - ���� ����� ��������, ��� ��� ����� ��������
        {
            string emailData = "randomUserEmail";
            string passwsordData = "noCorrectPass";
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.EmailAndPasswordIsEmpty(emailData, passwsordData);
        }


        [Test]
        public void DataAboutManagerSendToAnotherForms()        //�������� ID ��������� � ����� ����� �� ������
        {
            int manid = 1;
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.SendDataAboutManagerFromAnotherForm();
            forTestingData.AcceptDataAboutManager(manid);
        }

        [Test]
        public void DataAboutClientSendToAnotherForms()     //�������� ID ������� � ����� ����� �� ������
        {
            int clid = 1;
            ForTestingData forTestingData = new ForTestingData();
            forTestingData.SendDataAboutClientFromAnotherForm();
            forTestingData.AcceptDataAboutClient(clid);
        }

        
    }
}