using System.Collections.Generic;
using UnityEngine;

namespace ColheitaDaNoite.Core
{
    [CreateAssetMenu(fileName = "AssetManifest", menuName = "ColheitaDaNoite/Asset Manifest")]
    public class AssetManifest : ScriptableObject
    {
        [Header("Prefabs de gameplay")]
        public List<GameObject> gameplayPrefabs = new();

        [Header("Áudios")]
        public List<AudioClip> musicTracks = new();
        public List<AudioClip> sfx = new();

        [Header("Visuais")]
        public List<Material> corruptionMaterials = new();
        public List<GameObject> vfxPrefabs = new();

        public int TotalRegisteredAssets =>
            gameplayPrefabs.Count +
            musicTracks.Count +
            sfx.Count +
            corruptionMaterials.Count +
            vfxPrefabs.Count;
    }
}
