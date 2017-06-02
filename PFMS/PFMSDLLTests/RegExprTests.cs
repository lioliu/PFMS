using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFMSDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PFMSDLL.Tests
{
    [TestClass()]
    public class RegExprTests
    {
        [TestMethod()]
        public void CheckPassWordTest()
        {
            
            Assert.AreEqual(2, RegExpr.CheckPassWord("1q2w3e4r5t6y7u8i9o0p"));
        }
    }
}