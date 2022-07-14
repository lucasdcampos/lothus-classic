using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    bool mapOpen;
    public GameObject map;

    
    void Start()
    {
        map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (mapOpen)
            {
                CloseMap();
            }
            else
            {
                OpenMap();
            }
        }
    }


    void CloseMap()
    {
        mapOpen = false;
        map.SetActive(false);
    }

    void OpenMap()
    {
        mapOpen = true;
        map.SetActive(true);
    }
}
