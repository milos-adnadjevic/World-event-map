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
    /// Interaction logic for CreateEventType.xaml
    /// </summary>
    public partial class CreateEventType : Window, INotifyPropertyChanged
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

        ICollection<EventType> eventTypes;

        EventTypeController controller=new EventTypeController();

       
        public CreateEventType()
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            string id = IdBinding.Text;
            string name = NameBinding.Text;
            string imagePath = ImageBinding.Source.ToString();

            EventType eventType= new EventType(id, name, imagePath);

            controller.Create(eventType);
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
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
            if (openFileDialog.ShowDialog()== true)
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
                bool demo = false;
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
