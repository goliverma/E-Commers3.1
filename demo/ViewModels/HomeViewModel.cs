using System.Collections.Generic;
using demo.Models.Data;

namespace demo.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> PreferredDrinks {get; set;}
    }
}