namespace CleanArchitecture.Domain.ValueObjects {
    using CleanArchitecture.Domain.Common;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserChanger : ValueObject {
        public UserChanger(int userId, DateTime dateTime) {
            UserId = userId;
            DateTime = dateTime;
        }

        public int UserId { get; }

        public DateTime DateTime { get; }

        protected override IEnumerable<object> GetEqualityComponents() {
            yield return UserId;
            yield return DateTime;
        }
    }
}
