namespace CleanArchitecture.Domain.ValueObjects {
    using System;

    public record ArticleCode {
        public ArticleCode(string text) {
            if (string.IsNullOrWhiteSpace(text)) {
                throw new ArgumentException($"'{nameof(text)}' cannot be null or whitespace.", nameof(text));
            }

            Text = text;
        }

        public string Text { get; }

        public static implicit operator string(ArticleCode code) => code.Text;

        public static explicit operator ArticleCode(string text) => new(text);
    }
}
