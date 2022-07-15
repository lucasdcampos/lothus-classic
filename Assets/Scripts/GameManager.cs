using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public static GameManager Instance;


    public bool isPaused;
    public int day;

    void Awake()
    {
        Instance = this;
    }


    void Update()
    {
        
    }
}
