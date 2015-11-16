using System;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVC4WebApi.Tests.LoggerTest
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]
        public void TestMethod1()
        {
            string form = String.Format("ERROR OCCURRED IN {0}  STACK TRACE IS {1} MESSAGE  IS {2} ",
                "decideUpdateOrCreate", "test", "DEBUG");
            logger.Debug(form);

        }
    }
}
