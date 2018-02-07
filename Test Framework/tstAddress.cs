using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of our class address
            clsAddress AnAddress = new clsAddress();
            //check to see that the class is not null
            Assert.IsNotNull(AnAddress);
        }
    }
}
