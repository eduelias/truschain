﻿namespace TrusChain_v2
{
    partial class BCMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public BCMenu()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.WalletCombo = this.Factory.CreateRibbonComboBox();
            this.button1 = this.Factory.CreateRibbonButton();
            this.ImportBtn = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.comboBox2 = this.Factory.CreateRibbonComboBox();
            this.button2 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TrusChain";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.WalletCombo);
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.ImportBtn);
            this.group1.Label = "Identity";
            this.group1.Name = "group1";
            // 
            // WalletCombo
            // 
            this.WalletCombo.Label = "Indentity";
            this.WalletCombo.Name = "WalletCombo";
            this.WalletCombo.Text = null;
            // 
            // button1
            // 
            this.button1.Label = "Add Identity";
            this.button1.Name = "button1";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.Label = "Import Id";
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ImportBtn_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.comboBox2);
            this.group2.Items.Add(this.button2);
            this.group2.Label = "File";
            this.group2.Name = "group2";
            // 
            // comboBox2
            // 
            this.comboBox2.Label = "Matter";
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Text = null;
            // 
            // button2
            // 
            this.button2.Label = "Save";
            this.button2.Name = "button2";
            this.button2.OfficeImageId = "FileSave";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // BCMenu
            // 
            this.Name = "BCMenu";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.BCMenu_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        public Microsoft.Office.Tools.Ribbon.RibbonComboBox WalletCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ImportBtn;
    }

    partial class ThisRibbonCollection
    {
        internal BCMenu BCMenu
        {
            get { return this.GetRibbon<BCMenu>(); }
        }
    }
}
