using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SwitchThrozable : Throwable
{
    public Transform handler;

    override protected void OnDetachedFromHand(Hand hand)
    {
        base.OnDetachedFromHand(hand);
        transform.position = handler.transform.position;
        transform.rotation = handler.transform.rotation;
    }
}
