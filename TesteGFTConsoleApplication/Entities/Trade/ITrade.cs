namespace TesteGFTConsoleApplication.Entities.Trade
{
    using System;
    public interface ITrade
    {
        double Value { get; } //indicates the transaction amount in dollars
        string ClientSector { get; } //indicates the client ?s sector which can be "Public" or "Private"
        DateTime NextPaymentDate { get; }
    }
}