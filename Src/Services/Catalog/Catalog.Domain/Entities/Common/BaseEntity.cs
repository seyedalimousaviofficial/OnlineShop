using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Entities.Common
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
