using System;
using System.Collections.Generic;
namespace Entity
{
    /// <summary>
    /// Represents the Mansik of the Hajj.
    /// </summary>
    public class Mansik :
        EntityBase<int, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.Mansak"/> class.
        /// </summary>
        public Mansik()
        {
        }

        /// <summary>
        /// Gets or sets the order of this instance.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the start date and time of this instance.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of this instance.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the longitude of this instance.
        /// </summary>
        public float Longitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude of this instance.
        /// </summary>
        public float Latitude { get; set; }
    }
}