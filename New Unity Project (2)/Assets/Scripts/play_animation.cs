using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class play_animation : MonoBehaviour
{
    
    public float speed = 1;
    private new AudioSource audio;

    bool started = true;
    bool current = false;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        audio = this.GetComponent<AudioSource>();
        StartOff();
    }

    // Update is called once per frame
    void Update()
    {
        animator.speed = speed;
    }

    public void StartOff()
    {
        if (started && current)
        {
            animator.Play("machine_turning");
            audio.Play();
        }
        else
        {
            animator.Play("New State");
            audio.Stop();
        }
        started = !started;
    }

    public void CurrentOff()
    {
        if (current)
        {
            current = false;
            StartOff();
        }
    }

    public void CurrentOn()
    {
        if (!current)
        {
            current = true;
            StartOff();
        }
    }

}
