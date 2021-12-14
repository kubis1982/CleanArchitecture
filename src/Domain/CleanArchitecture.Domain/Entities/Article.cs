namespace CleanArchitecture.Domain.Entities {
    using CleanArchitecture.Domain.Exception;
    using CleanArchitecture.Domain.ValueObjects;
    using Domain.Common;
    using System.Collections.Generic;

    public class Article : Entity<int> {
        private ArticleCode code;
        private string name;
        private UnitName unit;
        private HashSet<ArticleUnit> alternativeUnits = new HashSet<ArticleUnit>();

        public Article(ArticleCode code, string name, UnitName unit) {
            this.code = code;
            this.name = name;
            this.unit = unit;
        }

        public ArticleCode Code => code;

        public string Name => name;

        public UnitName Unit => unit;

        public IReadOnlyCollection<ArticleUnit> AlternativeUnits => alternativeUnits;

        public void AddUnit(ArticleUnit articleUnit) {
            if (articleUnit.Unit == Unit) {
                throw new ArticleException("Asortyment posiada jako jednostkę główną wskazaną jednostkę alternatywną.");
            }

            if (!alternativeUnits.Add(articleUnit)) {
                throw new ArticleException("Asortyment posiada jednostkę alternatywną.");
            }
        }
    }
}
