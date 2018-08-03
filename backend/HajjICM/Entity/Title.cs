using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the title is a prefix or suffix added to someone's name in certain contexts.
    /// </summary>
    public class Title :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Title"/> class.
        /// </summary>
        public Title()
        { }

        /// <summary>
        /// Gets or sets the people they belongs to this instance.
        /// </summary>
        public IEnumerable<Person> People { get; set; }
    }
}