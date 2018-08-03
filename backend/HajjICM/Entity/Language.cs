using System;
using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the language.
    /// </summary>
    public class Language :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Language"/> class.
        /// </summary>
        public Language()
        {
        }

        /// <summary>
        /// Gets or sets the ISO code for language.
        /// </summary>
        /// <value>The ISO code.</value>
        public string ISO { get; set; }

        /// <summary>
        /// Gets or sets the speakers of this instance.
        /// </summary>
        public List<PersonLanguage> Speakers { get; set; }
    }
}