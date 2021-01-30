using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameENDER : MonoBehaviour
{
    // Start is called before the first frame update
 
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("menu");
        Debug.Log("menu");
        
    }

    
}
