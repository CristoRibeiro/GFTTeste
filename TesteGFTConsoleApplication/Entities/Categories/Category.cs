using System;
using System.Collections.Generic;
using TesteGFTConsoleApplication.Entities.Trade;
using TesteGFTConsoleApplication.Enums;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public static class Category
    {
        public static string GetCategory(ITrade trade, DateTime referenceDate)
        {
            string tradeCategory = string.Empty;

            List<ICategory> categories = new List<ICategory>();
            categories.Add(new Expired());
            categories.Add(new HighRisk());
            categories.Add(new MediumRisk());            

            foreach (var category in categories)
            {
                tradeCategory = category.GetCategory(trade,referenceDate);

                if (tradeCategory != string.Empty)
                {
                    break;
                    
                }
            }

            if (tradeCategory.Equals(string.Empty))
            {
                tradeCategory = CategoryEnum.NOCATEGORY.ToString();
            }

            return tradeCategory;
        }
    }
}