namespace CleanArchitecture.Domain.ValueObjects {
    using CleanArchitecture.Domain.Common;
    using System;
    using System.Collections.Generic;

    public class UserChanger : ValueObject {

        public UserChanger(int userId, DateTime dateTime) {
            UserId = userId;
            DateTime = dateTime;
        }

        public int UserId { get; private set; }

        public DateTime DateTime { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents() {
            yield return UserId;
            yield return DateTime;
        }
    }
}
