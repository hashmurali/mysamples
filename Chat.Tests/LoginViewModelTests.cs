using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chat.Interfaces;
using Chat.ViewModels;
using System.Threading.Tasks;
using Chat.Utility;

namespace Chat.Tests
{
    [TestClass]
    public class LoginViewModelTests
    {
        LoginViewModel loginViewModel;
        ISettings settings;
       
        [ClassInitialize]
        public void SetUp(TestContext context)
        {
            Test.SetUp();
            settings = ServiceContainer.Resolve<ISettings>();
            loginViewModel = new LoginViewModel();
        }
        [TestMethod]
        public async Task LoginSuccessfully()
        {
            loginViewModel.Username = "testuser";
            loginViewModel.Password = "password";
            await loginViewModel.Login();
            Assert.IsNotNull(settings.User);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public async Task LoginWithNoUsernameOrPassword()
        {
            //Throws an exception
            await loginViewModel.Login();
        }
    }
}
