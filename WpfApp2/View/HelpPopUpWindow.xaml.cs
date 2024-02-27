using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for HelpPopUpWindow.xaml
    /// </summary>
    public partial class HelpPopUpWindow : Window
    {
        public HelpPopUpWindow()
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation=WindowStartupLocation.CenterScreen;
        }

        private void MoreHelp_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow= new HelpWindow();
            helpWindow.Show();
            for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
            {
                if (App.Current.Windows[intCounter]!=helpWindow)
                App.Current.Windows[intCounter].Close();
            }
                    
           
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
