﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaveStateLv3 : MonoBehaviour
{
    public Animator AnimatorCassa1;
    public Animator AnimatorCassa2;
    public Animator AnimatorCassa3;
    public Animator AnimatorCassa4;
    public Animator AnimatorCassa5;
    public Animator AnimatorCassa6;
    public Animator AnimatorCassa7;
    public Animator AnimatorCassa8;
    public Animator AnimatorCassa9;
    public Animator AnimatorCassa10;
    public Animator AnimatorCassa11;
    public Animator AnimatorCassa12;

    public string NameOfParameterBool;

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
        timerSlider.maxValue = Lv3TimeReset;
        timerSlider.value = Lv3Timer;
    }

    // Update is called once per frame
    void Update()
    {
        Lv3Timer = Lv3Timer - Time.deltaTime;
        timerSlider.value = Lv3Timer;

        if(risposta1)
        {
            AnimatorCassa1.SetBool(NameOfParameterBool, true);
        }

        if(risposta2)
        {
            AnimatorCassa2.SetBool(NameOfParameterBool, true);
        }

        if(risposta3)
        {
            AnimatorCassa3.SetBool(NameOfParameterBool, true);
        }

        if(risposta4)
        {
            AnimatorCassa4.SetBool(NameOfParameterBool, true);
        }

        if(risposta5)
        {
            AnimatorCassa5.SetBool(NameOfParameterBool, true);
        }

        if(risposta6)
        {
            AnimatorCassa6.SetBool(NameOfParameterBool, true);
        }

        if(risposta7)
        {
            AnimatorCassa7.SetBool(NameOfParameterBool, true);
        }

        if(risposta8)
        {
            AnimatorCassa8.SetBool(NameOfParameterBool, true);
        }

        if(risposta9)
        {
            AnimatorCassa9.SetBool(NameOfParameterBool, true);
        }

        if(risposta10)
        {
            AnimatorCassa10.SetBool(NameOfParameterBool, true);
        }

        if(risposta11)
        {
            AnimatorCassa11.SetBool(NameOfParameterBool, true);
        }
        
        if(risposta12)
        {
            AnimatorCassa12.SetBool(NameOfParameterBool, true);
        }

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
        }
    }
    
    public void risposta1True()
    {
        risposta1 = true;
    }

    public void risposta2True()
    {
        risposta2 = true;
    }

    public void risposta3True()
    {
        risposta3 = true;
    }

    public void risposta4True()
    {
        risposta4 = true;
    }

    public void risposta5True()
    {
        risposta5 = true;
    }

    public void risposta6True()
    {
        risposta6 = true;
    }

    public void risposta7True()
    {
        risposta7 = true;
    }

    public void risposta8True()
    {
        risposta8 = true;
    }

    public void risposta9True()
    {
        risposta9 = true;
    }

    public void risposta10True()
    {
        risposta10 = true;
    }

    public void risposta11True()
    {
        risposta11 = true;
    }

    public void risposta12True()
    {
        risposta12 = true;
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
    }   

    public void ReloadLv3()
    {
        SceneManager.LoadScene("salva");
    }
}
