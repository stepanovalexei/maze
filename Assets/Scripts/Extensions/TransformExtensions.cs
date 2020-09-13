using UnityEngine;

namespace Extensions
{
    public static class TransformExtensions
    {
        public static Transform LocalScaleX(this Transform transform, float x)
        {
            transform.localScale = transform.localScale.SetX(x);
            return transform;
        }
    }
}