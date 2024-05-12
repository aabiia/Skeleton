using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstsanceOK()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull( AnStock );
        }
    }
}
