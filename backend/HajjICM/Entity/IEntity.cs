using System;
using System.Xml.Linq;

namespace Entity
{
    /// <summary>
    /// Represents the base interface for entities.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the unique code.
        /// </summary>
        string Code { get; set; }
    }

    /// <summary>
    /// Represents the base interface with specific key. 
    /// </summary>
    /// <typeparam name="TKey">The type of key.</typeparam>
    public interface IEntity<TKey> : IEntity
        where TKey : struct
    {
        /// <summary>
        /// Gets or sets a key.
        /// </summary>
        TKey Id { get; set; }
    }

    /// <summary>
    /// Represents the base interface with specific key and unique name. 
    /// </summary>
    /// <typeparam name="TKey">The type of key.</typeparam>
    /// <typeparam name="TName">Type type of unique name.</typeparam>
    public interface IEntity<TKey, TName> : IEntity<TKey>
        where TKey : struct
    {
        /// <summary>
        /// Gets or sets the unique name.
        /// </summary>
        TName Name { get; set; }
    }
}