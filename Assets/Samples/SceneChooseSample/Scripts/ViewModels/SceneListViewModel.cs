using ChooseAndShowTemplate;
using Samples.Common.SceneChooseSample.Scripts;

namespace Samples.SceneChooseSample.Scripts.ViewModels
{
    public class SceneListViewModel: DataLoader<SceneData>
    {
        private readonly DataContainer<SceneData> _dataContainer;

        public SceneListViewModel(ILoadDataService<SceneData> dataService, DataContainer<SceneData> dataContainer) : base(dataService)
        {
            _dataContainer = dataContainer;
        }

        protected override void SelectData(SceneData data)
        {
            _dataContainer.SetData(data);
        }
    }
}