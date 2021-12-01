namespace CleanArchitecture.Domain.Entities {
    using CleanArchitecture.Domain.ValueObjects;
    using Domain.Common;
    using System.Collections.Generic;

    public class Article : Entity<int>, IAggregateRoot {
        public Article(string code, string name, string unit, UserChanger user) {
            if (string.IsNullOrWhiteSpace(code)) {
                throw new System.ArgumentException($"'{nameof(code)}' cannot be null or whitespace.", nameof(code));
            }

            if (string.IsNullOrWhiteSpace(name)) {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(unit)) {
                throw new System.ArgumentException($"'{nameof(unit)}' cannot be null or whitespace.", nameof(unit));
            }

            Code = code;
            Name = name;
            Unit = unit;
            Created = user ?? throw new System.ArgumentNullException(nameof(user));

            Units = new List<ArticleUnit>();
        }

        public string Code { get; }

        public string Name { get; }

        public string Unit { get; }

        public UserChanger Created { get; }

        public UserChanger? Modified { get; private set; }

        public ICollection<ArticleUnit> Units { get; }
    }
}
