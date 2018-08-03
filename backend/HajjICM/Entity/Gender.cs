using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the gender.
    /// </summary>
    public class Gender :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Gender"/> class.
        /// </summary>
        public Gender()
        {
        }

        /// <summary>
        /// Gets or sets the people they belong to this instance.
        /// </summary>
        public IEnumerable<Person> People { get; set; }
    }
}
