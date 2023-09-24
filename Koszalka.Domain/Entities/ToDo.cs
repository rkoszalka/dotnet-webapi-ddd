using Koszalka.Domain.Common;

namespace Koszalka.Domain.Entities
{
    public sealed class ToDo : BaseEntity
    {
        public string Task { get; set; }
        public string Owner { get; set; }
    }
}
