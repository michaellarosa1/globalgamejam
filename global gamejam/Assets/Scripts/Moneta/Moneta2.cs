using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta2 : MonoBehaviour
{
    public GameObject Moneta1Obj;
    public bool Moneta02;
    public bool MonetaPresa;
    // Start is called before the first frame update
    private void OnEnable() 
    {
        
    }
    void Start()
    {   Moneta02 = GlobalControl.Instance.Moneta2;
        if (MonetaPresa)
        {
            if (Moneta02)
            {
                Moneta1Obj.SetActive(true);
            }
            else
            {
                Moneta1Obj.SetActive(false);
            }
        }
        else
        {
            if (Moneta02)
            {
                Moneta1Obj.SetActive(false);
            }
            else
            {
                Moneta1Obj.SetActive(true);  
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
