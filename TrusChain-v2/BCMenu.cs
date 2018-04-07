using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using Ninject;
using ServicesDefinitions.Interfaces;
using TrusChain_v2.Forms;

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
            var w = new AskInfo()
            {
                Title = "Input password",
                Question = "Choose a password"
            };

            w.BtOk.Click += (o, args) =>
            {
                if (string.IsNullOrEmpty(w.Answer))
                    return;
                var kGen = ThisAddIn._kernel.Get<IKeyGeneration>();
                var account = kGen.GenerateNewWallet(w.Answer);

                ThisAddIn.Wallets.Add(account);
                w.Close();
            };

            w.ShowDialog();
        }

        private void ImportBtn_Click(object sender, RibbonControlEventArgs e)
        {
            var w = new AskInfo()
            {
                Title = "Paste your private key",
                Question = "Paste your private key"
            };

            w.BtOk.Click += (o, args) =>
            {
                if (string.IsNullOrEmpty(w.Answer))
                    return;
                var kGen = ThisAddIn._kernel.Get<IKeyGeneration>();
                var account = kGen.GenerateNewWallet(w.Answer);

                ThisAddIn.Wallets.Add(account);
                w.Close();
            };

            w.ShowDialog();
        }
    }
}
