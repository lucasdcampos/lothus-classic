using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Transform playerCam;


    void Update()
    {
        transform.position = playerCam.position;
    }
}
