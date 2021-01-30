using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaveState : MonoBehaviour
{
    public float Lv3Timer;
    public bool risposta1;
    public bool risposta2;
    public bool risposta3;
    public bool risposta4;
    public bool risposta5;
    public bool risposta6;
    public bool risposta7;
    public bool risposta8;
    public bool risposta9;
    public bool risposta10;
    public bool risposta11;
    public bool risposta12;
    public bool Moneta1;
    public bool Moneta2;
    public bool Moneta3;
    public bool Moneta4;

    public Slider timerSlider;
    private float Lv3TimeReset;
    // Start is called before the first frame update
    
    void Start()
    {
        Lv3Timer = GlobalControl.Instance.Lv3Timer;
        risposta1 = GlobalControl.Instance.risposta1;
        risposta2 = GlobalControl.Instance.risposta2;
        risposta3 = GlobalControl.Instance.risposta3;
        risposta4 = GlobalControl.Instance.risposta4;
        risposta5 = GlobalControl.Instance.risposta5;
        risposta6 = GlobalControl.Instance.risposta6;
        risposta7 = GlobalControl.Instance.risposta7;
        risposta8 = GlobalControl.Instance.risposta8;
        risposta9 = GlobalControl.Instance.risposta9;
        risposta10 = GlobalControl.Instance.risposta10;
        risposta11 = GlobalControl.Instance.risposta11;
        risposta12 = GlobalControl.Instance.risposta12;
        Moneta1 = GlobalControl.Instance.Moneta1;
        Moneta2 = GlobalControl.Instance.Moneta2;
        Moneta3 = GlobalControl.Instance.Moneta3;
        Moneta4 = GlobalControl.Instance.Moneta4;
        timerSlider.maxValue = Lv3TimeReset;
        timerSlider.value = Lv3Timer;
    }

    // Update is called once per frame
    void Update()
    {
        Lv3Timer = Lv3Timer - Time.deltaTime;
        timerSlider.value = Lv3Timer;

        if(Lv3Timer <= 0)
        {
            ReloadLv3();
            Lv3Timer = Lv3TimeReset;
            GlobalControl.Instance.risposta1 = false;
            GlobalControl.Instance.risposta2 = false;
            GlobalControl.Instance.risposta3 = false;
            GlobalControl.Instance.risposta4 = false;
            GlobalControl.Instance.risposta5 = false;
            GlobalControl.Instance.risposta6 = false;
            GlobalControl.Instance.risposta7 = false;
            GlobalControl.Instance.risposta8 = false;
            GlobalControl.Instance.risposta9 = false;
            GlobalControl.Instance.risposta10 = false;
            GlobalControl.Instance.risposta11 = false;
            GlobalControl.Instance.risposta12 = false;
            GlobalControl.Instance.Moneta1 = false;
            GlobalControl.Instance.Moneta2 = false;
            GlobalControl.Instance.Moneta3 = false;
            GlobalControl.Instance.Moneta4 = false;
        }
    }

    public void saveState()
    {
        GlobalControl.Instance.Lv3Timer = Lv3Timer;
        GlobalControl.Instance.risposta1 = risposta1;
        GlobalControl.Instance.risposta2 = risposta2;
        GlobalControl.Instance.risposta3 = risposta3;
        GlobalControl.Instance.risposta4 = risposta4;
        GlobalControl.Instance.risposta5 = risposta5;
        GlobalControl.Instance.risposta6 = risposta6;
        GlobalControl.Instance.risposta7 = risposta7;
        GlobalControl.Instance.risposta8 = risposta8;
        GlobalControl.Instance.risposta9 = risposta9;
        GlobalControl.Instance.risposta10 = risposta10;
        GlobalControl.Instance.risposta11 = risposta11;
        GlobalControl.Instance.risposta12 = risposta12;
        GlobalControl.Instance.Moneta1 = Moneta1;
        GlobalControl.Instance.Moneta2 = Moneta2;
        GlobalControl.Instance.Moneta3 = Moneta3;
        GlobalControl.Instance.Moneta4 = Moneta4;
    }   

    public void ReloadLv3()
    {
        SceneManager.LoadScene("Lv3");
    }
}
