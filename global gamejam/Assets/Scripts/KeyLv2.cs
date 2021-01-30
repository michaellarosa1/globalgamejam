using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLv2 : MonoBehaviour
{
    public Animator AnimatorToActive;
    public string NameOfParameterBool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void keyIn()
    {
        AnimatorToActive.SetBool(NameOfParameterBool, true);
    }

    public void keyOff()
    {
        AnimatorToActive.SetBool(NameOfParameterBool, false);
    }
}
