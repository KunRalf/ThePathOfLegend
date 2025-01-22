using System;
using UnityEngine;

namespace Player.Data
{
    [Serializable]
    public struct CharacterStats
    {
        [field:SerializeField] public float Health { get; private set; }
        [field:SerializeField] public float MoveSpeed { get; private set; }
        
        [field:SerializeField, Range(0,100)] public float FireResist { get; private set; }
        [field:SerializeField, Range(0,100)] public float FrostResist { get; private set; }
        [field:SerializeField, Range(0,100)] public float PoisonResist { get; private set; }

        public void AddFireResist()
        {
            FireResist -= 5;
        }
    }
}