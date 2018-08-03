using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the doctrine.
    /// </summary>
    public class Doctrine : 
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Doctrine"/> class.
        /// </summary>
        public Doctrine()
        {
        }

        /// <summary>
        /// Gets or sets the people they belong to this instance.
        /// </summary>
        public IEnumerable<Person> People { get; set; }
    }
}
