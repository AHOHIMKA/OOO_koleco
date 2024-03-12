using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOO_koleco;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HandleLoginAttempt_ValidPassword_ReturnsSuccessMessage()
        {
            // Arrange
            var form = new Form1();
            string login = "kirdmitriy@mail.ru";
            string password = "password2";
            

            // Act
            form.HandleLoginAttempt(login, password);

            // Assert
            Assert.IsTrue(form.SomeExpectedActionHappened());
        }
    }
}
