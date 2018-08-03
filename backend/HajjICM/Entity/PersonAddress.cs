using System;
namespace Entity
{
    /// <summary>
    /// Represents the address for person.
    /// </summary>
    public class PersonAddress : 
        EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.PersonAddress"/> class.
        /// </summary>
        public PersonAddress()
        {
        }

        /// <summary>
        /// Gets or sets the person identifier of this instance.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the person of this instance.
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Gets or sets the address identifier of this instance.
        /// </summary>
        public long AddressId { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public Address Address { get; set; }


        /// <summary>
        /// Gets or sets the address type identifier.
        /// </summary>
        /// <value>The address type identifier.</value>
        public int TypeId { get; set; }

        /// <summary>
        /// Gets or sets the type of the address.
        /// </summary>
        /// <value>The address type.</value>
        public AddressType Type { get; set; }

        /// <summary>
        /// Gets or sets the address status identifier.
        /// </summary>
        /// <value>The address status identifier.</value>
        public int? StatusId { get; set; }
    }
}