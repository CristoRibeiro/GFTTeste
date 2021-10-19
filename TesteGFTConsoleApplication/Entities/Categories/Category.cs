using System;
using System.Collections.Generic;
using TesteGFTConsoleApplication.Entities.Trade;
using TesteGFTConsoleApplication.Enums;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public static class Category
    {
        public static ICategory GetCategory(ITrade trade, DateTime referenceDate)
        {
            ICategory categoryReturn = null;

            List<ICategory> categories = new List<ICategory>{
                new Expired(),
                new HighRisk(),
                new MediumRisk(),
                new NoCategory()
            };

            foreach (var category in categories)
            {
                if (category.UseCategory(trade,referenceDate))
                {
                    categoryReturn = category;
                    ;
                }
            }

            return categoryReturn;
        }
    }
}