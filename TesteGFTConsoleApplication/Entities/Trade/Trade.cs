using System;
using TesteGFTConsoleApplication.Entities.Categories;

namespace TesteGFTConsoleApplication.Entities.Trade
{
    public class Trade : ITrade
    {
        public Trade(double value, string clientSector, DateTime nextPaymentDate){
            this.Value = value;
            this.ClientSector = clientSector;
            this.NextPaymentDate = nextPaymentDate;
        }
        public double Value {get;}
        
        public string ClientSector {get;}

        public DateTime NextPaymentDate {get;}

        public string GetCategory(DateTime referenceDate){
            return Category.GetCategory(this, referenceDate);
        }
        
    }
}
