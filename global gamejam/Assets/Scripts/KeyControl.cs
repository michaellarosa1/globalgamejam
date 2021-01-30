using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour
{
    public Animator AnimatorToActive;
    public string NameOfParameterBool;
    public GameObject Light;
    public GameObject trapdoorsound;

    private void OnEnable()
    {
        AnimatorToActive.SetBool(NameOfParameterBool, true);
        Light.SetActive(true);
        trapdoorsound.SetActive(true);

    }

    void Start()
    {
        
    }

    void Update()
    {
       
    }
}
