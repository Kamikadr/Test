using System;
using System.Collections.Generic;
using System.Linq;
using Samples.CharacterChooseSample.Scripts;
using UnityEngine;

namespace ChooseAndShowTemplate
{
    public abstract class LoadableDataCatalog<T>: ScriptableObject, ILoadDataService<T>, ISerializationCallbackReceiver
    {
        [SerializeField] private KeyPathPair[] dataPathCollection;
        private Dictionary<string, string> _dataPathMap;

        public IEnumerable<T> GetAllData()
        {
            for (var i = 0; i < _dataPathMap.Count; i++)
            {
                var data = LoadData(dataPathCollection[i].path);
                yield return data.value;
            }
        }
        public T GetData(string id)
        {
            if (_dataPathMap.TryGetValue(id, out var path))
            {
                var data = LoadData(path);
                return data.value;
            }
            
            throw new Exception($"Data with {id} key is not found");
        }

        private BaseDataConfig<T> LoadData(string path)
        {
            var data = Resources.Load<BaseDataConfig<T>>(path);
            if (data == null)
            {
                throw new Exception($"Path {path} for {typeof(T).Name} data is incorrect");
            }

            return data;
        }

        public void OnAfterDeserialize()
        {
            _dataPathMap = dataPathCollection.ToDictionary(it => it.key, it => it.path);
        }
        
        public void OnBeforeSerialize()
        {
        }
    }
    

    public interface ILoadDataService<out T>
    {
        IEnumerable<T> GetAllData();
        T GetData(string id);
    }

    [Serializable]
    public struct KeyPathPair
    {
        public string key;
        public string path;
    } 
}