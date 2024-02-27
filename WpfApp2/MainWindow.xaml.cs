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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.View;
using System.Windows.Controls;
using System.Windows.Navigation;
using DocumentFormat.OpenXml.Wordprocessing;
using WpfApp2.Controller;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool demo=false ;
        public EventController eventController = new EventController();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            

        }

        private void CreateEventTagWindow(object sender, RoutedEventArgs e)
        {
            CreateEventTag createEventTagWindow = new CreateEventTag();
            createEventTagWindow.Show();
            this.Close();
        }

        private void CreateEventTypeWindow(object sender, RoutedEventArgs e)
        {
            CreateEventType createEventType=new CreateEventType();
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
            AllEvents allEvents= new AllEvents();
            allEvents.Show();
            this.Close();

        }

        private void HomeWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow=new MainWindow();
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

        private void PlayDemo(object sender, RoutedEventArgs e)
        {
            demo = true;
              StartDemo(demo); 
          

        }

        public async void StartDemo(bool demo)
        {
            
            while (demo==true)
            {
                await Task.Delay(2000);
                CreateEvent createEventWindow = new CreateEvent();
                createEventWindow.Show();
                await Task.Delay(3000);
                Keyboard.Focus(createEventWindow.EventIdBinding);
                await Task.Delay(1500);
                createEventWindow.EventIdBinding.Text = "e";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "ev";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "eve";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "even";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "event";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "event-";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "event-1";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "event-10";
                await Task.Delay(1000);
                createEventWindow.EventIdBinding.Text = "event-101";
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.EventNameBinding);
                await Task.Delay(1500);
                createEventWindow.EventNameBinding.Text = "d";
                await Task.Delay(1000);
                createEventWindow.EventNameBinding.Text = "de";
                await Task.Delay(1000);
                createEventWindow.EventNameBinding.Text = "dem";
                await Task.Delay(1000);
                createEventWindow.EventNameBinding.Text = "demo";
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.TypeBinding);
                await Task.Delay(1500);
                createEventWindow.TypeBinding.SelectedIndex = 0;
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.OrganizationFeeBinding);
                await Task.Delay(1500);
                createEventWindow.OrganizationFeeBinding.Text = "1";
                await Task.Delay(1000);
                createEventWindow.OrganizationFeeBinding.Text = "10";
                await Task.Delay(1000);
                createEventWindow.OrganizationFeeBinding.Text = "100";
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.CapacityBinding);
                await Task.Delay(1500);
                createEventWindow.CapacityBinding.SelectedIndex = 0;
                await Task.Delay(1000);
                createEventWindow.CapacityBinding.SelectedIndex = 1;
                await Task.Delay(1000);
                createEventWindow.CapacityBinding.SelectedIndex = 2;
                await Task.Delay(1000);
                createEventWindow.CapacityBinding.SelectedIndex = 3;
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.StateBinding);
                await Task.Delay(1500);
                createEventWindow.StateBinding.SelectedIndex = 0;
                await Task.Delay(1000);
                createEventWindow.StateBinding.SelectedIndex = 1;
                await Task.Delay(1000);
                createEventWindow.StateBinding.SelectedIndex = 2;
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.CityBinding);
                await Task.Delay(1500);
                createEventWindow.CityBinding.SelectedIndex = 0;
                await Task.Delay(1000);
                createEventWindow.CityBinding.SelectedIndex = 1;
                await Task.Delay(1000);
                createEventWindow.CityBinding.SelectedIndex = 2;
                await Task.Delay(1000);
                createEventWindow.CityBinding.SelectedIndex = 3;
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.TicketPriceBinding);
                await Task.Delay(1500);
                createEventWindow.TicketPriceBinding.Text = "1";
                await Task.Delay(1000);
                createEventWindow.TicketPriceBinding.Text = "10";
                await Task.Delay(1000);
                createEventWindow.TicketPriceBinding.Text = "100";
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.DateBinding);
                await Task.Delay(1500);
                createEventWindow.DateBinding.SelectedDate = DateTime.Today.AddDays(-1);
                await Task.Delay(3000);
                Keyboard.Focus(createEventWindow.HumanitarianBinding);
                await Task.Delay(1500);
                createEventWindow.HumanitarianBinding.IsChecked = true;
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.DescriptionBinding);
                await Task.Delay(1500);
                createEventWindow.DescriptionBinding.Text = "n";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "ni";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nic";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nice";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nice ";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nice e";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nice ev";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nice eve";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nice even";
                await Task.Delay(1000);
                createEventWindow.DescriptionBinding.Text = "nice event";
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.ImageBinding);
                await Task.Delay(1500);
                createEventWindow.ImageBinding.Source = new BitmapImage(new Uri("/WpfApp2;component/Image/home.png ", UriKind.Relative));
                await Task.Delay(1500);
                Keyboard.Focus(createEventWindow.TagBinding);
                await Task.Delay(1500);
                createEventWindow.TagBinding.SelectedIndex = 0;
                await Task.Delay(1000);
                Keyboard.Focus(createEventWindow.Submit);
                await Task.Delay(1500);
                createEventWindow.Close();

                CreateEventTag createEventTag = new CreateEventTag();
                createEventTag.Show();
                await Task.Delay(3000);
                Keyboard.Focus(createEventTag.IdBinding);
                await Task.Delay(1500);
                createEventTag.IdBinding.Text = "t";
                await Task.Delay(1000);
                createEventTag.IdBinding.Text = "ta";
                await Task.Delay(1000);
                createEventTag.IdBinding.Text = "tag";
                await Task.Delay(1000);
                createEventTag.IdBinding.Text = "tag-";
                await Task.Delay(1000);
                createEventTag.IdBinding.Text = "tag-1";
                await Task.Delay(1000);
                createEventTag.IdBinding.Text = "tag-10";
                await Task.Delay(1000);
                createEventTag.IdBinding.Text = "tag-101";
                await Task.Delay(1000);
                Keyboard.Focus(createEventTag.NameBinding);
                await Task.Delay(1500);
                createEventTag.NameBinding.Text = "d";
                await Task.Delay(1000);
                createEventTag.NameBinding.Text = "de";
                await Task.Delay(1000);
                createEventTag.NameBinding.Text = "dem";
                await Task.Delay(1000);
                createEventTag.NameBinding.Text = "demo";
                await Task.Delay(1000);
                Keyboard.Focus(createEventTag.ColorBinding);
                await Task.Delay(1500);
                createEventTag.ColorBinding.SelectedIndex = 0;
                await Task.Delay(1000);
                createEventTag.ColorBinding.SelectedIndex = 1;
                await Task.Delay(1000);
                createEventTag.ColorBinding.SelectedIndex = 2;
                await Task.Delay(1000);
                createEventTag.ColorBinding.SelectedIndex = 3;
                await Task.Delay(1000);
                Keyboard.Focus(createEventTag.DescriptionBinding);
                await Task.Delay(1500);
                createEventTag.DescriptionBinding.Text = "n";
                await Task.Delay(1000);
                createEventTag.DescriptionBinding.Text = "ni";
                await Task.Delay(1000);
                createEventTag.DescriptionBinding.Text = "nic";
                await Task.Delay(1000);
                createEventTag.DescriptionBinding.Text = "nice";
                await Task.Delay(1000);
                createEventTag.DescriptionBinding.Text = "nice ";
                await Task.Delay(1000);
                createEventTag.DescriptionBinding.Text = "nice t";
                await Task.Delay(1000);
                createEventTag.DescriptionBinding.Text = "nice ta";
                await Task.Delay(1000);
                createEventTag.DescriptionBinding.Text = "nice tag";
                await Task.Delay(1000);
                Keyboard.Focus(createEventTag.Submit);
                await Task.Delay(1500);
                createEventTag.Close();

                CreateEventType createEventType = new CreateEventType();
                createEventType.Show();
                await Task.Delay(3000);
                Keyboard.Focus(createEventType.IdBinding);
                await Task.Delay(1500);
                createEventType.IdBinding.Text = "t";
                await Task.Delay(1000);
                createEventType.IdBinding.Text = "ty";
                await Task.Delay(1000);
                createEventType.IdBinding.Text = "typ";
                await Task.Delay(1000);
                createEventType.IdBinding.Text = "type";
                await Task.Delay(1000);
                createEventType.IdBinding.Text = "type-";
                await Task.Delay(1000);
                createEventType.IdBinding.Text = "type-1";
                await Task.Delay(1000);
                createEventType.IdBinding.Text = "type-10";
                await Task.Delay(1000);
                createEventType.IdBinding.Text = "type-101";
                await Task.Delay(1000);
                Keyboard.Focus(createEventType.NameBinding);
                await Task.Delay(1500);
                createEventType.NameBinding.Text = "d";
                await Task.Delay(1000);
                createEventType.NameBinding.Text = "de";
                await Task.Delay(1000);
                createEventType.NameBinding.Text = "dem";
                await Task.Delay(1000);
                createEventType.NameBinding.Text = "demo";
                await Task.Delay(1000);
                Keyboard.Focus(createEventType.ImageBinding);
                await Task.Delay(1500);
                createEventType.ImageBinding.Source = new BitmapImage(new Uri("/WpfApp2;component/Image/home.png ", UriKind.Relative));
                await Task.Delay(1500);
                Keyboard.Focus(createEventType.IdBinding);
                await Task.Delay(1500);
                Keyboard.Focus(createEventType.Submit);
                await Task.Delay(1500);
                createEventType.Close();

                AllEvents allEvents = new AllEvents();
                allEvents.Show();
                await Task.Delay(3000);
                Keyboard.Focus(allEvents.Search);
                await Task.Delay(2500);

                SearchWindow searchWindow = new SearchWindow();
                searchWindow.Show();
                await Task.Delay(3000);
                Keyboard.Focus(searchWindow.SearchNameBinding);
                await Task.Delay(1500);
                searchWindow.SearchNameBinding.Text = "s";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "sl";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "sla";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slan";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slani";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slanin";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slanini";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slaninij";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slaninija";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slaninijad";
                await Task.Delay(1000);
                searchWindow.SearchNameBinding.Text = "slaninijada";
                await Task.Delay(1000);
                Keyboard.Focus(searchWindow.SearchTypeBinding);
                await Task.Delay(1500);
                searchWindow.SearchTypeBinding.Text = "f";
                await Task.Delay(1000);
                searchWindow.SearchTypeBinding.Text = "fo";
                await Task.Delay(1000);
                searchWindow.SearchTypeBinding.Text = "foo";
                await Task.Delay(1000);
                searchWindow.SearchTypeBinding.Text = "food";
                await Task.Delay(1000);
                Keyboard.Focus(searchWindow.SearchDescriptionBinding);
                await Task.Delay(1500);
                searchWindow.SearchDescriptionBinding.Text = "d";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "do";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dob";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobr";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra ";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra ";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra k";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra kl";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra klo";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra klop";
                await Task.Delay(1000);
                searchWindow.SearchDescriptionBinding.Text = "dobra klopa";
                await Task.Delay(1000);
                Keyboard.Focus(searchWindow.SearchCapacityBinding);
                await Task.Delay(1500);
                searchWindow.SearchCapacityBinding.SelectedIndex = 0;
                await Task.Delay(1000);
                Keyboard.Focus(searchWindow.Search);
                await Task.Delay(1500);
                searchWindow.Close();

                allEvents.AllEventsBinding.ItemsSource = eventController.Search("slaninijada", "food", "dobra klopa", "0-1000");

                Keyboard.Focus(allEvents.FilterBinding);
                await Task.Delay(1500);
                allEvents.FilterBinding.Text = "s";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("s");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "sl";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("sl");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "sla";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("sla");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slan";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slan");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slani";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slani");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slanin";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slanin");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slanini";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slanini");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slaninij";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slaninij");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slaninija";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slaninija");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slaninijad";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slaninijad");
                await Task.Delay(1000);
                allEvents.FilterBinding.Text = "slaninijada";
                allEvents.AllEventsBinding.ItemsSource = eventController.Filter("slaninijada");
                await Task.Delay(1000);






                if (createEventWindow.stopMethod()) { demo = false; }
                if (createEventTag.stopMethod()) { demo = false; }
                if (createEventType.stopMethod()) { demo = false; }
                if (allEvents.stopMethod()) { demo = false; }
                if (searchWindow.stopMethod()) { demo = false; }

            }
            
        }

            private void Window_KeyDown(object sender, KeyEventArgs e)
            {   
              if(e.Key == Key.Escape)
              {
                   demo = false;
                
                  StartDemo(demo);
                for (int intCounter = App.Current.Windows.Count - 1; intCounter >= 0; intCounter--)
                   {
                    if (App.Current.Windows[intCounter] != this) { App.Current.Windows[intCounter].Close(); }
                       
                       
                   }

                  
                  
                  
                   e.Handled = true;
              }
                
            }
        

        
    }
}
