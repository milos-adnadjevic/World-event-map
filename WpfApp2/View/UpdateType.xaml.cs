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
    /// Interaction logic for UpdateType.xaml
    /// </summary>
    public partial class UpdateType : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        ICollection<EventType> eventTypes;

        EventTypeController controller = new EventTypeController();


        public UpdateType(EventType eventType)
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            _typeIdValidation= eventType.Id;
            _typeNameValidation = eventType.Name;
            BitmapImage bitmap = new BitmapImage(new Uri(eventType.ImagePath));
            ImageBinding.Source = bitmap;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EventType type = new EventType();

            type.Id = IdBinding.Text;
            type.Name = NameBinding.Text;
            type.ImagePath = ImageBinding.Source.ToString();
          

            controller.Update(type);
            AllTypes allTypes = new AllTypes();
            allTypes.Show();
            this.Close();





        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {


            if (string.IsNullOrEmpty(IdBinding.Text) || string.IsNullOrEmpty(NameBinding.Text) || ImageBinding.Source == null)
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


        private string _typeIdValidation;


        public string TypeIdValidation
        {
            get { return _typeIdValidation; }
            set
            {
                if (value != _typeIdValidation)
                {
                    _typeIdValidation = value;
                    OnPropertyChanged("TypeIdValidation");


                }
            }
        }

        private string _typeNameValidation;


        public string TypeNameValidation
        {
            get { return _typeNameValidation; }
            set
            {
                if (value != _typeNameValidation)
                {
                    _typeNameValidation = value;
                    OnPropertyChanged("TypeNameValidation");


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
    }
}
