using System;
using TesteGFTConsoleApplication.Entities.Trade;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public interface ICategory
    {
         string GetCategory(ITrade trade, DateTime referenceDate);
         
    }
}