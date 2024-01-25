using System;
using UnityEngine;
using UnityEngine.UI;

namespace Samples.CharacterChooseSample.Scripts
{
    public class DataButton: MonoBehaviour
    {
        [SerializeField] private string dataId;
        [SerializeField] private Button button;

        public Button Button => button;
        public event Action<string> OnDataButtonClick;
        private void OnEnable()
        {
            button.onClick.AddListener(DataButtonClick);
        }
        private void OnDisable()
        {
            button.onClick.RemoveListener(DataButtonClick);
        }
        private void DataButtonClick()
        {
            OnDataButtonClick?.Invoke(dataId);
        }
    }
}