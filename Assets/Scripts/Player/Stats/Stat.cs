using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Player.Stats
{
    [Serializable]
    public class Stat
    {
        [field:SerializeField] public string Name { get; private set; }
        [field: SerializeField] public List<StatModifier> Modifiers { get; private set; }
        
        [field:SerializeField] public float BaseValue { get; private set; }
        public float Value => BaseValue + Modifiers.Sum(_ => _.Value);

        public Stat(Stat stat)
        {
            Name = stat.Name;
            BaseValue = stat.BaseValue;
            Modifiers = stat.Modifiers.ToList();
        }
        
        public void AddModifier(StatModifier modifier)
        {
            Modifiers.Add(modifier);
        }
    }
}