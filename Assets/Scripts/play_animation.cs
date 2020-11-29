using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class play_animation : MonoBehaviour
{
    private new AudioSource audio;

    bool current = false;
    //Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator = this.GetComponent<Animator>();
        audio = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void HeadSetOn()
    {
        audio.volume = .1f;
    }


    public void CurrentOff()
    {
        if (current)
        {
            current = false;
            audio.Stop();
        }
    }

    public void CurrentOn()
    {
        if (!current)
        {
            current = true;
            audio.Play();
        }
    }

    public void Stop()
    {
        audio.Stop();
    }

}
