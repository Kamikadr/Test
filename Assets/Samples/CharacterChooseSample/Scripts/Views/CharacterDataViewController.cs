using ChooseAndShowTemplate.Common;
using ChooseAndShowTemplate.UI;
using Samples.Common.CharacterChooseSample.Scripts;

namespace Samples.CharacterChooseSample.Scripts
{
    public sealed class CharacterDataViewController: BaseDataViewController<CharacterDataViewModel>
    {
        private CharacterDataView _characterDataView;
        private ViewFactory<CharacterDataView> _factory;

        public void Compose(ViewFactory<CharacterDataView> factory)
        {
            _factory = factory;
        }

        protected override void OnViewModelChanged(CharacterDataViewModel data)
        {
            if (_characterDataView == null)
            {
                _characterDataView = _factory.Create(transform);
            }
            _characterDataView.Initialize(data);
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            if (_characterDataView != null)
            {
                Destroy(_characterDataView.gameObject);
                _characterDataView = null;
            }
        }
    }
}