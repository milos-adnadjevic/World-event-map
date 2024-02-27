using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
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
    /// Interaction logic for UpdateTag.xaml
    /// </summary>
    public partial class UpdateTag : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        ICollection<EventTag> eventTags;

        public EventTagController tagController = new EventTagController();

        public EventTag eventTag = new EventTag();






        List<string> colors = new List<string> { "Red", "Green", "Yellow", "Blue" };
     
        public UpdateTag(string id, string name,string description, string color)
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ColorBinding.ItemsSource= colors;
            _tagIdValidation = id;
            _tagNameValidation= name;
            DescriptionBinding.Text= description;
            ColorBinding.SelectedValue= color;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            EventTag eventTag = new EventTag();
            eventTag.Id = IdBinding.Text;
            eventTag.Name = NameBinding.Text;
            eventTag.TagDescription = DescriptionBinding.Text;
            eventTag.Color = (string)ColorBinding.SelectedValue;          
            tagController.Update(eventTag);
            AllTags allTags = new AllTags();
            allTags.Show();
            this.Close();

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(IdBinding.Text) || string.IsNullOrEmpty(NameBinding.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
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

        private string _tagIdValidation;


        public string TagIdValidation
        {
            get { return _tagIdValidation; }
            set
            {
                if (value != _tagIdValidation)
                {
                    _tagIdValidation = value;
                    OnPropertyChanged("TagIdValidation");


                }
            }
        }

        private string _tagNameValidation;


        public string TagNameValidation
        {
            get { return _tagNameValidation; }
            set
            {
                if (value != _tagNameValidation)
                {
                    _tagNameValidation = value;
                    OnPropertyChanged("TagNameValidation");


                }
            }
        }

        private void ColorBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedValue.ToString().Equals("Red"))
            {
                comboBox.Background = Brushes.Red;
                comboBox.BorderBrush = Brushes.Red;
                comboBox.Foreground = Brushes.Red;
            }
            if (comboBox.SelectedValue.ToString().Equals("Green"))
            {
                comboBox.Background = Brushes.Green;
                comboBox.BorderBrush = Brushes.Green;
                comboBox.Foreground = Brushes.Green;
            }
            if (comboBox.SelectedValue.ToString().Equals("Yellow"))
            {
                comboBox.Background = Brushes.Yellow;
                comboBox.BorderBrush = Brushes.Yellow;
                comboBox.Foreground = Brushes.Yellow;
            }
            if (comboBox.SelectedValue.ToString().Equals("Blue"))
            {
                comboBox.Background = Brushes.Blue;
                comboBox.BorderBrush = Brushes.Blue;
                comboBox.Foreground = Brushes.Blue;
            }
        }

        private void ColorBinding_DropDownOpened(object sender, EventArgs e)
        {
            ColorBinding.Foreground = Brushes.Black;
        }
    }
}

