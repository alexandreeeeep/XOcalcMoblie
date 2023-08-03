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
using System.Net;
using System.IO;
using XOapp.Interface;

namespace XOapp.Views
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry inputBox = (Entry)sender;
            if (e.NewTextValue != null) {//prevents a crash from occuring if two invalid buttons are pressed at the same 
                if (!e.NewTextValue.All("1234567890.".Contains))
                {
                        inputBox.Text = e.OldTextValue;
                }
                else if (inputBox.Text.IndexOf(".") != inputBox.Text.LastIndexOf("."))//prevents double decimal points
                {
                    inputBox.Text = e.OldTextValue;
                }
            }

            else
            {
                inputBox.Text = "";
            }
            var values =Scrap.Text+"_"+ Copper.Text + "_" + Wires.Text + "_" + Plasric.Text + "_" + Batteries.Text + "_" + Electronics.Text + "_" + Uranium.Text;
            DependencyService.Get<IfileService>().CreateFile(values);
        }
    }
}