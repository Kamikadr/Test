using ChooseAndShowTemplate;
using ChooseAndShowTemplate.Common;
using ChooseAndShowTemplate.UI;
using Samples.Common.CharacterChooseSample.Scripts;
using UnityEngine;

namespace Samples.CharacterChooseSample.Scripts
{
    public class EntryPoint: MonoBehaviour
    {
        [SerializeField] private CharacterCatalog characterCatalog;
        [SerializeField] private CharacterDataViewController characterDataViewController;
        [SerializeField] private DataChooseView dataChooseView;
        [SerializeField] private CharacterDataView characterDataViewPrefab;
        private void Awake()
        {
            var characterDataViewFactory = new ViewFactory<CharacterDataView>(characterDataViewPrefab);
            
            var characterContainer = new DataContainer<CharacterData>();
            var characterListPresenter = new CharacterListViewModel(characterCatalog, characterContainer);
            dataChooseView.Initialize(characterListPresenter);


            var characterDataListener = new CharacterDataListenerViewModel(characterContainer);
            characterDataViewController.Compose(characterDataViewFactory);
            characterDataViewController.Initialize(characterDataListener);
        }
    }
}