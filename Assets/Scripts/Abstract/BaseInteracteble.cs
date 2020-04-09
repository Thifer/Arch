
    using System;
    using UnityEngine;

    public abstract class BaseInteracteble : MonoBehaviour, IHaveHP
    {

        public abstract void SetValue(float value);
        
        public float hp { get; set; }
    }

