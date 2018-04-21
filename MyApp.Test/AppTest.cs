using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.test
{
    [TestFixture]
    public class AppTest
    {
        List<EmployeeDetails> employees;

        [Test]
        public void CheckDetails()
        {
            Program p = new Program();
            employees = p.AllUsers();
            foreach (var employee in employees)
            {
                Assert.IsNotNull(employee.id);
                Assert.IsNotNull(employee.Name);
                Assert.IsNotNull(employee.salary);
                Assert.IsNotNull(employee.Geneder);
            }
        }

        [Test]
        public void TestLogin()
        {
            Program p = new Program();
            string log1 = p.Login("", "");
            string log2 = p.Login("wrong", "noway");
            string log3 = p.Login("Admin", "Admin");
            Assert.AreEqual("Userid or password could not be Empty.", log1);
            Assert.AreEqual("Incorrect UserId or Password.", log2);
            Assert.AreEqual("Welcome Admin.", log3);
        }
    }
}
