/// <summary>
///  Namespace for the models/custom data structures involved in Restaurant Reviews
/// </summary>
namespace RRModels
{
    /// <summary>
    ///  Data structure used to define a restraunt
    /// </summary>
    public class Restaurant
    {
        // Class Members
        // 1. Constructor - use this to create an instance of the class
        // 2. Fields - defines the characteristics of a class
        // 3. Methods - defines the behavior of a class
        // 4. Properties* - also known as smart fields, accessor methods, used to acces private backing fields (private fields for short).
        // *Note this is special to C#. Also, note that properties are analogous to Java getter and setter.
        // Property naming conventions use PascalCase (like the methods)

        /// <summary>
        /// Instantiates an Object of the Class 'Restaurant'
        /// </summary>
        /// <param name="name">Sets the name of the city</param>
        /// <param name="city">Sets the city the restaurant is located in</param>
        /// <param name="state">Sets the state that the restaurant is located</param>
        public Restaurant(string name, string city, string state){
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        /// <summary>
        /// This describes the name of your restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Describes the location of restaurant
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        /// Describes the location of the restaurant
        /// </summary>
        /// <value></value>
        public string State { get; set;}
        /// <summary>
        /// Contains the review for a particular restaurant
        /// </summary>
        /// <value></value>
        public Review Review { get; set; }

        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State} \n Review: {Review.ToString()}";
        }
    }
}