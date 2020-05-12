using ShellDemo.Views;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ShellDemo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        //public Dictionary<string, Type> Routes { get { return routes; } }

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        private void RegisterRoutes()
        {
            routes.Add("searchPage", typeof(SearchPage));
            routes.Add("searchResultsPage", typeof(SearchResultsPage));
            routes.Add("itemsPage", typeof(ItemsPage));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sweet Alert!", "We're getting there gradually...", "OK");
        }
    }
}
