using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    /// 
    // 35.376603, -77.995889 The location of the place (may need to push this a little south)

        // Need the location and pics of the military and so on


    public sealed partial class Willow_Dale_Cemetery : Page
    {
        public Willow_Dale_Cemetery()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            WillowMap.Center = new Windows.Devices.Geolocation.Geopoint(
                new Windows.Devices.Geolocation.BasicGeoposition()
                {
                    Latitude = 35.376603,
                    Longitude = -77.995889

                });
            WillowMap.ZoomLevel = 20;
            base.OnNavigatedTo(e);
        }

        private void Military(object sender, RoutedEventArgs e)
        {
            var strokeColor = Colors.DarkBlue;
            var fillColor = Colors.Blue;
            foreach (var dataObject in PointList.GetAreas())
            {
                var shape = new MapPolygon
                {
                    StrokeThickness = 3,
                    StrokeColor = strokeColor,
                    FillColor = fillColor,
                    StrokeDashed = false,
                    ZIndex = 3,
                    Path = new Geopath(dataObject.Points.Select(p => p.Position))
                };
                shape.AddData(dataObject);
                WillowMap.MapElements.Add(shape);
            }
        }

        private void Emergency(object sender, RoutedEventArgs e)
        {

        }

        private void Freemason(object sender, RoutedEventArgs e)
        {

        }

        private void Clear(object sender, RoutedEventArgs e)
        {

        }

        private void ZoomOut(object sender, RoutedEventArgs e)
        {

        }

        private void ZoomIn(object sender, RoutedEventArgs e)
        {

        }
    }
}

