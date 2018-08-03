using System;
namespace Entity
{
    /// <summary>
    /// Represents the base class for entities.
    /// </summary>
    public abstract class EntityBase :
        IEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.EntityBase"/> class.
        /// </summary>
        public EntityBase()
        {
        }

        /// <summary>
        /// Gets or sets the unique code.
        /// </summary>
        /// <value>The unique code.</value>
        public virtual string Code { get; set; }
    }

    /// <summary>
    /// Represents the base class for entities with a specific primary key type.
    /// </summary>
    public abstract class EntityBase<TKey> :
        EntityBase, 
        IEntity<TKey>
        where TKey : struct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.EntityBase`1"/> class.
        /// </summary>
        public EntityBase()
        { }

        public TKey Id { get; set; }
    }

    /// <summary>
    /// Represents the base class for entities with a specific primary key type.
    /// </summary>
    public abstract class EntityBase<TKey, TName> :
        EntityBase<TKey>,
        IEntity<TKey, TName>
        where TKey : struct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Entity.EntityBase`2"/> class.
        /// </summary>
        public EntityBase()
        { }

        public TName Name {get; set; }
    }
}