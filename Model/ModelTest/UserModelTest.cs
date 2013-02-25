using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace ModelTest
{
    [TestClass]
    public class UserModelTest
    {
        [TestMethod]
        public void TestUserListCreation()
        {
            User us = new User();
            Assert.IsTrue(us.UserList.Count<User>() > 0);
            var entry = from user in us.UserList
                         where user.ID == 1
                         select user;
            Assert.IsNotNull(entry);
            foreach (User user in entry)
            {
                Assert.IsTrue(user.ID == 1);
                Assert.IsTrue(user.FirstName == "John");
            }
        }
    }
}
