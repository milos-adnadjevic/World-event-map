using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Wordprocessing;
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

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for DeleteConfirm.xaml
    /// </summary>
    public partial class DeleteConfirm : Window
    {
        public string eventId = "";
        public EventController eventController = new EventController();
        public EventTagController eventTagController = new EventTagController();    
        public EventTypeController eventTypeController = new EventTypeController();
        public DeleteConfirm(string id)
        {
            InitializeComponent();
            DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            eventId = id;
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            AllEvents allEvents = GetOpenResultWindow();
            AllTags allTags= GetOpenResultWindowAllTags();
            AllTypes allTypes = GetOpenResultWindowAllTypes();
            if (allEvents != null)
            {

                eventController.Delete(eventId);
                allEvents.afterDelete();
                allEvents.IsEnabled = true;


            }
            if (allTags != null)
            {

                eventTagController.Delete(eventId);
                allTags.afterDelete();
                allTags.IsEnabled = true;


            }
            if (allTypes != null)
            {

                eventTypeController.Delete(eventId);
                allTypes.afterDelete();
                allTypes.IsEnabled = true;

            }

            if(allEvents==null && allTags==null && allTypes == null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }



            this.Close();

        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
       
            AllEvents allEvents = GetOpenResultWindow();
            AllTags allTags = GetOpenResultWindowAllTags();
            AllTypes allTypes = GetOpenResultWindowAllTypes();

            if (allEvents != null)
            {
                
                allEvents.IsEnabled = true;


            }
            if (allTags != null)
            {
             
                allTags.IsEnabled = true;

            }
            if (allTypes != null)
            {

                allTypes.IsEnabled = true;


            }

            this.Close();


        }

        private AllEvents GetOpenResultWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is AllEvents resultWindow && resultWindow.IsVisible)
                {
                    return resultWindow;
                }
            }
            return null;
        }

        private AllTags GetOpenResultWindowAllTags()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is AllTags resultWindow && resultWindow.IsVisible)
                {
                    return resultWindow;
                }
            }
            return null;
        }

        private AllTypes GetOpenResultWindowAllTypes()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window is AllTypes resultWindow && resultWindow.IsVisible)
                {
                    return resultWindow;
                }
            }
            return null;
        }


    }
}
