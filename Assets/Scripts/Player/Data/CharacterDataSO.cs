using System.Collections.Generic;
using System.Linq;
using Player.Stats;
using UnityEngine;

namespace Player.Data
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Character/CharacterData", order = 0)]
    public class CharacterDataSO : ScriptableObject
    {
        [field:SerializeField] public string Name { get; private set; }
        [field:SerializeField] public PlayerController Prefab { get; private set; }
        [field:SerializeField] public List<Stat> Stats { get; private set; }

    
    }
}