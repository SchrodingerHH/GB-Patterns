using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids.ServiceLocator
{
    public static class ServiceLocatorMonoBehaviour
    {
        private static readonly Dictionary<object, object> serviceContainer;

        static ServiceLocatorMonoBehaviour()
        {
            serviceContainer = new Dictionary<object, object>();
        }

        public static T GetService<T>(bool createObjectIfNotFound = true) where T : Object
        {
            if (!serviceContainer.ContainsKey(typeof(T)))
            {
                return FindService<T>(createObjectIfNotFound);
            }

            var service = (T)serviceContainer[typeof(T)];
            if (service != null)
            {
                return service;
            }

            serviceContainer.Remove(typeof(T));
            return FindService<T>(createObjectIfNotFound);
        }

        private static T FindService<T>(bool createObjectIfNotFound = true) where T: Object
        {
            T type = Object.FindObjectOfType<T>();
            if (type != null)
            {
                serviceContainer.Add(typeof(T), type);
            }
            else if (createObjectIfNotFound)
            {
                var go = new GameObject(typeof(T).Name, typeof(T));
                serviceContainer.Add(typeof(T), go.GetComponent<T>());
            }
            return (T)serviceContainer[typeof(T)];
        }
    }
}