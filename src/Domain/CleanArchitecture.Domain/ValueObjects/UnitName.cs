namespace CleanArchitecture.Domain.ValueObjects {
    using System;

    public record UnitName {
        private UnitName() {
            Name = string.Empty;
        }

        public UnitName(string name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            Name = name;
        }

        public string Name { get; }

        public static implicit operator string(UnitName unit) => unit.Name;

        public static explicit operator UnitName(string unit) => new(unit);
    }
}
