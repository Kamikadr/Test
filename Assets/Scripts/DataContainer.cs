using System;

namespace ChooseAndShowTemplate
{
    public class DataContainer<T>
    {
        private T _currentData;

        public T CurrentData => _currentData;
        public event Action<T> DataChanged;

        public void SetData(T newData)
        {
            _currentData = newData;
            DataChanged?.Invoke(newData);
        }
    }
}