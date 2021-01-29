using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recever : MonoBehaviour
{
    public OSC MyOsc;
    public Transform transf;
    // Start is called before the first frame update
    void Start()
    {
        MyOsc.SetAddressHandler("/SyncTransform",ReceveSyncTransform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReceveSyncTransform(OscMessage inputMessage)
    {
        transf.localPosition = new Vector3(inputMessage.GetFloat(0),inputMessage.GetFloat(1),inputMessage.GetFloat(2));
        transf.localRotation = new Quaternion(inputMessage.GetFloat(3),inputMessage.GetFloat(4),inputMessage.GetFloat(5),inputMessage.GetFloat(6));
    }
}
