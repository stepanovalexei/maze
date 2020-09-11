using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Extensions
{
    public static class EnumerableExtensions
    {
        public static T PickRandom<T>(this IEnumerable<T> collection)
        {
            var enumerable = collection as T[] ?? collection.ToArray();
            return enumerable[Random.Range(0, enumerable.Length)];
        }

    }
}