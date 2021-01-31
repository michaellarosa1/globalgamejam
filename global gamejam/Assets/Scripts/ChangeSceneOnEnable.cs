using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnEnable : MonoBehaviour
{
    public string ScenesName;

    private void OnEnable() 
    {
        SceneManager.LoadScene(ScenesName);
    }
}
