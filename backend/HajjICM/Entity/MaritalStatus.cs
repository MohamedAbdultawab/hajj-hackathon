using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the marital status.
    /// </summary>
    public class MaritalStatus :
        EntityBase<int,string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.MaritalStatus"/> class.
        /// </summary>
        public MaritalStatus()
        {
        }

        /// <summary>
        /// Gets or sets the people they belong to this instance.
        /// </summary>
        public IEnumerable<Person> People { get; set; }
    }
}
