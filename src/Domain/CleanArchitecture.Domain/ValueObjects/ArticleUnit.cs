namespace CleanArchitecture.Domain.ValueObjects {
    public record ArticleUnit {
        public ArticleUnit(UnitName unit) {
            Unit = unit;
        }

        public UnitName Unit { get; }
    }
}
