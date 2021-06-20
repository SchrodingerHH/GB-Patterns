using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.ServiceLocator
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> serviceContainer = new Dictionary<Type, object>();

        public static void SetService<T>(T value) where T : class
        {
            var typeValue = typeof(T);
            if (!serviceContainer.ContainsKey(typeValue))
            {
                serviceContainer[typeValue] = value;
            }
        }

        public static T Resolve<T>()
        {
            var type = typeof(T);
            if (serviceContainer.ContainsKey(type))
            {
                return (T)serviceContainer[type];
            }
            return default;
        }
    }
}
