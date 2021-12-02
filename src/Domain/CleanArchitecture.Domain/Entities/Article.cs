namespace CleanArchitecture.Domain.Entities {
    using CleanArchitecture.Domain.ValueObjects;
    using Domain.Common;
    using System;
    using System.Collections.Generic;

    public class Article : Entity<int> {

        public Article() {
            AlternativeUnits = new HashSet<ArticleUnit>();
        }

        public string Code { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Unit { get; set; } = string.Empty;

        public ICollection<ArticleUnit> AlternativeUnits { get; private set; }
    }
}
