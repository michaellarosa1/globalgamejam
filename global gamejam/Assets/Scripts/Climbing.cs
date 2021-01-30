using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    public Animator PlayerAnim;
    public string vNameOfParameter;
    public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float climb = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(0, climb, 0 );
        PlayerAnim.SetFloat(vNameOfParameter, climb);
        transform.Translate(Time.deltaTime * move * Speed);
    }
}
