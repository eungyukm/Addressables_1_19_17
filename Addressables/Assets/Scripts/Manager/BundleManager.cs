using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class BundleManager : MonoBehaviour
{
    public AssetLabelReference assetLabelReference;

    // Start is called before the first frame update
    void Start()
    {
        GetLocation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetLocation()
    {
        Addressables.GetDownloadSizeAsync(assetLabelReference.labelString).Completed +=
            (handle) =>
            {
                Debug.Log("Size : " + handle.Result);
            };
    }
}
