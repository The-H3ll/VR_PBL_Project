using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenController : MonoBehaviour
{
    public Texture screenOff;
    public Texture screenOn;
    public List<Texture> screens;
    Renderer m_Renderer;
    private bool screenTurnedOn = false;

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

    public void SetScreen(int index)
    {
        m_Renderer.material.SetTexture("_MainTex", screens[index]);
        screenTurnedOn = true;
    }

    public void SetScreenOn()
    {
        if (!screenTurnedOn)
            m_Renderer.material.SetTexture("_MainTex", screenOn);
        screenTurnedOn = true;
    }

    public void SetScreenOff()
    {
        m_Renderer.material.SetTexture("_MainTex", screenOff);
        screenTurnedOn = false;
    }
}
