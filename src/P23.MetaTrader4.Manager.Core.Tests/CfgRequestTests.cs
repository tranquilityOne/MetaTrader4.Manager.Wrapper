﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using P23.MetaTrader4.Manager.Tests.Helpers;

namespace P23.MetaTrader4.Manager.Tests
{
    public class CfgRequestTests
    {
        [TestMethod]
        public void CfgRequestSymbol_Invoke_SymbolConfigurationsReturned()
        {
            using (var mt = TestHelpers.CreateWrapper())
            {
                var configs = mt.CfgRequestSymbol();
                Assert.IsTrue(configs.Count > 0);
            }
        }

        [TestMethod]
        public void CfgRequestSymbolGroup_Invoke_SymbolGroupsReturned()
        {
            using (var mt = TestHelpers.CreateWrapper())
            {
                var configs = mt.CfgRequestSymbolGroup();
                Assert.IsTrue(configs.Count > 0);
                Assert.IsFalse(string.IsNullOrEmpty(configs[0].Name));
            }
        }
    }
}