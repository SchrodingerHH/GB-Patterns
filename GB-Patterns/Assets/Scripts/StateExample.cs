using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

namespace BehavioralPatterns.State.ExampleFirst
{
    public sealed class Context
    {
        private State state;

        public Context(State state)
        {
            State = state;
        }

        public State State
        {
            set
            {
                state = value;
                Debug.Log("State: " + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }


    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    public sealed class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public sealed class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
