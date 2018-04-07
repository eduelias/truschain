using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Ninject;
using ServicesDefinitions.Interfaces;

namespace TrusChain_v2
{
    public partial class BCMenu
    {
        private void BCMenu_Load(object sender, RibbonUIEventArgs e)
        {
            ThisAddIn.Menu = this;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            var kGen = ThisAddIn._kernel.Get<IKeyGeneration>();
            var account = kGen.GenerateNewWallet("123");

            ThisAddIn.Wallets.Add(account);
        }
    }
}
