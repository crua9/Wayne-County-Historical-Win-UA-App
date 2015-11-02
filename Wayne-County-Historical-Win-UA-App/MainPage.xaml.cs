using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Wayne_County_Historical_Win_UA_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Start
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Home));
            //   TitleTextBlock.Text = "Home";
            BackButton.Visibility = Visibility.Collapsed;
            Home.IsSelected = true;


        }



        //Hamburger Button
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
        //Select from the Hamburger list

        // take out the /* */ to remove the comment out
        public void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                MyFrame.Navigate(typeof(Home));
                //  TitleTextBlock.Text = "Home";
                BackButton.Visibility = Visibility.Collapsed;
            }
            /*  else if (Share.IsSelected)
               {
                   MyFrame.Navigate(typeof(Share));
                   //  TitleTextBlock.Text = "Share and Support";
                   BackButton.Visibility = Visibility.Visible;
               } */
            /*  else if (Maps.IsSelected)
              {
                  MyFrame.Navigate(typeof(Maps));
                  // TitleTextBlock.Text = "Maps";
                  BackButton.Visibility = Visibility.Visible;
              } */
            /*    else if (Stories.IsSelected)
                {
                    MyFrame.Navigate(typeof(Stories));
                    // TitleTextBlock.Text = "Stories";
                    BackButton.Visibility = Visibility.Visible;
                } */
            /*    else if (Games.IsSelected)
           {
               MyFrame.Navigate(typeof(Games));
               // TitleTextBlock.Text = "Games";
               BackButton.Visibility = Visibility.Visible;
           }
           
            */
            /*    else if (Cemetery.IsSelected)
         {
             MyFrame.Navigate(typeof(Games));
             // TitleTextBlock.Text = "Cemtery";
             BackButton.Visibility = Visibility.Visible;
         }
          */
        }

        //Back Button
        public void BackButton_click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();

            }

        }


    }
}
