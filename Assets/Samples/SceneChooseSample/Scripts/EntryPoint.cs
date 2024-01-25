using ChooseAndShowTemplate;
using ChooseAndShowTemplate.Common;
using ChooseAndShowTemplate.UI;
using Samples.Common.SceneChooseSample.Scripts;
using Samples.SceneChooseSample.Scripts.ViewModels;
using UnityEngine;

namespace Samples.SceneChooseSample.Scripts
{
    
    public class EntryPoint: MonoBehaviour
    {
        [SerializeField] private SceneCatalog sceneCatalog;
        [SerializeField] private DataChooseView dataChooseView;
        [SerializeField] private SceneDataViewController sceneDataViewController;
        [SerializeField] private SceneDataView sceneDataViewPrefab;
        
        private void Awake()
        { 
            var sceneDataViewFactory = new ViewFactory<SceneDataView>(sceneDataViewPrefab);
            
            var dataContainer = new DataContainer<SceneData>();
            var sceneListViewModel = new SceneListViewModel(sceneCatalog, dataContainer);
            dataChooseView.Initialize(sceneListViewModel);
            
            var sceneDataViewModel = new SceneDataListenerViewModel(dataContainer);
            sceneDataViewController.Initialize(sceneDataViewModel);
            sceneDataViewController.Compose(sceneDataViewFactory);
             
             


        }
    }
}