using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.ServiceLocator
{
    internal sealed class ExampleServiceLocator : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.SetService<IService>(new Service());
        }

        private void Start()
        {
            ServiceLocator.Resolve<IService>().Test();
        }
    }
}