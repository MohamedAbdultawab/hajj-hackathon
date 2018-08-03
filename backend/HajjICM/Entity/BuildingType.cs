using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the building type.
    /// </summary>
    public class BuildingType :
    EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.BuildingType"/> class.
        /// </summary>
        public BuildingType()
        {
        }

        /// <summary>
        /// Gets or sets the addresses they belong to this instance.
        /// </summary>
        public List<Address> Addresses { get; set; }
    }
}