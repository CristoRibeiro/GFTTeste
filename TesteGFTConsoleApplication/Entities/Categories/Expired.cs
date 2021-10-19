using System;
using TesteGFTConsoleApplication.Entities.Trade;
using TesteGFTConsoleApplication.Enums;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public class Expired : ICategory
    {
        public string Name {get{return CategoryEnum.EXPIRED.ToString(); }}
        
        public Boolean UseCategory(ITrade trade, DateTime referenceDate)
        {
            return (referenceDate - trade.NextPaymentDate).TotalDays > 30;
        }
       
    }
}
