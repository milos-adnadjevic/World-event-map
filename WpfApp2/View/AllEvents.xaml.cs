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
using WpfApp2.Controller;
using DocumentFormat.OpenXml.Drawing;
using System.Data;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for AllEvents.xaml
    /// </summary>
    public partial class AllEvents : Window
    {
        public static EventController eventController= new EventController();
        ICollection<Event> allEvents = eventController.GetAll();
        public Event selectedEvent= new Event();








        public AllEvents()
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AllEventsBinding.ItemsSource = allEvents;
          
        }

        public AllEvents(List<Event> searchedEvents)
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AllEventsBinding.ItemsSource = searchedEvents;
            
        }


        private void AllEventsBinding_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            selectedEvent =(Event) AllEventsBinding.SelectedItem;

            string id= selectedEvent.Id;
            string name=selectedEvent.Name;
            string type = selectedEvent.Type.Name;
            string organizationFee = selectedEvent.OrganizationFee.ToString();
            string capacity = selectedEvent.Capacity;
            string state= selectedEvent.State;
            string city = selectedEvent.City;
            string ticketPrice = selectedEvent.TicketPrice.ToString();
            string date=selectedEvent.Date.ToString();
            bool humanitarian = selectedEvent.Humanitarian;
            string description = selectedEvent.Description;
            string tag = selectedEvent.Tag.Name;

            AboutEvent aboutevent=new AboutEvent (id,name,type,organizationFee,capacity,state,city,ticketPrice,date,humanitarian,description,tag);
            aboutevent.Show ();
            this.Close();

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();
        }

        public void getSearchedParametars(string name, string type, string description, string capacity)
        {
            if (capacity == null) capacity = "";
            
            List<Event> searchedEvents=eventController.Search(name, type, description, capacity);   
            if (searchedEvents != null)
            {
                AllEventsBinding.ItemsSource = searchedEvents;
              
            }
            else
            {
                List<Event> nullEvents = new List<Event>() { };
                AllEventsBinding.ItemsSource = nullEvents;
                
            }
        }

        public void afterDelete()
        {
            AllEventsBinding.ItemsSource = eventController.GetAll();
        }



        private void FilterBinding_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filteredText=FilterBinding.Text;
            List<Event> filteredEvents = eventController.Filter(filteredText);
            if (filteredEvents != null)
            {
                AllEventsBinding.ItemsSource = filteredEvents;
            }
            else
            {
                List<Event> nullEvents = new List<Event>() { };
                AllEventsBinding.ItemsSource = nullEvents;
            }
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
            selectedEvent = (Event)AllEventsBinding.SelectedItem;
            if (selectedEvent == null) { return; }
            string id = selectedEvent.Id;
            string name = selectedEvent.Name;
            string type = selectedEvent.Type.Name;
            string organizationFee = selectedEvent.OrganizationFee.ToString();
            string capacity = selectedEvent.Capacity;
            string state = selectedEvent.State;
            string city = selectedEvent.City;
            string ticketPrice = selectedEvent.TicketPrice.ToString();
            string date = selectedEvent.Date.ToString();
            bool humanitarian = selectedEvent.Humanitarian;
            string description = selectedEvent.Description;
            string tag = selectedEvent.Tag.Name;

            UpdateEventWindow updateEventWindow = new UpdateEventWindow(id, name, type, organizationFee, capacity, state, city, ticketPrice, date, humanitarian, description, tag);
            updateEventWindow.Show();
            this.Close();

        }

        private void HelpWindow(object sender, RoutedEventArgs e)
        {
            HelpPopUpWindow helpPopUpWindow = new HelpPopUpWindow();
            helpPopUpWindow.Show();
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            selectedEvent = (Event)AllEventsBinding.SelectedItem;
            if (selectedEvent == null) { return; }
            this.IsEnabled = false;
           
            DeleteConfirm deleteConfirm = new DeleteConfirm(selectedEvent.Id);
            deleteConfirm.Show();
           

        }
        private void MapWindow(object sender, RoutedEventArgs e)
        {
            MapWindow mapWindow = new MapWindow();
            mapWindow.Show();
            this.Close();
        }

        private void AllTags_Click(object sender, RoutedEventArgs e)
        {
            AllTags allTags=new AllTags();
            allTags.Show();
            this.Close();
        }

        private void AllTypes_Click(object sender, RoutedEventArgs e)
        {
            AllTypes allTypes=new AllTypes();
            allTypes.Show();
            this.Close();
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
