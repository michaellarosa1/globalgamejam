using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    public OSC MyOsc;

    public Transform transf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OscMessage tempMessageToSend = new OscMessage();
        tempMessageToSend.address = "/SyncTransform";
        tempMessageToSend.values.Add(transf.localPosition.x);
        tempMessageToSend.values.Add(transf.localPosition.y);
        tempMessageToSend.values.Add(transf.localPosition.z);

        tempMessageToSend.values.Add(transf.localRotation.x);
        tempMessageToSend.values.Add(transf.localRotation.y);
        tempMessageToSend.values.Add(transf.localRotation.z);
        tempMessageToSend.values.Add(transf.localRotation.w);

        MyOsc.Send(tempMessageToSend);
    }
}
