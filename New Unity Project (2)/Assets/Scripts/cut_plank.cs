using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cut_plank : MonoBehaviour
{

    public GameObject cuted_wood_plank;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "JigSaw")
        {
            Instantiate(cuted_wood_plank, transform.position + new Vector3(0f, -0.05f, 0f), new Quaternion(0f, 0f, 0f, -90f));
            Destroy(gameObject);
        }
    }
}
