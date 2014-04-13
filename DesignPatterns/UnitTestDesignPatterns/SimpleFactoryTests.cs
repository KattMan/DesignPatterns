using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleSimpleFactory;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class SimpleFactoryTests
    {
        [TestMethod]
        public void CollieDogCreateTest()
        {
            IDog dog = new Collie();
            Assert.IsInstanceOfType(dog, typeof(Collie));
        }

        [TestMethod]
        public void PoodleDogCreateTest()
        {
            IDog dog = new Poodle();
            Assert.IsInstanceOfType(dog, typeof(Poodle));
        }

        [TestMethod]
        public void WolfHoundDogCreateTest()
        {
            IDog dog = new Wolfhound();
            Assert.IsInstanceOfType(dog, typeof(Wolfhound));
        }

        [TestMethod]
        public void CollieDogBarkTest()
        {
            IDog dog = new Collie();
            String bark = dog.Bark();
            Assert.AreEqual("The Collie says Bark Bark", bark);
        }

        [TestMethod]
        public void PoodleDogBarkTest()
        {
            IDog dog = new Poodle();
            String bark = dog.Bark();
            Assert.AreEqual("The Poodle says Yip Yip", bark);
        }

        [TestMethod]
        public void WolfhoundDogBarkTest()
        {
            IDog dog = new Wolfhound();
            String bark = dog.Bark();
            Assert.AreEqual("The Wolfhound says Woof Woof", bark);
        }

        [TestMethod]
        public void DogFactoryCollieTest()
        {
            DogFactory dogFactory= new DogFactory();

            IDog d = dogFactory.GetDog(Dogs.Collie);

            Assert.IsInstanceOfType(d, typeof(Collie));
        }

        [TestMethod]
        public void DogFactoryPoodleTest()
        {
            DogFactory dogFactory = new DogFactory();

            IDog d = dogFactory.GetDog(Dogs.Poodle);

            Assert.IsInstanceOfType(d, typeof(Poodle));
        }

        [TestMethod]
        public void DogFactoryWolfhoundTest()
        {
            DogFactory dogFactory = new DogFactory();

            IDog d = dogFactory.GetDog(Dogs.Wolfhound);

            Assert.IsInstanceOfType(d, typeof(Wolfhound));
        }

        [TestMethod]
        public void DogFactoryNullTest()
        {
            DogFactory dogFactory = new DogFactory();

            IDog d = dogFactory.GetDog(Dogs.none);

            Assert.IsNull(d);
        }
    }
}
