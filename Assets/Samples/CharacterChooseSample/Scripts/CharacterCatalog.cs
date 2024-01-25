using ChooseAndShowTemplate;
using UnityEngine;

namespace Samples.Common.CharacterChooseSample.Scripts
{
    [CreateAssetMenu(menuName = "Catalog/CharacterDataCatalog", fileName = "new CharacterDataCatalog")]
    public sealed class CharacterCatalog: LoadableDataCatalog<CharacterData>
    {
    }
}