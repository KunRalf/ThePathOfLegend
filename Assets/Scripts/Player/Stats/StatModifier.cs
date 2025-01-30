using System;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Player.Stats
{
    [Serializable]
    public class StatModifier
    {
        [field:SerializeField] public string ParentName { get; private set; }
        [field:SerializeField] public float Value { get; private set; }

        public StatModifier(float value)
        {
            Value = value;
        }
    }
}