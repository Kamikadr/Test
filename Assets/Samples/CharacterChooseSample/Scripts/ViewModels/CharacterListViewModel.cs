using ChooseAndShowTemplate;
using Samples.Common.CharacterChooseSample.Scripts;

namespace Samples.CharacterChooseSample.Scripts
{
    public sealed class CharacterListViewModel: DataLoader<CharacterData>
    {
        private readonly DataContainer<CharacterData> _dataContainer;


        public CharacterListViewModel(ILoadDataService<CharacterData> dataService, DataContainer<CharacterData> dataContainer) : base(dataService)
        {
            _dataContainer = dataContainer;
        }
        protected override void SelectData(CharacterData data)
        {
            _dataContainer.SetData(data);
        }
        
        
    }
}