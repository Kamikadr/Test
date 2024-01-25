using System;
using UnityEngine;

namespace Samples.Common.SceneChooseSample.Scripts
{
    [Serializable]
    public struct SceneData
    {
        public string name;
        public string description;
        public Sprite picture;
        public int sceneId;
    }
}