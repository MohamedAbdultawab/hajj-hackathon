using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the address type.
    /// </summary>
    public class AddressType : 
        EntityBase<int, string>
    {
		/// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.AddressType"/> class.
        /// </summary>
		public AddressType()
        {
        }

        /// <summary>
        /// Gets or sets the addresses that belong to this instance.
        /// </summary>
        public List<PersonAddress> Addresses { get; set; }

    }
}