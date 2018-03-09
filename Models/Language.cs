using System;
using System.Collections.Generic;
using System.Text;

namespace Syntra.VDOAP.CProef.Models
{
    public class Language : Abstraction.ILanguage
    {
        public Guid ID { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }

        public DateTimeOffset? ModifiedAt { get; set; }
    }
}
