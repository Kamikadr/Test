using System;
using ChooseAndShowTemplate;
using ChooseAndShowTemplate.Interfaces;
using Samples.Common.SceneChooseSample.Scripts;

namespace Samples.SceneChooseSample.Scripts.ViewModels
{
    public class SceneDataListenerViewModel: IListenDataViewModel<SceneDataViewModel>
    {
        private readonly DataContainer<SceneData> _container;
        private SceneDataViewModel _sceneDataViewModel;
        public event Action<SceneDataViewModel> OnViewModelChanged;

        public SceneDataListenerViewModel(DataContainer<SceneData> container)
        {
            _container = container;
            _container.DataChanged += HandleDataChanged;
        }
        private void HandleDataChanged(SceneData data)
        {
            _sceneDataViewModel = new SceneDataViewModel(data);
            OnViewModelChanged?.Invoke(_sceneDataViewModel);
        }
        
    }
}