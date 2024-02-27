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
using WpfApp2.Controller;
using WpfApp2.Model;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for AllTypes.xaml
    /// </summary>
    public partial class AllTypes : Window
    {
        public static EventTypeController typeController = new EventTypeController();
        ICollection<EventType> allTypes = typeController.GetAll();
        public EventType selectedType = new EventType();
        public AllTypes()
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AllTypesBinding.ItemsSource = allTypes;
        }

        public void afterDelete()
        {
            AllTypesBinding.ItemsSource = typeController.GetAll();
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
            selectedType = (EventType)AllTypesBinding.SelectedItem;

            if (selectedType == null) { return; }
            UpdateType updateType = new UpdateType(selectedType);
            updateType.Show();
          
            this.Close();

        }

        private void HelpWindow(object sender, RoutedEventArgs e)
        {
            HelpPopUpWindow helpPopUpWindow = new HelpPopUpWindow();
            helpPopUpWindow.Show();
        }
        private void Delete(object sender, RoutedEventArgs e)
        {

            selectedType = (EventType)AllTypesBinding.SelectedItem;
            if (selectedType == null) { return; }
            DeleteConfirm deleteConfirm = new DeleteConfirm(selectedType.Id);
            this.IsEnabled = false;
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

        }

        private void AllTypes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
