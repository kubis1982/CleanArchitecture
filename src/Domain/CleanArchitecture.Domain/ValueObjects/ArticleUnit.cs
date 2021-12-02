namespace CleanArchitecture.Domain.ValueObjects {
    using System;

    public class ArticleUnit {
        public ArticleUnit(string unit, UserChanger userChanger) {
            if (string.IsNullOrWhiteSpace(unit)) {
                throw new System.ArgumentException($"'{nameof(unit)}' cannot be null or whitespace.", nameof(unit));
            }

            Unit = unit;
            Created = userChanger;
        }

        public string Unit { get; }

        public UserChanger Created { get; }
    }
}
