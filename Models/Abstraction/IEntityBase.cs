using System;
using System.Collections.Generic;
using System.Text;

namespace Syntra.VDOAP.CProef.Models.Abstraction
{
    public interface IEntityBase
    {
        /// <summary>
        /// The ID for the entities
        /// </summary>
        Guid ID { get; }

        /// <summary>
        /// Date time marker when the entity is created
        /// </summary>
        DateTimeOffset? CreatedAt { get; }

        /// <summary>
        /// Date time marker when the entity has been modified for the last time
        /// </summary>
        DateTimeOffset? ModifiedAt { get; }
    }
}
