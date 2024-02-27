using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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
using WpfApp2.Model;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for AboutEvent.xaml
    /// </summary>
    public partial class AboutEvent : Window
    {
        public AboutEvent(string id, string name, string type, string organizationFee, string capacity,string state, string city, string ticketPrice, string date,bool humanitarian ,string description ,string tag )
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation=WindowStartupLocation.CenterScreen;
            EventIdBinding.Text= id;
            EventNameBinding.Text= name;
            TypeBinding.Text= type;
            OrganizationFeeBinding.Text= organizationFee;
            CapacityBinding.Text= capacity;
            StateBinding.Text= state;
            CityBinding.Text= city;
            TicketPriceBinding.Text= ticketPrice;
            DateBinding.Text= date;
            HumanitarianBinding.IsChecked= humanitarian;
            DescriptionBinding.Text= description;
            TagBinding.Text= tag;
        }

        public AboutEvent(Event e)
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            EventIdBinding.Text =e.Id;
            EventNameBinding.Text = e.Name;
            TypeBinding.Text = e.Type.Name;
            OrganizationFeeBinding.Text = e.OrganizationFee.ToString();
            CapacityBinding.Text = e.Capacity.ToString();
            StateBinding.Text = e.State;
            CityBinding.Text = e.City;
            TicketPriceBinding.Text = e.TicketPrice.ToString();
            DateBinding.Text = e.Date.ToString();
            HumanitarianBinding.IsChecked = e.Humanitarian;
            DescriptionBinding.Text = e.Description;
            TagBinding.Text = e.Tag.Name;
        }


        private void CreateEventTagWindow(object sender, RoutedEventArgs e)
        {
            CreateEventTag createEventTagWindow = new CreateEventTag();
            createEventTagWindow.Show();
            this.Close();
        }

        private void CreateEventTypeWindow(object sender, RoutedEventArgs e)
        {
            CreateEventType createEventType = new CreateEventType();
            createEventType.Show();
            this.Close();
        }

        private void CreateEventWindow(object sender, RoutedEventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Close();
        }

        private void AllEventsWindow(object sender, RoutedEventArgs e)
        {
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
            this.Close();

        }

        private void HomeWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void EditWindow(object sender, RoutedEventArgs e)
        {

        }

        private void HelpWindow(object sender, RoutedEventArgs e)
        {
            HelpPopUpWindow helpPopUpWindow = new HelpPopUpWindow();
            helpPopUpWindow.Show();

        }
        private void Delete(object sender, RoutedEventArgs e)
        {

        }
        private void MapWindow(object sender, RoutedEventArgs e)
        {
            MapWindow mapWindow = new MapWindow();
            mapWindow.Show();
            this.Close();
        }
    }
}
