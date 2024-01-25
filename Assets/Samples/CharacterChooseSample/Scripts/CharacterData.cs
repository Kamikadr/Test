using System;
using UnityEngine;

namespace Samples.Common.CharacterChooseSample.Scripts
{
    [Serializable]
    public sealed class CharacterData
    {
        public int Level;
        public string Name;
        public Sprite Icon;
        public GameObject Prefab;
    }
}