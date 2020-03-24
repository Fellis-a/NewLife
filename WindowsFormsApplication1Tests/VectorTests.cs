using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void VectorTest()
        {
            var firstVector = new Vector(2,3,2);
            var secondVector = new Vector(1,2,1);

            var resultVector = firstVector + secondVector;
            
            Assert.AreEqual(resultVector,);

        }
    }
}