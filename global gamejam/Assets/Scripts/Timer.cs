using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;

    private bool stopTimer;
    private float gameTimeReset;
    

    
    

    // Start is called before the first frame update
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
        gameTimeReset = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        gameTime = gameTime - Time.deltaTime;

        int minutes = Mathf.FloorToInt(gameTime / 60);
        int seconds = Mathf.FloorToInt(gameTime - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        

        if(gameTime <= 0)
        {
            stopTimer = true;
            Reload();
            gameTime = gameTimeReset;
            gameObject.SetActive(true);
        }

        if(stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = gameTime;
        }

    }
    
    public void Reload()
    {
        if (stopTimer == true)
        {
            SceneManager.LoadScene("GameOver");
            
        }
    }

  

    
}
