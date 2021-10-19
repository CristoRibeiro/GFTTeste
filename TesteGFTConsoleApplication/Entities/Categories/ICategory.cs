using System;
using TesteGFTConsoleApplication.Entities.Trade;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public interface ICategory
    {
         Boolean UseCategory(ITrade trade, DateTime referenceDate);
         string Name{get;}
         
    }
}