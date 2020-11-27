using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenController : MonoBehaviour
{
    public Texture screenOff;
    public Texture screenOn;
    Renderer m_Renderer;

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.material.SetTexture("_MainTex", screenOff);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetScreenOn()
    {
        m_Renderer.material.SetTexture("_MainTex", screenOn);
    }

    public void SetScreenOff()
    {
        m_Renderer.material.SetTexture("_MainTex", screenOff);
    }
}
