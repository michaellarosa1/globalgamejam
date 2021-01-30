using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveController : MonoBehaviour
{
    public float Speed = 5f;
    
    public Animator animationToChange;
    public string vNameOfParameter;
    public string hNameOfParameter;
    
    private Rigidbody rb;
    
    public GameObject Tastiera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float mv = Input.GetAxis("Vertical");
        float mh = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(mh, 0, mv );
        transform.Translate(Time.deltaTime * move * Speed);
        animationToChange.SetFloat(vNameOfParameter, mv);
        animationToChange.SetFloat(hNameOfParameter, mh);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Canvas"))
        {
            Tastiera.SetActive(true);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        Tastiera.SetActive(false);
    }
}
