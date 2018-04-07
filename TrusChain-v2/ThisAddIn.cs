using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using IdentityService.KeyHandler;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Ninject;
using ServicesDefinitions.Interfaces;
using System.Collections.ObjectModel;
using Microsoft.Office.Tools.Ribbon;
using ServicesDefinitions.Models;

namespace TrusChain_v2
{
    public partial class ThisAddIn
    {
        public static readonly StandardKernel _kernel = new StandardKernel();

        public static readonly ObservableCollection<KeyPair> Wallets = new ObservableCollection<KeyPair>();
        public static BCMenu Menu;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Wallets.CollectionChanged += (o, args) =>
            {
                Menu.WalletCombo.Items.Clear();
                foreach (var keyPair in Wallets)
                {
                    RibbonDropDownItem item = Menu.Factory.CreateRibbonDropDownItem();
                    item.Label = keyPair.Address;
                    Menu.WalletCombo.Items.Add(item);
                }

                Menu.WalletCombo.Text = Menu.WalletCombo.Items.Last().Label;
            };
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            _kernel.Dispose();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);

            _kernel.Bind<IKeyGeneration>().To<KeyGeneration>().InSingletonScope();
        }
        
        #endregion
    }
}
