namespace CleanArchitecture.Domain.Entities {
    using CleanArchitecture.Domain.ValueObjects;

    public class ArticleUnit {
        public ArticleUnit(string name, string unit, UserChanger userChanger) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(unit)) {
                throw new System.ArgumentException($"'{nameof(unit)}' cannot be null or whitespace.", nameof(unit));
            }

            Name = name;
            Unit = unit;
            Created = userChanger;
        }

        public string Name { get; }

        public string Unit { get; }

        public UserChanger Created { get; }

        public UserChanger? Modified { get; private set; }
    }
}
