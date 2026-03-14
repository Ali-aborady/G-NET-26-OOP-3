namespace ThirdApp
{
    class IMaxTicket : Ticket
    {
        public bool Is3D { get; set; }


        public IMaxTicket(string movieName, decimal price, bool is3D)
            : base(movieName, is3D ? price + 30m : price) //price adjustment happens BEFORE base stores it
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            return "[IMAX Ticket]\n" +
                   base.ToString() +
                   $"\n  3D         : {(Is3D ? "Yes (+30 EGP)" : "No")}";
        }
    }
}
