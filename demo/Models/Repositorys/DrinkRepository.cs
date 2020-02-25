using System.Collections.Generic;
using System.Linq;
using demo.Models.Data;
using demo.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace demo.Models.Repositorys
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext appDbContext;

        public DrinkRepository(AppDbContext appDbContext)
        {
            this.appDbContext=appDbContext;
        }
        public IEnumerable<Drink> Drinks => appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => appDbContext.Drinks.FirstOrDefault(x => x.DrinkId == drinkId);
    }
}