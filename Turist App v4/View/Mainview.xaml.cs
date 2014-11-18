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
using Microsoft.VisualBasic.CompilerServices;
using Turist_App_v4.Model;
using Turist_App_v4.View;
using Turist_App_v4.Viewmodel;

namespace Turist_App_v4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Kategorier Restaurant = new Kategorier("Restaurant", "RestaurantBillede");
        Kategorier Transport = new Kategorier("Transport", "TransportBillede");

        public MainPage()
        {
            MainViewVM.Kategoriers.Clear();
            MainViewVM.Kategoriers.Add(Restaurant);
            MainViewVM.Kategoriers.Add(Transport);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (AttraktionInfo));
            if (MainViewListView.SelectedIndex == 0)
            {
                MainViewVM.StaticSelectedKategori = Restaurant;
            }
            if (MainViewListView.SelectedIndex == 1)
            {
                MainViewVM.StaticSelectedKategori = Transport;
            }
        }
        private void TilføjAttraktion_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (TilføjAttraktionView));
        }
    }
}
