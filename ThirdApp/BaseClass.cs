namespace ThirdApp
{
    public abstract class Ticket
    {
        //Static counter (shared across ALL ticket types) 
        private static int _counter = 0;
        public static int GetTotalTickets() => _counter;

        private int _ticketId;
        private string _movieName;
        private decimal _price;

        public int TicketId => _ticketId;            // read-only

        public string MovieName                      // no null/empty
        {
            get => _movieName;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    _movieName = value;
            }
        }

        public decimal Price                               
        {
            get => _price;
            protected set
            {
                if (value > 0) _price = value;
            }
        }

        // Calculated - never stored, recomputed every time
        public decimal PriceAfterTax => _price * 1.14m;

        protected Ticket(string movieName, decimal price)
        {
            _counter++;              // increment shared counter
            _ticketId = _counter;    // unique ID
            MovieName = movieName;
            Price = price;
        }

        public override string ToString()
        {
            return $"  ID         : {TicketId}\n" +
                   $"  Movie      : {MovieName}\n" +
                   $"  Price      : {Price:F2} EGP\n" +
                   $"  Price+Tax  : {PriceAfterTax:F2} EGP";
        }
    }
}
