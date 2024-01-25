using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Samples.Common.CharacterChooseSample.Scripts
{
    public class CharacterDataView: MonoBehaviour
    {
        [SerializeField] private TMP_Text levelText;
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private Image icon;
        [SerializeField] private Transform modelContainer;
        private GameObject _model;
        

        public void Initialize(CharacterDataViewModel data)
        {
            Clear();
            nameText.text = data.Name;
            icon.sprite = data.Icon;
            levelText.text = data.Level;
            _model = Instantiate(data.Model, modelContainer);
        }

        private void Clear()
        {
            if (_model != null)
            {
                Destroy(_model);
                _model = null;
            }
        }
    }

    public class CharacterDataViewModel
    {
        private readonly CharacterData _data;
        public string Name => _data.Name;
        public string Level => $"Level: {_data.Name}";
        public Sprite Icon => _data.Icon;
        public GameObject Model => _data.Prefab;

        public CharacterDataViewModel(CharacterData data)
        {
            _data = data;
        }
    }
}