using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the person status.
    /// </summary>
    public class PersonStatus :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.PersonStatus"/> class.
        /// </summary>
        public PersonStatus()
        { }

        /// <summary>
        /// Gets or sets the people they belong to this status.
        /// </summary>
        /// <value>The people.</value>
        public List<Person> People { get; set; }
    }
}