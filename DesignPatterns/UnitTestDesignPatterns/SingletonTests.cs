using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleSingleton;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonCreateTest()
        {
            SingletonClass singleton = SingletonClass.GetInstance();
            Assert.IsInstanceOfType(singleton, typeof(SingletonClass));
        }

        [TestMethod]
        public void SingletonInstanceMatchTest()
        {
            SingletonClass singleton1 = SingletonClass.GetInstance();
            SingletonClass singleton2 = SingletonClass.GetInstance();
            Assert.AreSame(singleton1, singleton2);
        }

        [TestMethod]
        public void SingletonInstanceValuesMatchTest()
        {
            SingletonClass singleton1 = SingletonClass.GetInstance();
            SingletonClass singleton2 = SingletonClass.GetInstance();
            Assert.AreEqual(singleton1.GetValue(), singleton2.GetValue());
        }
    }
}
