using ShellDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("Name", "name")]
    public partial class SearchResultsPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = MonkeyData.Monkeys.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }
        public SearchResultsPage()
        {
            InitializeComponent();
        }
    }
}