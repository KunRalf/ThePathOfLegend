using System;
using System.Collections.Generic;
using Player.Data;
using Player.Stats;
using UnityEngine;

namespace Player
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] private CharacterDataSO _characterDataSO;
        
        private Dictionary<string,Stat> _stats = new Dictionary<string, Stat>();
        
        private void Awake()
        {
            foreach (var stat in _characterDataSO.Stats)
            {
                _stats.Add(stat.Name, new Stat(stat));
            }
        }
    }
}