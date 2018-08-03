using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the city.
    /// </summary>
    public class City : 
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.City"/> class.
        /// </summary>
        public City()
        {
        }

        /// <summary>
        /// Gets or sets the country identifier that this instance belongs.
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the country that this instance belongs.
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Gets or sets the population they belongs to this instance.
        /// </summary>
        public List<Person> Population { get; set; }
    }
}