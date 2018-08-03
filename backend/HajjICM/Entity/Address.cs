using System;
namespace Entity
{
    /// <summary>
    /// Represents the address.
    /// </summary>
    public class Address : 
        EntityBase<long>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Address"/> class.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Gets or sets the country identifier of this instance.
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the country of this instance.
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Gets or sets the city identifier of this instance.
        /// </summary>
        public int? CityId { get; set; }

        /// <summary>
        /// Gets or sets the city of this instance.
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Gets or sets the district of this instance.
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Gets or sets the street identifier of this instance.
        /// </summary>
        public string Street { get; set; }

		/// <summary>
        /// Gets or sets the building title or number of this instance.
		/// </summary>
		public string Building { get; set; }

        /// <summary>
        /// Gets or sets the building type identifier of this instance.
        /// </summary>
        public int? BuildingTypeId { get; set; }

        /// <summary>
        /// Gets or sets the type of the building of this instance.
        /// </summary>
        public BuildingType BuildingType { get; set; }

        /// <summary>
        /// Gets or sets the floor title or number of this instance.
        /// </summary>
        public string Floor { get; set; }

        /// <summary>
        /// Gets or sets the apartment title or number of this instance.
        /// </summary>
        public string Apartment { get; set; }

        /// <summary>
        /// Gets or sets the postal code of this instance.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the address line 1 of this instance.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2 of this instance.
        /// </summary>
        public string AddressLine2 { get; set; }
	}
}