using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceoK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }
    }
}
