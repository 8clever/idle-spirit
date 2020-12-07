using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;

public class LoadingSceneAsset : MonoBehaviour {
    public AssetReference scene;
    private void Start() {
        Addressables.LoadSceneAsync(scene);
    }
}
