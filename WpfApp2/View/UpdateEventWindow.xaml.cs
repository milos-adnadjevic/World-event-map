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
    /// Interaction logic for UpdateEventWindow.xaml
    /// </summary>
    public partial class UpdateEventWindow : Window,INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        public List<string> states = new List<string> { "Serbia", "Montenegro", "Russia" };

        public List<string> cities = new List<string> { "Ruma", "Novi Sad", "Budva", "Moskva" };

        public List<string> capacities = new List<string> { "0-1000", "1000-5000", "5000-10000", "10000+" };

        public static EventTagController eventTagController = new EventTagController();

        public static EventTypeController eventTypeController = new EventTypeController();

        public EventController eventController = new EventController();

        public List<string> eventTagsNames = eventTagController.GetEventTagNames();
        public List<string> eventTypesNames = eventTypeController.GetEventTypeNames();

        public UpdateEventWindow(string id, string name, string type, string organizationFee, string capacity, string state, string city, string ticketPrice, string date, bool humanitarian, string description, string tag)
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            StateBinding.ItemsSource = states;
            CityBinding.ItemsSource = cities;
            TypeBinding.ItemsSource = eventTypesNames;
            TagBinding.ItemsSource = eventTagsNames;
            CapacityBinding.ItemsSource = capacities;
            _idValidation = id;
            _nameValidation = name;
            if (eventTypeController.GetByName(type) != null) { TypeBinding.SelectedValue = (eventTypeController.GetByName(type)).Name; } else { TypeBinding.SelectedValue = type; }
            
            _organizationFeeValidation = Double.Parse(organizationFee);
            CapacityBinding.SelectedValue=capacity;
            StateBinding.SelectedValue = state;
            CityBinding.SelectedValue = city;
            _ticketValidation = Double.Parse(ticketPrice);
            DateBinding.Text = date;
            HumanitarianBinding.IsChecked = humanitarian;
            DescriptionBinding.Text = description;
            if (eventTagController.GetByName(tag) != null) { TagBinding.SelectedValue = (eventTagController.GetByName(tag)).Name; } else { TagBinding.SelectedValue = tag; }
            
        }
            


        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EventIdBinding.Text) || string.IsNullOrEmpty(EventNameBinding.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Event events = new Event();
            events.Id = EventIdBinding.Text;
            events.Name = EventNameBinding.Text;
            events.Type = eventTypeController.GetByName((string)TypeBinding.SelectedValue);
            events.OrganizationFee = Double.Parse(OrganizationFeeBinding.Text);
            events.City = (string)CityBinding.SelectedValue;
            events.State = (string)StateBinding.SelectedValue;
            events.Date = DateTime.Parse(DateBinding.Text);
            events.TicketPrice = Double.Parse(TicketPriceBinding.Text);
            events.Humanitarian = (bool)HumanitarianBinding.IsChecked;
            events.Description = DescriptionBinding.Text;
            events.Tag = eventTagController.GetByName((string)TagBinding.SelectedValue);
            events.ImagePath = events.Type.ImagePath;
            events.Capacity = (string)CapacityBinding.SelectedValue;

            eventController.Update(events);

            AllEvents allEvents=new AllEvents();
            allEvents.Show();
            this.Close();
            

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

        private double _organizationFeeValidation;


        public double OrganizationFeeValidation
        {
            get { return _organizationFeeValidation; }
            set
            {
                if (value != _organizationFeeValidation)
                {
                    _organizationFeeValidation = value;
                    OnPropertyChanged("OrganizationFeeValidation");


                }
            }
        }

        private string _idValidation;


        public string IdValidation
        {
            get { return _idValidation; }
            set
            {
                if (value != _idValidation)
                {
                    _idValidation = value;
                    OnPropertyChanged("IdValidation");


                }
            }
        }

        private double _capacityValidation;


        public double CapacityValidation
        {
            get { return _capacityValidation; }
            set
            {
                if (value != _capacityValidation)
                {
                    _capacityValidation = value;
                    OnPropertyChanged("CapacityValidation");


                }
            }
        }

        private double _ticketValidation;


        public double TicketValidation
        {
            get { return _ticketValidation; }
            set
            {
                if (value != _ticketValidation)
                {
                    _ticketValidation = value;
                    OnPropertyChanged("TicketValidation");


                }
            }
        }

        private string _nameValidation;


        public string NameValidation
        {
            get { return _nameValidation; }
            set
            {
                if (value != _nameValidation)
                {
                    _nameValidation = value;
                    OnPropertyChanged("NameValidation");


                }
            }
        }


        private string _idTagValidation;


        public string IdTagValidation
        {
            get { return _idTagValidation; }
            set
            {
                if (value != _idTagValidation)
                {
                    _idTagValidation = value;
                    OnPropertyChanged("IdTagValidation");


                }
            }
        }
    }
}
