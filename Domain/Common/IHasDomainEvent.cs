namespace Domain.Common {
    using System.Collections.Generic;

    public interface IHasDomainEvent {
        public ICollection<DomainEvent> DomainEvents { get; set; }
    }
}
