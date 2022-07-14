using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{
    bool menu;
    public float speed = 0.3f;


    // Update is called once per frame
    void Update()
    {
        if(menu){
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }


        
    }
}
