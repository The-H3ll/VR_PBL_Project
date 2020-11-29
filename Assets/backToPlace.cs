using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToPlace : MonoBehaviour
{
    private Transform transform;
    private Rigidbody rigidbody; 
    private Vector3 position;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();
        position = transform.position;
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.CompareTag("Ground"))
        {
            transform.position = position;
            transform.rotation = rotation;
            rigidbody.velocity = Vector3.zero;
        }
    }
}
