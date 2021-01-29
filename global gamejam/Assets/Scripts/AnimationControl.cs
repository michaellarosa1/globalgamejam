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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(song)
        {
            AnimatorToActive.SetInteger(NameOfParameter, Return);
            song = false;
        }
    }

    public void AnimSong()
    {
        AnimatorToActive.SetInteger(NameOfParameter, NumberToChange);
        song = true;
    }
}
