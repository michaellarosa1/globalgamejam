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
    private float cd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(song)
        {
            cd = cd - Time.deltaTime;
            if(cd <= 0)
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
        cd = 0.05f;
    }
}
