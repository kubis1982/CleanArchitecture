namespace CleanArchitecture.Domain.Entities.Articles {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArticleException : Exception {
        public ArticleException(string message) : base(message) {
        }
    }
}
