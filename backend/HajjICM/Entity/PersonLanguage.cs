namespace Entity
{
    /// <summary>
    /// Represents the language for person.
    /// </summary>
    public class PersonLanguage : 
        EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.PersonLanguage"/> class.
        /// </summary>
        public PersonLanguage()
        {
        }

        /// <summary>
        /// Gets or sets the person identifier of this instance.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the person of this instance.
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Gets or sets the language identifier of this instance.
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or sets the language of this instance.
        /// </summary>
        public Language Language { get; set; }
    }
}
