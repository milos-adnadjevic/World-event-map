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
    /// Interaction logic for CreateEvent.xaml
    /// </summary>
    public partial class CreateEvent : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool demo = true;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        public List<string> states = new List<string> { "Serbia", "Montenegro", "Russia" };

        public List<string> cities = new List<string> { "Ruma", "Novi Sad", "Budva", "Moskva" };

        public List<string> capacity = new List<string> { "0-1000", "1000-5000", "5000-10000", "10000+" };

        public static EventTagController eventTagController = new EventTagController();

        public static EventTypeController eventTypeController = new EventTypeController();

        public EventController eventController = new EventController();

        public List<string> eventTagsNames = eventTagController.GetEventTagNames();
        public List<string> eventTypesNames = eventTypeController.GetEventTypeNames();



        public CreateEvent()
        {
            InitializeComponent();
            StateBinding.ItemsSource = states;
            CityBinding.ItemsSource = cities;
            TypeBinding.ItemsSource = eventTypesNames;
            TagBinding.ItemsSource = eventTagsNames;
            CapacityBinding.ItemsSource = capacity;
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

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
            events.Capacity = (string)CapacityBinding.SelectedValue;
            if (ImageBinding.Source == null) events.ImagePath = events.Type.ImagePath; else events.ImagePath = ImageBinding.Source.ToString();

            eventController.Create(events);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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
            this.Show();
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

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Slike (*.jpg;*.jpeg; *.gif; *.png)|*.jpg;*.jpeg;*.gif;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
                ImageBinding.Source = bitmap;

            }

        }

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
