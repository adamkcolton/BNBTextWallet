namespace Discord.Bot.Services
{
    public class BnbRoot
    {
        public int account_number { get; set; }
        public string address { get; set; }
        public BalanceBnb[] balances { get; set; }
        public int[] public_key { get; set; }
        public int sequence { get; set; }
    }
}