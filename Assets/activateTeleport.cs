using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class activateTeleport : MonoBehaviour
{
    public bool helmetOn = false;
    public bool maskOn = false;
    public bool headsetOn = false;
    public bool sunglassesOn = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlock()
    {
        if (headsetOn && helmetOn && maskOn && sunglassesOn)
            GetComponent<TeleportPoint>().SetLocked(false);
    }

    public void HelmetOn()
    {
        helmetOn = true;
        Unlock();
    }
    public void MaskOn()
    {
        maskOn = true;
        Unlock();
    }
    public void HeadsetOn()
    {
        headsetOn = true;
        Unlock();
    }
    public void SunglassesOn()
    {
        sunglassesOn = true;
        Unlock();
    }
}
