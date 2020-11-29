using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Snap : MonoBehaviour
{
    public GameObject target;
    public Transform attacheTransform;
    public GameObject indicator;
    public UnityEvent onSnap;
    public UnityEvent onRelease;
    private Rigidbody targetRigidbody;
    private bool touching = false;
    private bool release = false;
    private GameObject attachePlace;
    private GameObject marker;

    // Start is called before the first frame update
    void Start()
    {
        targetRigidbody = target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (touching && release)
            SnapToPlace();
    }

    public void SetRelease(bool release)
    {
        if (touching)
            this.release = release;
        if (release && touching)
        {
            onSnap.Invoke();
        }
        else
        {
            onRelease.Invoke();
        }
    }

    public void SnapToPlace()
    {
        if (marker)
            Destroy(marker);
        if (!attacheTransform)
        {
            attachePlace = new GameObject("attachePlace");
            attachePlace.transform.position = transform.position;
            attachePlace.transform.rotation = transform.rotation;
            attachePlace.transform.parent = transform;
        }
        targetRigidbody.velocity = Vector3.zero;
        if (attacheTransform)
        {
            target.transform.position = attacheTransform.position;
            target.transform.rotation = attacheTransform.rotation;
        }
        else
        {
            target.transform.position = attachePlace.transform.position;
            target.transform.rotation = attachePlace.transform.rotation;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == target.name)
        {
            touching = true;
            if (!marker)
                marker = GameObject.Instantiate(indicator);
            if (attacheTransform)
            {
                marker.transform.position = attacheTransform.position;
                marker.transform.rotation = attacheTransform.rotation;
            }
            else
            {
                marker.transform.position = attachePlace.transform.position;
                marker.transform.rotation = attachePlace.transform.rotation;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == target.name)
        {
            touching = false;
            Destroy(marker);
        }
    }
}

