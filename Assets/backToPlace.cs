using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToPlace : MonoBehaviour
{
    private new Transform transform;
    private Vector3 position;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
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
        }
    }
}
