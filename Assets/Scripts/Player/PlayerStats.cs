using System;
using System.Collections.Generic;
using Player.Stats;
using UnityEngine;

namespace Player
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] private CharacterDataSO _characterDataSO;
        
        private Dictionary<string,Stat> _stats;
    
        
        
        private void Awake()
        {
            foreach (var stat in _characterDataSO.Stats)
            {
                _stats.Add(stat.Name, stat);
            }
        }
    }
}