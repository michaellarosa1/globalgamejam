using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator AnimatorToActive;
    public string NameOfParameter;
    private int NumberToChange = 1;
    private int Return = 0;
    private bool song;
    public float Delay = 0.5f;
    private float DelayReset;

    // Start is called before the first frame update
    void Start()
    {
        DelayReset = Delay;
    }

    // Update is called once per frame
    void Update()
    {
        if(song)
        {
            Delay = Delay - Time.deltaTime;
            if(Delay <= 0)
            {
               song = false;
               AnimatorToActive.SetInteger(NameOfParameter, Return);
            }
        }
    }

    public void AnimSong()
    {
        AnimatorToActive.SetInteger(NameOfParameter, NumberToChange);
        song = true;
        Delay = DelayReset;
    }
}
