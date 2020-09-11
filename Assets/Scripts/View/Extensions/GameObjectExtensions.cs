using Entitas;
using Services;
using UnityEngine;

namespace View.Extensions
{
    internal static class GameObjectExtensions
    {
        public static GameObject RegisterListeners(this GameObject view, IEntity with)
        {
            foreach (var listener in view.GetComponents<IEventListener>())
                listener.RegisterListeners(with);

            return view;
        }

        public static void UnregisterListeners(this GameObject view, IEntity with)
        {
            foreach (var listener in view.GetComponents<IEventListener>())
                listener.UnregisterListeners(with);
        }
    }
}