using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneBundle : MonoBehaviour {
    [Tooltip("Path to the asset bundle.")]
    [SerializeField] private string sceneURL;
    AssetBundle assetBundle;

    IEnumerator Start () {
        //download assetbundle
        WWW downloadedAssetBundle = WWW.LoadFromCacheOrDownload(sceneURL, 1);
        yield return downloadedAssetBundle;

        assetBundle = downloadedAssetBundle.assetBundle;

        if (assetBundle.isStreamedSceneAssetBundle) {
            string[] scenePaths = assetBundle.GetAllScenePaths();
            string sceneName = Path.GetFileNameWithoutExtension(scenePaths[0]);
            SceneManager.LoadScene(sceneName);
        }
        
	}
}
