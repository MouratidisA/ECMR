using ECMR.Models;
using Plugin.Messaging;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ECMR.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ECMR.Views
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage 
    {
        public ObservableCollection<MessageCategory> MessageCategories { set; get; }
        public MainPageViewModel MainPageViewModel { get; set; }
        

        public MainPage()
        {
            InitializeComponent();
            MessageCategories = MessageCategory.LoadCategories();
            CategoryListView.ItemsSource = MessageCategories;
            MainPageViewModel = new MainPageViewModel();
            BindingContext = MainPageViewModel;
        }

        private void CategoryListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            MainPageViewModel.SavePrefs();
            var category = e.SelectedItem as MessageCategory;
           if(category !=null)
            {
                 
                // Send Sms
                var smsMessenger = CrossMessaging.Current.SmsMessenger;
                if (smsMessenger.CanSendSms)
                    smsMessenger.SendSms(
                        MainPageViewModel.ServiceNumber,
                        $"{category.NumOfCategory} {MainPageViewModel.FullName} {MainPageViewModel.Address}");
            }
           

            ((ListView)sender).SelectedItem = null;


        }
    }



}
