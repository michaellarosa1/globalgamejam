using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger1 : MonoBehaviour
{
    public GameObject soundKey;
    
    public string TriggerTag;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TriggerTag))
        {
            
            soundKey.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(TriggerTag))
        { 
            soundKey.SetActive(true);
        }
    }
}
