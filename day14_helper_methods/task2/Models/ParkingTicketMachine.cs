namespace task2.Models;

public class ParkingTicketMachine
{
    public readonly int MinutesPrKr = 3;
    public int[] CoinsToInsert { get; private set; }
    public int AmountInserted { get; private set; }
    public DateTime TimeNow { get; private set; } = DateTime.Now;
    public DateTime PaidUntil => TimeNow.AddMinutes((double)AmountInserted / MinutesPrKr);

    public void InsertCoin(int kr)
    {
        AmountInserted += kr;
    }
}