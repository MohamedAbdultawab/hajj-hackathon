using System;

namespace Entity
{
    /// <summary>
    /// Represents resources that have timestamp fields.
    /// </summary>
    public interface IAuditable
    {
        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the creator identity of creator.
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the modification date.
        /// </summary>
        DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the identity of modifier.
        /// </summary>
        string ModifiedBy { get; set; }
    }
}