using ChooseAndShowTemplate.Interfaces;
using Samples.CharacterChooseSample.Scripts;
using UnityEngine;

namespace ChooseAndShowTemplate.UI
{
    public class DataChooseView: MonoBehaviour
    {
        private DataButton[] _dataButtons;
        private IChooseDataViewModel _viewModel;

        public void Initialize(IChooseDataViewModel viewModel)
        {
            _viewModel = viewModel;
        } 
        private void Awake()
        {
            _dataButtons = gameObject.GetComponentsInChildren<DataButton>();
        }

        private void OnEnable()
        {
            foreach (var button in _dataButtons)
            {
                button.OnDataButtonClick += ButtonClick;
            }
        }

        private void OnDisable()
        {
            foreach (var button in _dataButtons)
            {
                button.OnDataButtonClick -= ButtonClick;
            }
        }

        private void ButtonClick(string dataId)
        {
            _viewModel?.Select(dataId);
        }
    }
}