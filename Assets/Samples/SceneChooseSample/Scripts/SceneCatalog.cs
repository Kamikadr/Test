using ChooseAndShowTemplate;
using Samples.Common.SceneChooseSample.Scripts;
using UnityEngine;

namespace Samples.SceneChooseSample.Scripts
{
    [CreateAssetMenu(menuName = "Catalog/SceneCatalog", fileName = "new SceneCatalog")]
    public class SceneCatalog: LoadableDataCatalog<SceneData>
    {
    }
}