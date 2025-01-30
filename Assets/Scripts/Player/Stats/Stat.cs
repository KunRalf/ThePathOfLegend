using System;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Stats
{
    [Serializable]
    public class Stat
    {
        [field:SerializeField] public string Name { get; private set; }
        [field: SerializeField] public List<StatModifier> modifiers { get; private set; } = new List<StatModifier>();
        [field: SerializeField]public float Value { get; private set; }
    }
}