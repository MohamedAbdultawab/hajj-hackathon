using System;
namespace Entity
{
    /// <summary>
    /// Represents the campaign.
    /// </summary>
    public class Campaign : 
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Campaign"/> class.
        /// </summary>
        public Campaign()
        {
        }

        /// <summary>
        /// Gets or sets the supervisor identifier of this instance.
        /// </summary>
        public int? SupervisorId { get; set; }

        /// <summary>
        /// Gets or sets the supervisor of this instance.
        /// </summary>
        public Person Supervisor { get; set; }

        /// <summary>
        /// Gets or sets the people number.
        /// </summary>
        /// <value>The people number.</value>
        public int PeopleNumber { get; set; }
    }
}
