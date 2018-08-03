using System.Collections.Generic;
namespace Entity
{
	/// <summary>
	/// Represents the reason of death.
	/// </summary>
	public class DeathReason :  
        EntityBase<int,string>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Entity.DeathReason"/> class.
		/// </summary>
		public DeathReason()
		{
		}

        /// <summary>
        /// Gets or sets the people they belong to this instance.
        /// </summary>
        public List<Person> People { get; set; }
	}
}