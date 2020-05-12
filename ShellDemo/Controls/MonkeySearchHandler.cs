using ShellDemo.Data;
using ShellDemo.Models;
using ShellDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellDemo.Controls
{
    public class MonkeySearchHandler : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = MonkeyData.Monkeys
                    .Where(monkey => monkey.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(500);

            // Note: strings will be URL encoded for navigation (e.g. "Blue Monkey" becomes "Blue%20Monkey"). Therefore, decode at the receiver.
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"searchResultsPage?name={((Animal)item).Name}",true);
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/monkeys/monkeydetails?name={((Animal)item).Name}");
        }
    }
}
