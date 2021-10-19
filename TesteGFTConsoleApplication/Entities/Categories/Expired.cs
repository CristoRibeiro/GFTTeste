using System;
using TesteGFTConsoleApplication.Entities.Trade;
using TesteGFTConsoleApplication.Enums;

namespace TesteGFTConsoleApplication.Entities.Categories
{
    public class Expired : ICategory
    {
        public string GetCategory(ITrade trade, DateTime referenceDate)
        {
            string category = string.Empty;

            if ((referenceDate - trade.NextPaymentDate).TotalDays > 30)
            {
             category = CategoryEnum.EXPIRED.ToString();//teste
            }
            
            return category;
        }
       
    }
}
