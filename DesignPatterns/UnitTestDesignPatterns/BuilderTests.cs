using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleBuilder;

namespace UnitTestDesignPatterns
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void SandwichCreateTest()
        {
            Sandwich sandwich = new Sandwich();
            Assert.IsInstanceOfType(sandwich, typeof(Sandwich));
        }

        [TestMethod]
        public void TurkeySandwichBuilderCreateTest()
        {
            TurkeySandwichBuilder builder = new TurkeySandwichBuilder();
            Assert.IsInstanceOfType(builder, typeof(TurkeySandwichBuilder));
            Assert.IsInstanceOfType(builder, typeof(SandwichBuilder));
        }

        [TestMethod]
        public void MeatBallSandwichBuilderCreateTest()
        {
            MeatBallSandwichBuilder builder = new MeatBallSandwichBuilder();
            Assert.IsInstanceOfType(builder, typeof(MeatBallSandwichBuilder));
            Assert.IsInstanceOfType(builder, typeof(SandwichBuilder));
        }

        [TestMethod]
        public void SandwichMachineCreateTest()
        {
            SandwichMachine machine = new SandwichMachine();
            Assert.IsInstanceOfType(machine, typeof(SandwichMachine));
        }

        [TestMethod]
        public void TurkeySandwichMachineTest()
        {
            SandwichMachine machine = new SandwichMachine();
            Sandwich sandwich = machine.CreateSandwich(new TurkeySandwichBuilder());
            Assert.AreEqual(String.Format("{0} with {1} on {2} bread", "Sliced Turkey", "Mayonaise", "White"), sandwich.ToString());
        }

        [TestMethod]
        public void MeatballSandwichMachineTest()
        {
            SandwichMachine machine = new SandwichMachine();
            Sandwich sandwich = machine.CreateSandwich(new MeatBallSandwichBuilder());
            Assert.AreEqual(String.Format("{0} with {1} on {2} bread", "Meatballs", "Tomato Sauce", "Italian"), sandwich.ToString());
        }
    }
}
