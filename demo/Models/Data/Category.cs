using System.Collections.Generic;

namespace demo.Models.Data
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}