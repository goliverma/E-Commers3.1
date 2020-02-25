using System.Collections.Generic;
using demo.Models.Data;

namespace demo.Models.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;}
    }
}