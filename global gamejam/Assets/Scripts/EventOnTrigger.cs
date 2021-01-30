using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{
    public GameObject soundKey;
    public UnityEvent action;
    public UnityEvent actionUscita;
    public string TriggerTag;


    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(TriggerTag))
        {
            if (action != null)action.Invoke();
            soundKey.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(TriggerTag))
        {
            if (action != null)actionUscita.Invoke();
            soundKey.SetActive(true);
        }
    }
}
