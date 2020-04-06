using System;

namespace Lesson1
{
    public abstract class EntityBase
    {
        public long Id { get; private set; }

        public EntityBase()
        {
            Id = CalcId();
        }

        private long CalcId()
        {
            return DateTime.Now.Ticks;
        }
    }
}
