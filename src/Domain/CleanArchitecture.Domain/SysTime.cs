namespace CleanArchitecture.Domain {
    using CleanArchitecture.Domain.Entities;
    using CleanArchitecture.Domain.Services;
    using System;

    public class SysTime {
        public static Func<DateTime> CurrentTimeProvider { get; set; } = () => DateTime.Now;

        public static DateTime Now() => CurrentTimeProvider();
    }
}
