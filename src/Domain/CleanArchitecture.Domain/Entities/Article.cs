namespace CleanArchitecture.Domain.Entities {
    using CleanArchitecture.Domain.ValueObjects;
    using Domain.Common;
    using System;
    using System.Collections.Generic;

    public class Article : Entity<int> {
        private HashSet<ArticleUnit> units = new();

        private Article() {
        }

        public string Code { get; private set; } = string.Empty;

        public string Name { get; private set; } = string.Empty;

        public string Unit { get; private set; } = string.Empty;

        public UserChanger Created { get; private set; } = new(0, DateTime.Now);

        public IReadOnlyCollection<ArticleUnit> Uses => units;

        public void AddUnit(string unit, UserChanger userChanger) {
            units.Add(new ArticleUnit(unit, userChanger));
        }

        public static Article Create(string code, string name, string unit, UserChanger userChanger) {
            if (string.IsNullOrWhiteSpace(code)) {
                throw new System.ArgumentException($"'{nameof(code)}' cannot be null or whitespace.", nameof(code));
            }

            if (string.IsNullOrWhiteSpace(name)) {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(unit)) {
                throw new System.ArgumentException($"'{nameof(unit)}' cannot be null or whitespace.", nameof(unit));
            }

            return new Article {
                Code = code,
                Name = name,
                Unit = unit,
                Created = userChanger
            };
        }
    }
}
