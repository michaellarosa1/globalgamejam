using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta1 : MonoBehaviour
{
    public GameObject Moneta1Obj;
    public bool Moneta01;
    public bool MonetaPresa;
    // Start is called before the first frame update
    private void OnEnable() 
    {
        
    }
    void Start()
    {   Moneta01 = GlobalControl.Instance.Moneta1;
        if (MonetaPresa)
        {
            if (Moneta01)
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
            if (Moneta01)
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
