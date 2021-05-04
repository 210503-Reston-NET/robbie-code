namespace RRModels
{
    /// <summary>
    /// Both a numerical and verbose description given
    /// </summary>
    public class Review
    {
        /// <summary>
        /// This describes the overall numeric rating of a restaurant
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }
        /// <summary>
        /// Verbose description of the aiming experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        /// <summary>
        /// Verbose description of the Review class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"\n\t Rating: {Rating} \n\t Description: {Description}";
        }
    }
}