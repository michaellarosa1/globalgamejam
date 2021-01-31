using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta4 : MonoBehaviour
{
    public GameObject Moneta1Obj;
    public bool Moneta04;
    public bool MonetaPresa;
    // Start is called before the first frame update
    private void OnEnable() 
    {
        
    }
    void Start()
    {   Moneta04 = GlobalControl.Instance.Moneta4;
        if (MonetaPresa)
        {
            if (Moneta04)
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
            if (Moneta04)
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
