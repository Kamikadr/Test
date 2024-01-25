using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Samples.SceneChooseSample.Scripts.ViewModels
{
    public class SceneDataView: MonoBehaviour
    {
        [SerializeField] private Button openSceneButton;
        [SerializeField] private Button closeSceneButton;
        [SerializeField] private TMP_Text sceneName;
        [SerializeField] private TMP_Text description;
        [SerializeField] private Image image;
        
        private SceneDataViewModel _viewModel;

        public void Initialize(SceneDataViewModel viewModel)
        {
            _viewModel = viewModel;
            sceneName.text = viewModel.SceneName;
            description.text = viewModel.SceneDesc;
            image.sprite = viewModel.ScenePicture;
        }

        private void Awake()
        {
            openSceneButton.gameObject.SetActive(true);
            closeSceneButton.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            openSceneButton.onClick.AddListener(LoadScene);
        }

        private void LoadScene()
        {
            _viewModel.LoadScene();
            openSceneButton.gameObject.SetActive(false);
            closeSceneButton.gameObject.SetActive(true);
            
            openSceneButton.onClick.RemoveListener(LoadScene);
            closeSceneButton.onClick.AddListener(UnloadScene);
        }
        private void UnloadScene()
        {
            _viewModel.UnloadScene();
            openSceneButton.gameObject.SetActive(true);
            closeSceneButton.gameObject.SetActive(false);
            
            closeSceneButton.onClick.RemoveListener(UnloadScene);
            openSceneButton.onClick.AddListener(LoadScene);
        }

        private void OnDisable()
        {
            openSceneButton.onClick.RemoveListener(LoadScene);
            closeSceneButton.onClick.RemoveListener(UnloadScene);
        }
    }
}