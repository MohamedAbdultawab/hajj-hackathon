using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the blood type.
    /// </summary>
    public class BloodType :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.BloodType"/> class.
        /// </summary>
        public BloodType()
        {
        }

        /// <summary>
        /// Gets or sets the symbol of this instance.
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the blood group identifier of this instance.
        /// </summary>
        public int GroupId { get; set; }

        /// <summary>
        /// Gets or sets the blood group of this instance.
        /// </summary>
        public BloodGroup Group { get; set; }

        /// <summary>
        /// Gets or sets the people they belong to this instance.
        /// </summary>
        public List<Person> People { get; set; }
    }
}