namespace CleanArchitecture.Domain.ValueObjects {
    public class ArticleUnit {
        public ArticleUnit(string name, string unit) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new System.ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(unit)) {
                throw new System.ArgumentException($"'{nameof(unit)}' cannot be null or whitespace.", nameof(unit));
            }

            Name = name;
            Unit = unit;
        }

        public string Name { get; }

        public string Unit { get; }
    }
}
