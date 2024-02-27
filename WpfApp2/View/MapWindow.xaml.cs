using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;
using System.Windows;
using System.Windows.Media.Converters;
using DocumentFormat.OpenXml.Bibliography;
using WpfApp2.Service;

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for MapWindow.xaml
    /// </summary>
    public partial class MapWindow : Window
    {
        System.Windows.Point startPoint = new System.Windows.Point();
        public static EventController eventController = new EventController();
        public  ObservableCollection<Event> Events  { get; set; }
        
        public ObservableCollection<Event> EventsOnMap { get; set; }
        List<Event> events = eventController.GetAll();

        private bool settedOnMap=false;

        private ListViewItem listViewItem=new ListViewItem();
        private ListViewItem listViewItemOnMap = new ListViewItem();


        
        public MapWindow()
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Events=new ObservableCollection<Event>();
            EventsOnMap= new ObservableCollection<Event>();
         
            foreach(Event e in events)
            {
                if(e.XPositions==0 && e.YPositions ==0)
                {
                    Events.Add(e);
                }
                else
                {
                    EventsOnMap.Add(e);
                   
                }

                
            }
            ListViewOnMap.ItemsSource = EventsOnMap;
            for (int i=0; i <ListViewOnMap.Items.Count; i++)
            {
                ListViewItem listViewItemOnMap = new ListViewItem();
                Event e = ListViewOnMap.Items[i] as Event;
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(e.ImagePath));
                image.Width = 20;
                image.Height=20;
                listViewItemOnMap.Content = image;
                listViewItemOnMap.Tag = e.Id;
       
                Canvas.SetLeft(listViewItemOnMap, e.XPositions);
                Canvas.SetTop(listViewItemOnMap, e.YPositions);
                canvas.Children.Add(listViewItemOnMap);
                listViewItemOnMap = null;
            }
            //if (Events.Count == 0)
            //{
            //    ListBox.Width = 0;
            //    ListBox.Height=0;
            //    canvas.Width = 400;
            //    image.Width = 400;
            //}

        }

        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
              (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            
                
            {
                ListView listView = sender as ListView;
                listViewItem =
                    FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

                if (listViewItem == null) return;

                Event events = (Event)listView.ItemContainerGenerator.
                   ItemFromContainer(listViewItem);

                DataObject dragData = new DataObject("myFormat", events);
                DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);

            }
        }
        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private void Image_DragOver(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Move;
            e.Handled = true;
        }


        private void Image_Drop(object sender, DragEventArgs e)
        {   
            

            if (e.Data.GetDataPresent("myFormat"))
            {
                Event events = e.Data.GetData("myFormat") as Event;
                Events.Remove(events);
                Event eventOnMap = new Event();

                ListViewItem listViewItemOnMap = new ListViewItem();
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(events.ImagePath));
                image.Width = 20;
                image.Height = 20;
                listViewItemOnMap.Content = image;
                listViewItemOnMap.Tag= events.Id;

       



                settedOnMap = false;
                var position = e.GetPosition(canvas);
                foreach (Event event1 in EventsOnMap)
                {
                    if ((position.X >= event1.XPositions && position.X <= event1.XPositions + 21 &&position.Y >= event1.YPositions && position.Y <= event1.YPositions + 21)||
                        (position.X + 21 >= event1.XPositions && position.X + 21 <= event1.XPositions + 21&& position.Y >= event1.YPositions && position.Y <= event1.YPositions + 21)||
                        (position.X >= event1.XPositions && position.X <= event1.XPositions + 21&&position.Y + 21 >= event1.YPositions && position.Y + 21 <= event1.YPositions + 21)||
                        (position.X + 21 >= event1.XPositions && position.X + 21 <= event1.XPositions + 21&& position.Y + 21 >= event1.YPositions && position.Y + 21 <= event1.YPositions + 21))
                    {

                        Canvas.SetLeft(listViewItemOnMap, position.X + 21);
                        Canvas.SetTop(listViewItemOnMap, position.Y + 21);
                        eventOnMap=eventController.TakePosition(events.Id, position.X + 21, position.Y + 21);
                        canvas.Children.Add(listViewItemOnMap);
                        settedOnMap = true;
                        break;
                    }
                                                                  

                }
                if (settedOnMap == false)
                {
                    Canvas.SetLeft(listViewItemOnMap, position.X);
                    Canvas.SetTop(listViewItemOnMap, position.Y);
                    eventOnMap=eventController.TakePosition(events.Id, position.X, position.Y);
                    canvas.Children.Add(listViewItemOnMap);
                }
                EventsOnMap.Add(eventOnMap);
                listViewItemOnMap = null;
      


            }

            if (e.Data.GetDataPresent("myFormat1"))
            {
                Event events = e.Data.GetData("myFormat1") as Event;
                EventsOnMap.Remove(events);
                List<ListViewItem> items = canvas.Children.OfType<ListViewItem>().ToList();
                foreach (ListViewItem item in items)
                {
                    if (item.Tag.Equals(events.Id)) { canvas.Children.Remove(item); }
                    
                }
                Event eventOnMap = new Event();

                ListViewItem listViewItemOnMap = new ListViewItem();
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(events.ImagePath));
                image.Width = 20;
                image.Height = 20;
                listViewItemOnMap.Content = image;
                listViewItemOnMap.Tag = events.Id;





                settedOnMap = false;
                var position = e.GetPosition(canvas);
                foreach (Event event1 in EventsOnMap)
                {
                    if ((position.X >= event1.XPositions && position.X <= event1.XPositions + 21 && position.Y >= event1.YPositions && position.Y <= event1.YPositions + 21) ||
                        (position.X + 21 >= event1.XPositions && position.X + 21 <= event1.XPositions + 21 && position.Y >= event1.YPositions && position.Y <= event1.YPositions + 21) ||
                        (position.X >= event1.XPositions && position.X <= event1.XPositions + 21 && position.Y + 21 >= event1.YPositions && position.Y + 21 <= event1.YPositions + 21) ||
                        (position.X + 21 >= event1.XPositions && position.X + 21 <= event1.XPositions + 21 && position.Y + 21 >= event1.YPositions && position.Y + 21 <= event1.YPositions + 21))
                    {

                        Canvas.SetLeft(listViewItemOnMap, position.X + 21);
                        Canvas.SetTop(listViewItemOnMap, position.Y + 21);
                        eventOnMap = eventController.TakePosition(events.Id, position.X + 21, position.Y + 21);
                        canvas.Children.Add(listViewItemOnMap);
                        settedOnMap = true;
                        break;
                    }


                }
                if (settedOnMap == false)
                {
                    Canvas.SetLeft(listViewItemOnMap, position.X);
                    Canvas.SetTop(listViewItemOnMap, position.Y);
                    eventOnMap = eventController.TakePosition(events.Id, position.X, position.Y);
                    canvas.Children.Add(listViewItemOnMap);
                }
                EventsOnMap.Add(eventOnMap);
                listViewItemOnMap = null;

      
            }
        }
   

        private void canvas_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Point mousePos = e.GetPosition(canvas);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
              (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))


            {

                Canvas canvas = sender as Canvas;

                listViewItemOnMap =
                    FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);
               
                if (listViewItemOnMap == null) return;

                Event events = eventController.GetById((string)listViewItemOnMap.Tag) ;
                    

                DataObject dragData = new DataObject("myFormat1", events);
                DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);

            }
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat1"))
            {
                Event events = e.Data.GetData("myFormat1") as Event;
                List<ListViewItem> items = canvas.Children.OfType<ListViewItem>().ToList();
                foreach (ListViewItem item in items)
                {
                    if (item.Tag.Equals(events.Id)) { canvas.Children.Remove(item); }

                }
                EventsOnMap.Remove(events);
               
                Events.Add(events);

                 Event eventOnMap = eventController.TakePosition(events.Id, 0, 0);

            }
        }

        private void ListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Move;
            e.Handled = true;
        }

        private void canvas_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Canvas canvas = sender as Canvas;

            listViewItemOnMap =
                FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

            if (listViewItemOnMap == null) return;

            Event events = eventController.GetById((string)listViewItemOnMap.Tag);
            AboutEvent aboutEvent = new AboutEvent(events);
            aboutEvent.Show();
            this.Close();
        }

        private void ListBox_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListView listView = sender as ListView;
            listViewItem =
                FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

            if (listViewItem == null) return;

            Event events = (Event)listView.ItemContainerGenerator.
               ItemFromContainer(listViewItem);

            AboutEvent aboutEvent = new AboutEvent(events);
            aboutEvent.Show();
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
        private void MapWindowWindow(object sender, RoutedEventArgs e)
        {
            MapWindow mapWindow = new MapWindow();
            mapWindow.Show();
            this.Close();
        }



        private void ListViewOnMap_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void ListViewOnMap_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void FilterBinding_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filteredText = FilterBinding.Text;
            List<Event> filteredEvents = eventController.FilterOnMap(filteredText);
          
            var items = canvas.Children.OfType<ListViewItem>().ToList();
            foreach (var item in items)
            {
                canvas.Children.Remove(item);
            }

            if (filteredEvents != null)
            {
                ListViewOnMap.ItemsSource = filteredEvents;

                for (int i = 0; i < ListViewOnMap.Items.Count; i++)
                {
                    ListViewItem listViewItemOnMap = new ListViewItem();
                    Event events = ListViewOnMap.Items[i] as Event;
                    Image image = new Image();
                    image.Source = new BitmapImage(new Uri(events.ImagePath));
                    image.Width = 20;
                    image.Height = 20;
                    listViewItemOnMap.Content = image;
                    listViewItemOnMap.Tag = events.Id;

                    Canvas.SetLeft(listViewItemOnMap, events.XPositions);
                    Canvas.SetTop(listViewItemOnMap, events.YPositions);
                    canvas.Children.Add(listViewItemOnMap);
                    listViewItemOnMap = null;
                }
            }
            else
            {
                List<Event> nullEvents = new List<Event>() { };
                ListViewOnMap.ItemsSource = nullEvents;
                for (int i = 0; i < ListViewOnMap.Items.Count; i++)
                {
                    ListViewItem listViewItemOnMap = new ListViewItem();
                    Event events = ListViewOnMap.Items[i] as Event;
                    Image image = new Image();
                    image.Source = new BitmapImage(new Uri(events.ImagePath));
                    image.Width = 20;
                    image.Height = 20;
                    listViewItemOnMap.Content = image;
                    listViewItemOnMap.Tag = events.Id;

                    Canvas.SetLeft(listViewItemOnMap, events.XPositions);
                    Canvas.SetTop(listViewItemOnMap, events.YPositions);
                    canvas.Children.Add(listViewItemOnMap);
                    listViewItemOnMap = null;
                }
            }
        }

       

    

        
    }
}
