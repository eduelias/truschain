using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TrusChain_v2.Forms
{
    /// <summary>
    /// Interaction logic for AskInfo.xaml
    /// </summary>
    public partial class AskInfo : Window
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public AskInfo()
        {
            InitializeComponent();
        }

        public AskInfo(string title, string question)
        {
            Question = question;
        }

        private void BtCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
