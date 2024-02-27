using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp2.Controller;
using WpfApp2.Model;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public List<string> capacity = new List<string> { "0-1000", "1000-5000", "5000-10000", "10000+" };

        public EventController eventController = new EventController();
        public SearchWindow()
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            SearchCapacityBinding.ItemsSource = capacity;
        }

        

        private void Search_Click(object sender, RoutedEventArgs e)
        {
       

            string name = SearchNameBinding.Text;
            string type = SearchTypeBinding.Text;
            string description = SearchDescriptionBinding.Text;
            string capacity = (string) SearchCapacityBinding.SelectedValue;

            AllEvents allEvents = GetOpenResultWindow();
            if (allEvents == null)
            {
                allEvents = new AllEvents();
                allEvents.Show();
            }
            allEvents.getSearchedParametars(name, type, description, capacity);
            this.Close();


    

           

        }


        private AllEvents GetOpenResultWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is AllEvents resultWindow && resultWindow.IsVisible)
                {
                    return resultWindow;
                }
            }
            return null;
        }
        public bool demo = true;
        public bool stopMethod()
        {
            if (demo == false) { return true; }
            else { return false; }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                demo = false;
                mainWindow.StartDemo(demo);
                for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                {
                    if (App.Current.Windows[intCounter] != mainWindow) { App.Current.Windows[intCounter].Close(); }
                }





                e.Handled = true;
            }



        }





    }
}
