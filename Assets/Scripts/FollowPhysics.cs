using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPhysics : MonoBehaviour
{
    public bool canMove = true;
    public Transform target;
    Rigidbody rg;
    Quaternion q;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
            rg.MoveRotation(target.rotation);
        else
            rg.MoveRotation(q);
    }

    public void Lock()
    {
        canMove = false;
        q = target.rotation;
    }
    public void Unlock() => canMove = true;
}
