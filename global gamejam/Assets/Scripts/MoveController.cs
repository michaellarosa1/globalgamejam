using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpPow = 10;
    public Animator animationToChange;
    public string vNameOfParameter;
    public string hNameOfParameter;
    public string Jump;
    private Rigidbody rb;
    private float JumpCd = 2f;
    private float JumpCdReset;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        JumpCdReset = JumpCd;
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
        if (Input.GetButtonUp("Jump") && JumpCd <= 0f)
        {
            Vector3 jumpForce = Vector3.up * JumpPow;
            rb.AddForce(jumpForce, ForceMode.VelocityChange);
            JumpCd = JumpCdReset;
            animationToChange.SetBool(Jump, true);
        }
        JumpCd = JumpCd - Time.deltaTime;
        animationToChange.SetBool(Jump, false);
    }
}
