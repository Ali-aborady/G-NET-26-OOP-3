using System.Security.AccessControl;

namespace ThirdApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 — Type of Relationship

            //a) University -> Departments -> Composition 

            //If University dies -> Departments die too
            //The Department cannot exist without the University
            //Strong ownership = Composition

            //b) Driver -> Car -> Dependency 

            //Driver only uses the car temporarily(inside a method)
            //No ownership at all
            //Weakest relationship = Dependency

            //c) Dog -> Animal -> Inheritance 

            //"is-a" relationship
            //Dog is an Animal

            //d) Team -> Players -> Aggregation 

            //Team has Players, but Players can exist without the Team
            //Weak ownership = Aggregation

            //e) Method receives Logger as parameter → Dependency 

            //Logger is used only inside the method scope
            //No field, no ownership = Dependency

            #endregion

            #region Q2 — Access Modifiers & Sealed

            //a) protected field — can child in different assembly access it?
            //Yes — a child class in a different assembly can access 
            //protected field through inheritance

            //No — an object instance from outside the class (even same assembly) 
            //cannot access it directly


            //b) protected internal vs private protected
            //Both Can Accessible in  child class .

            //Accessible from same assembly in protected internal --> Yes(non- child too)
            //Accessible from same assembly in private protected --> No(must be child)

            //c) sealed on a class vs on a method
            //On a class  -> nobody can inherit from it
            //On a method -> child classes cannot override it further(stops override chain)

            //d) Can you create an object from a sealed class?
            //Yes! sealed only prevents inheritance — it does NOT prevent instantiation
            //new SealedClass() is perfectly valid
            #endregion

            #region Part 02 — Practical: Movie Ticket Booking System
            //a) Create Cinema and open it 
            Cinema cinema = new Cinema("Grand Cinema");
            cinema.OpenCinema();

            //b) Create one of each ticket type
            StandardTicket s = new StandardTicket(
                movieName: "Avengers",
                price: 150m,
                seatNumber: "B5"
            );

            VipTicket v = new VipTicket(
                movieName: "Inception",
                price: 300m,
                loungeAccess: true
            );

            IMaxTicket im = new IMaxTicket(
                movieName: "Dune",
                price: 200m,
                is3D: true      // price becomes 200 + 30 = 230
            );

            //Add all tickets to Cinema
            cinema.AddTicket(s);
            cinema.AddTicket(v);
            cinema.AddTicket(im);

            //c) Print all tickets
            cinema.PrintAllTickets();

            //Total tickets created
            Console.WriteLine($"\n Total Tickets Created: {Ticket.GetTotalTickets()}");

            //d) Close Cinema 
            cinema.CloseCinema();


            #endregion
        }
    }
}
