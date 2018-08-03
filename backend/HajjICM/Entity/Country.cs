using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the country.
    /// </summary>
    public class Country : 
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Country"/> class.
        /// </summary>
        public Country()
        {
        }

		/// <summary>
        /// Gets or sets the ISO code of this instance.
		/// </summary>
		public string ISO { get; set; }

		/// <summary>
        /// Gets or sets the population nationality of this instance.
		/// </summary>
		public string Nationality { get; set; }

		/// <summary>
		/// Gets or sets the population of this instance.
		/// </summary>
		public List<Person> Population { get; set; }

        /// <summary>
        /// Gets or sets the cities they belong to this instance.
        /// </summary>
        public List<City> Cities { get; set; }
    }
}