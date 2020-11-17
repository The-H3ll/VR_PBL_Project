using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class hover : MonoBehaviour
{
    SteamVR_Skeleton_Poser poser;
    // Start is called before the first frame update
    void Start()
    {
        poser = GetComponent<SteamVR_Skeleton_Poser>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hover()
    {
        Debug.Log("HOOOOOOOOOOOOVER");
    }
}
