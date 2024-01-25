using System.Collections.Generic;
using ChooseAndShowTemplate.Interfaces;

namespace ChooseAndShowTemplate
{
    public abstract class DataLoader<T>: IChooseDataViewModel
    {
        private readonly ILoadDataService<T> _dataService;
        private readonly Dictionary<string, T> _loadedDataCollection;

        protected DataLoader(ILoadDataService<T> dataService)
        {
            _dataService = dataService;
            _loadedDataCollection = new Dictionary<string, T>();
        }

        public void Select(string id)
        {
            if (_loadedDataCollection.TryGetValue(id, out var data))
            {
                SelectData(data);
            }
            else
            {
                data = _dataService.GetData(id);
                _loadedDataCollection.Add(id, data);
                SelectData(data);
            }
        }

        protected abstract void SelectData(T data);
    }
}