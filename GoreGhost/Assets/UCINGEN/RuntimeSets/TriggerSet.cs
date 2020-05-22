using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.UCI307.UCINGEN
{
    public abstract class TriggerSet<T> : RuntimeSet<T>
    {
        public GameEvent onFirstEntry;
        public GameEvent onEntry;
        public GameEvent onLastLeave;
        public GameEvent onLeave;

        public override void Add(T t)
        {
            base.Add(t);
            if (Items.Count == 1 && onFirstEntry != null)
            {
                onFirstEntry.Raise();
            }
            if(onEntry != null)
            {
                onEntry.Raise();
            }
        }

        public override void Remove(T t)
        {
            base.Remove(t);
            if (Items.Count == 0 && onLastLeave != null)
            {
                onLastLeave.Raise();
            }
            if (onLeave != null)
            {
                onLeave.Raise();
            }
        }

    }
}
