using System;
using TesteGFTConsoleApplication.Entities.Trade;
using TesteGFTConsoleApplication.Enums;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public class HighRisk : ICategory
    {
        public string Name => CategoryEnum.HIGHRISK.ToString() ;

        public bool UseCategory(ITrade trade, DateTime dateReference)
        {
            return (trade.Value > 1000000 & trade.ClientSector.ToUpper().Equals(ClientSectorEnum.Private.ToString().ToUpper()));
        }


    }
}