using System.Collections.Generic;
using demo.Models.Data;

namespace demo.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks{get; set;}
        public string CurrentCategory{get; set;}
    }
}