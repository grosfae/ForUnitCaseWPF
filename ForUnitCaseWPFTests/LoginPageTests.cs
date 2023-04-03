using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForUnitCaseWPF.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForUnitCaseWPFTests.Model;

namespace ForUnitCaseWPF.Pages.Tests
{
    [TestClass()]
    public class LoginPageTests
    {
        [TestMethod()]
        public void LoginPageTest()
        {
            ApishkaEntities DB = new ApishkaEntities();
            string log = "W3";
            string pass = "123";
            var userCheck = DB.User.Where(x => x.Login == log & x.Password == pass).First();
            Assert.IsTrue(userCheck != null);
            //Assert.Fail();
        }
    }
}