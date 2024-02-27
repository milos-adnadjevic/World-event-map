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
    /// Interaction logic for AllTags.xaml
    /// </summary>
    public partial class AllTags : Window
    {
        public static EventTagController tagController = new EventTagController();
        ICollection<EventTag> allTags = tagController.GetAll();
        public EventTag selectedTag = new EventTag();
        public AllTags()
        {
       
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AllTagsBinding.ItemsSource = allTags;
        }

        public void afterDelete()
        {
            AllTagsBinding.ItemsSource = tagController.GetAll();
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
            selectedTag = (EventTag)AllTagsBinding.SelectedItem;
            if (selectedTag == null) { return; }

            string id = selectedTag.Id;
            string name = selectedTag.Name;
            string description = selectedTag.TagDescription;
            string color = selectedTag.Color;

            UpdateTag updateTag = new UpdateTag(id, name, description, color);
            updateTag.Show();                   
            this.Close();

        }

        private void HelpWindow(object sender, RoutedEventArgs e)
        {
            HelpPopUpWindow helpPopUpWindow = new HelpPopUpWindow();
            helpPopUpWindow.Show();

        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            selectedTag = (EventTag)AllTagsBinding.SelectedItem;
            if (selectedTag == null) { return; }
            DeleteConfirm deleteConfirm = new DeleteConfirm(selectedTag.Id);
            this.IsEnabled = false;
            deleteConfirm.Show();

        }
        private void MapWindow(object sender, RoutedEventArgs e)
        {
            MapWindow mapWindow = new MapWindow();
            mapWindow.Show();
            this.Close();
        }


    }
}
