using System;
using ChooseAndShowTemplate;
using ChooseAndShowTemplate.Interfaces;
using Samples.Common.CharacterChooseSample.Scripts;


namespace Samples.CharacterChooseSample.Scripts
{
    public class CharacterDataListenerViewModel: IListenDataViewModel<CharacterDataViewModel>
    {
        private readonly DataContainer<CharacterData> _dataContainer;
        private CharacterDataViewModel _characterDataViewModel;
        
        public event Action<CharacterDataViewModel> OnViewModelChanged;
        
        public CharacterDataListenerViewModel(DataContainer<CharacterData> dataContainer)
        {
            _dataContainer = dataContainer;
            _dataContainer.DataChanged += DataChangeListener;
        }

        private void DataChangeListener(CharacterData data)
        {
            _characterDataViewModel = new CharacterDataViewModel(data);
            OnViewModelChanged?.Invoke(_characterDataViewModel);
        }
    }
}