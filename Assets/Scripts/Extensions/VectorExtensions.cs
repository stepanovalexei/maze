﻿using UnityEngine;

namespace Extensions
{
    public static class VectorExtensions
    {
        public static Vector2 AddX(this Vector2 self, float xDelta)
        {
            var temporary = self;
            temporary.x += xDelta;
            self = temporary;
            return self;
        }

        public static Vector2 AddY(this Vector2 v, float yDelta)
        {
            var tmp = v;
            tmp.y += yDelta;
            v = tmp;
            return v;
        }
        
        public static Vector3 SetX(this Vector3 v, float x)
        {
            var tmp = v;
            tmp.x = x;
            v = tmp;
            return v;
        }
    }
    
}