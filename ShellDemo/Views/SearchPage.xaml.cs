using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellDemo.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class SearchPage : ContentPage
    {

        public SearchPage()
        {
            InitializeComponent();
            searchPage.ItemsSource = MonkeyData.Monkeys;
        }
    }
}