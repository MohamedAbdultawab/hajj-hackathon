using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the person category.
    /// </summary>
    public class PersonCategory :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.PersonCategory"/> class.
        /// </summary>
        public PersonCategory()
        {
        }

        /// <summary>
        /// Gets or sets the people they belong to this category.
        /// </summary>
        /// <value>The people.</value>
        public List<Person> People { get; set; }
    }
}
