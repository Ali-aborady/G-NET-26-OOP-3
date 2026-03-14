namespace ThirdApp
{
    // CINEMA CLASS — Composition with Projector
    class Cinema
    {
        public string CinemaName { get; private set; }

        // Projector is CREATED INSIDE Cinema -> Composition
        private Projector _projector = new Projector();

        // Holds up to 20 tickets of ANY type (polymorphism)
        private Ticket[] _tickets = new Ticket[20];

        public Cinema(string name)
        {
            CinemaName = name;
        }

        public void OpenCinema()
        {
            Console.WriteLine($"\n=== {CinemaName} is OPEN ===");
            _projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine($"\n=== {CinemaName} is CLOSING ===");
            _projector.Stop();
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }
            return false; // full
        }

        public void PrintAllTickets()
        {
            Console.WriteLine($"\n=== All Tickets in {CinemaName} ===\n");
            bool any = false;
            foreach (Ticket t in _tickets)
            {
                if (t != null)
                {
                    Console.WriteLine(t.ToString()); // polymorphism
                    Console.WriteLine(new string('-', 35));
                    any = true;
                }
            }
            if (!any) Console.WriteLine("  No tickets yet.");
        }
    }
}
