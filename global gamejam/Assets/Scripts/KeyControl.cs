using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour
{
    public Animator AnimatorToActive;
    public string NameOfParameterBool;

    private void OnEnable()
    {
        AnimatorToActive.SetBool(NameOfParameterBool, true);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
