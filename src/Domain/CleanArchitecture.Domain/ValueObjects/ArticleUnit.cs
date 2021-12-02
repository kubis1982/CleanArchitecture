namespace CleanArchitecture.Domain.ValueObjects {
    using CleanArchitecture.Domain.Common;
    using System;
    using System.Collections.Generic;

    public class ArticleUnit : ValueObject {

        public string Unit { get; set; } = string.Empty;

        protected override IEnumerable<object> GetEqualityComponents() {
            yield return new object[] { Unit };
        }
    }
}
