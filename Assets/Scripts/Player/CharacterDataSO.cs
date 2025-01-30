using System.Collections.Generic;
using Player.Stats;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Character/CharacterData", menuName = "Character/CharacterData", order = 0)]
    public class CharacterDataSO : ScriptableObject
    {
        [field:SerializeField] public List<Stat> Stats { get; private set; }
    }
}