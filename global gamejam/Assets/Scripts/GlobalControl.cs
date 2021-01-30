using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
        public static GlobalControl Instance;
        
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

    void Awake ()   
       {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
      }

}
