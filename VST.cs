using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.PXR;
public class VST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PXR_MixedReality.EnableVideoSeeThrough(true);
        Debug.Log($"doing GetIdToken33345445");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 应用恢复后，再次开启透视
    void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            PXR_MixedReality.EnableVideoSeeThrough(true);
        }
    }

}
