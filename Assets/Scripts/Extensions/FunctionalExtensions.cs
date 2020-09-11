using System;

namespace Extensions
{
    internal static class FunctionalExtensions
    {
        public static T Do<T>(this T self, Action<T> @this, bool when)
        {
            if (when)
                @this?.Invoke(self);

            return self;
        }
        
        public static T With<T>(this T self, Action<T> set)
        {
            set.Invoke(self);
            return self;
        }
    }
}