using ChooseAndShowTemplate.Common;
using ChooseAndShowTemplate.UI;
using UnityEngine;

namespace Samples.SceneChooseSample.Scripts.ViewModels
{
    public class SceneDataViewController: BaseDataViewController<SceneDataViewModel>
    {
        [SerializeField] private Transform viewContainer;
        private ViewFactory<SceneDataView> _factory;
        private SceneDataView _sceneDataView;

        public void Compose(ViewFactory<SceneDataView> factory)
        {
            _factory = factory;
        }

        protected override void OnViewModelChanged(SceneDataViewModel viewModel)
        {
            if (_sceneDataView == null)
            {
                _sceneDataView = _factory.Create(viewContainer);
            }
            _sceneDataView.Initialize(viewModel);
        }
    }
}