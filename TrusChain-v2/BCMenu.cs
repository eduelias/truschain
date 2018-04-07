using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using Ninject;
using ServicesDefinitions.Interfaces;
using TrusChain_v2.Forms;

namespace TrusChain_v2
{
    public partial class BCMenu : IDisposable
    {
        public Application application;

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

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            var priv = ThisAddIn.Wallets.FirstOrDefault(x => x.Address == ThisAddIn.Menu.WalletCombo.Text);

            if (priv == null) return;

            var actdoc = this.application.ActiveDocument.FullName;

            var plainFile = $"{this.application.ActiveDocument.FullName}";

            this.application.ActiveDocument.Close();

            string address = "net.pipe://localhost/ShareFileService";
 
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IServiceContract channel = ChannelFactory<IServiceContract>.CreateChannel(binding, ep);

            channel.ShareFile(plainFile, "pepito", "Marianico");

            this.application.Documents.Open(plainFile);

            var w = new AskInfo()
            {
                Title = "Paste your private key"
            };

            w.BtOk.Click += (o, args) =>
            {
                w.Close();
            };
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}
