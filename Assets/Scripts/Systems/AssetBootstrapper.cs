using ColheitaDaNoite.Core;
using UnityEngine;

namespace ColheitaDaNoite.Systems
{
    public class AssetBootstrapper : MonoBehaviour
    {
        [SerializeField] private AssetManifest manifest;
        [SerializeField] private bool logDetails = true;

        private void Awake()
        {
            if (manifest == null)
            {
                Debug.LogWarning("AssetBootstrapper: nenhum AssetManifest foi configurado.");
                return;
            }

            ValidateList("gameplayPrefabs", manifest.gameplayPrefabs.Count);
            ValidateList("musicTracks", manifest.musicTracks.Count);
            ValidateList("sfx", manifest.sfx.Count);
            ValidateList("corruptionMaterials", manifest.corruptionMaterials.Count);
            ValidateList("vfxPrefabs", manifest.vfxPrefabs.Count);

            Debug.Log($"AssetBootstrapper: {manifest.TotalRegisteredAssets} assets registrados no manifesto.");
        }

        private void ValidateList(string listName, int count)
        {
            if (count == 0)
            {
                Debug.LogWarning($"AssetBootstrapper: lista '{listName}' está vazia.");
                return;
            }

            if (logDetails)
            {
                Debug.Log($"AssetBootstrapper: lista '{listName}' possui {count} item(ns).");
            }
        }
    }
}
