namespace ThirdApp
{
     class VipTicket : Ticket
    {

        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; } = 50m;

        // Total = Price + ServiceFee + tax
        public decimal TotalWithFee => (Price + ServiceFee) * 1.14m;
        public VipTicket(string movieName, decimal price, bool loungeAccess) 
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            return "[VIP Ticket]\n" +
                   base.ToString() +
                   $"\n  Lounge     : {(LoungeAccess ? "Yes" : "No")}" +
                   $"\n  Service Fee: {ServiceFee:F2} EGP" +
                   $"\n  Total+Fee  : {TotalWithFee:F2} EGP";
        }
    }
}
