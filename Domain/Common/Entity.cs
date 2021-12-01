namespace CleanArchitecture.Domain.Common {
    using System;
    using System.Collections.Generic;

    public abstract class Entity<T> {

        public T Id { get; private set; }

        public override bool Equals(object obj) {
            return obj is Entity<T> entity &&
                   EqualityComparer<T>.Default.Equals(Id, entity.Id);
        }

        public override int GetHashCode() {
            return HashCode.Combine(Id);
        }
    }
}
