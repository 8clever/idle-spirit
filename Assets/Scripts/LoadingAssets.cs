using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadingAssets : MonoBehaviour {
    public AssetReference scene;

    private void Start() {
        Addressables.LoadSceneAsync(scene);
    }
}
