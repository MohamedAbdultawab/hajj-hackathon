using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the blood group.
    /// </summary>
    public class BloodGroup :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.BloodGroup"/> class.
        /// </summary>
        public BloodGroup()
        {
        }

        /// <summary>
        /// Gets or sets the symbol for blood group.
        /// </summary>
        /// <value>The symbol.</value>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the blood types that belong to this group.
        /// </summary>
        /// <value>The blood types.</value>
        public List<BloodType> BloodTypes { get; set; }
    }
}