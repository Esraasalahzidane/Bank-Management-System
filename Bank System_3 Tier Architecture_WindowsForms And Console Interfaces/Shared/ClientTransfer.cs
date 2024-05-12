using System;

namespace Shared
{
    public class ClientTransfer
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string FromAcc { get; set; }
        public string ToAcc { get; set; }
        public DateTime Date { get; set; }
        public ClientTransfer(int amount, string fromAcc, string toAcc)
        {
            Amount = amount;
            FromAcc = fromAcc;
            ToAcc = toAcc;
        }
    }
}