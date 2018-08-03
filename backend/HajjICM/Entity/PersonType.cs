using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the person type.
    /// </summary>
    public class PersonType : 
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.PersonType"/> class.
        /// </summary>
        public PersonType()
        {
        }

        /// <summary>
        /// Gets or sets the people they belong to this type.
        /// </summary>
        /// <value>The people.</value>
        public List<Person> People { get; set; }
    }
}