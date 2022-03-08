using KataFizzBuzz;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz fb;
        ArrayList list;

        [SetUp]
        public void SetUp()
        {
            fb = new FizzBuzz();
            list = fb.GetList();
        }
        [Test]
        public void ShouldReturn1WhenNumberIs1()
        {   
            Assert.AreEqual(1, list[0]);
        }

        [Test]
        public void ShouldReturnFizzWhenNumberIs3()
        {            
            Assert.AreEqual("Fizz", list[2]);
        }

        [Test]
        public void ShoulReturnBuzzWhenNumberIs5()
        {            
            Assert.AreEqual("Buzz", list[4]);
        }

        [Test]
        public void ShouldReturnFizzBuzzWhenNumberIs15()
        {            
            Assert.AreEqual("FizzBuzz", list[14]);
        }
        
        [Test]
        public void TestValuesFrom1To20()
        {
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual("Fizz", list[2]);
            Assert.AreEqual(4, list[3]);
            Assert.AreEqual("Buzz", list[4]);
            Assert.AreEqual("Fizz", list[5]);
            Assert.AreEqual(7, list[6]);
            Assert.AreEqual(8, list[7]);
            Assert.AreEqual("Fizz", list[8]);
            Assert.AreEqual("Buzz", list[9]);
            Assert.AreEqual(11, list[10]);
            Assert.AreEqual("Fizz", list[11]);
            Assert.AreEqual(13, list[12]);
            Assert.AreEqual(14, list[13]);
            Assert.AreEqual("FizzBuzz", list[14]);
            Assert.AreEqual(16, list[15]);
            Assert.AreEqual(17, list[16]);
            Assert.AreEqual("Fizz", list[17]);
            Assert.AreEqual(19, list[18]);
            Assert.AreEqual("Buzz", list[19]);            
        }
    }
}
