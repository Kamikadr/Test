using UnityEngine;

namespace ChooseAndShowTemplate
{
    public abstract class BaseDataConfig<T>: ScriptableObject
    {
        [SerializeField] public T value;
    }
}