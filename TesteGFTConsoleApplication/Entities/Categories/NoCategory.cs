using System;
using TesteGFTConsoleApplication.Entities.Trade;
using TesteGFTConsoleApplication.Enums;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public class NoCategory : ICategory
    {
        public string Name => CategoryEnum.NOCATEGORY.ToString();

        public bool UseCategory(ITrade trade, DateTime referenceDate)
        {   
            return true;
        }
    }
}