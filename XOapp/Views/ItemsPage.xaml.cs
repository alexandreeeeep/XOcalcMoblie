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
            string[] prices = SeparateList(DependencyService.Get<IfileService>().ReadFile()[0].ToString());
            prices[0] = Scrap.Text;
            prices[1] = Copper.Text;
            prices[2] = Wires.Text;
            prices[3] = Plasric.Text;
            prices[4] = Batteries.Text;
            prices[5] = Electronics.Text;
            prices[6] = Uranium.Text;
        }
        string[] SeparateList(string ItemName)//finds the name in the text file
        {
            var Item = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            int CountForList = 0;
            for (int i = 0; i < ItemName.Length; i++)
            {//itarates threw each letter
                if (ItemName[i] != '_')//finds the end of the first word
                {
                    Item[CountForList] += ItemName[i];
                }
                else
                {
                    CountForList++;
                }
            }
            return Item;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            string[] Items = DependencyService.Get<IfileService>().ReadFile();
            string[] prices = SeparateList(Items[0].ToString());
            Scrap.Text = prices[0];
            Copper.Text = prices[1];
            Wires.Text = prices[2];
            Plasric.Text = prices[3];
            Batteries.Text = prices[4];
            Electronics.Text=prices[5];
            Uranium.Text =prices[6];
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