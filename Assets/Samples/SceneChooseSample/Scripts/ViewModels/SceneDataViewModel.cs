using Samples.Common.SceneChooseSample.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Samples.SceneChooseSample.Scripts.ViewModels
{
    public class SceneDataViewModel
    {
        private readonly SceneData _data;
        public string SceneName => _data.name;
        public string SceneDesc => _data.description;
        public Sprite ScenePicture => _data.picture;

        public SceneDataViewModel(SceneData data)
        {
            _data = data;
        }

        public void LoadScene()
        {
            SceneManager.LoadScene(_data.sceneId, LoadSceneMode.Additive);
        }
        public void UnloadScene()
        {
            SceneManager.UnloadSceneAsync(_data.sceneId);
        }
    }
}