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

        }
    }
}
