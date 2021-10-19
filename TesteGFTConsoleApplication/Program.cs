using System;
using System.Collections.Generic;
using System.Globalization;
using TesteGFTConsoleApplication.Entities.Categories;
using TesteGFTConsoleApplication.Entities.Trade;

namespace TesteGFTConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime referenceDate;
            int numberOfTrades;
            string DTOTrade;
            string[] valuesArray;
            CultureInfo cultureInfo =  new CultureInfo("en-US");

            try
            {
                Console.WriteLine("Enter reference date:");                
                referenceDate = Convert.ToDateTime(Console.ReadLine(), cultureInfo);

                Console.WriteLine("Enter number of trades:");
                numberOfTrades = Convert.ToInt32(Console.ReadLine());

                List<Trade> trades = new List<Trade>();
                
                Console.WriteLine("Enter trades:");
                for (var i = 0; i < numberOfTrades; i++)
                {
                    DTOTrade = Console.ReadLine();

                    valuesArray = DTOTrade.Split(" ", 3);

                    trades.Add(new Trade(Convert.ToDouble(valuesArray[0]), valuesArray[1], Convert.ToDateTime(valuesArray[2], cultureInfo)));
                }

                Console.WriteLine("");
                Console.WriteLine("OutPut:");
                Console.WriteLine("");

                foreach (var trade in trades)
                {
                    Console.WriteLine(Category.GetCategory(trade, referenceDate).Name);                    
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Check input data format: {ex.Message}");
            }

        }
    }
}