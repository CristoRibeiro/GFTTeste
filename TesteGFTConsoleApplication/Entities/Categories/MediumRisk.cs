using System;
using TesteGFTConsoleApplication.Entities.Trade;
using TesteGFTConsoleApplication.Enums;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public class MediumRisk : ICategory
    {
        public string GetCategory(ITrade trade, DateTime dateReference)
        {
            string category = string.Empty;

            if (trade.Value > 1000000 & trade.ClientSector.ToUpper().Equals(ClientSectorEnum.Public.ToString().ToUpper()))
            {
                category = CategoryEnum.MEDIUMRISK.ToString();
            }
            return category;
        }
    }
}