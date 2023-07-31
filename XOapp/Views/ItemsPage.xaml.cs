using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XOapp.Models;
using XOapp.ViewModels;
using XOapp.Views;
using XOapp.Services; 

namespace XOapp.Views
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
        }
        public string getValues()
        {
            return scrap.Text;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}