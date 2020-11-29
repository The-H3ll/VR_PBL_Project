using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class snapzone : MonoBehaviour
{
    public int layerIndex;
    private GameObject go;
    private Collider target;
    private bool JustEntred;
    private bool releasedFromHand;
    // Start is called before the first frame update
    void Start()
    {
        Collider col = gameObject.GetComponent<Collider>();
        col.isTrigger = true;
        JustEntred = false;
        releasedFromHand = false;
    }
    private void Update()
    {
        if (JustEntred && releasedFromHand)
        {
            AttachToSnap(target);
        }
    }
    // Update is called once per frame
    public void AttachToSnap(Collider target)
    {
        //move other position to this object transform
        target.gameObject.transform.position = gameObject.transform.position;
        target.gameObject.transform.rotation = gameObject.transform.rotation;
        //set this game object as parent to other
        target.gameObject.transform.parent = gameObject.transform;
    }
    public void DetachFromhand(Collider other)
    {
        //deattach
        releasedFromHand = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Mask")
        {
            //desired object entered indeed
            JustEntred = true;
            target = other;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //return it to its normal state
        JustEntred = false;
        releasedFromHand = false;
        //detach other from parent object
        other.gameObject.transform.parent = null;
        target = null;
    }
}


