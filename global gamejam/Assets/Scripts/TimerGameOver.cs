using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerGameOver : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 50f;
    [SerializeField] Text timerText;


    void Start()
    {
        currentTime = startingTime;
    }


    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("00");



        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("Lv1");
        }

       

    }

}
