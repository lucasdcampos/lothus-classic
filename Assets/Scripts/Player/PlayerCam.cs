using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerCam : MonoBehaviour
{

    public GameManager gm;

    public PhotonView view;

    public float sensX;
    public float sensY;

    public Transform ori;
    float xRot;
    float yRot;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (!view.IsMine)
        {
            Destroy(this);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (view.IsMine)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensX;
            float mouseY = Input.GetAxis("Mouse Y") * sensY;


            yRot += mouseX;
            xRot -= mouseY;
            xRot = Mathf.Clamp(xRot, -90f, 90f);


            transform.rotation = Quaternion.Euler(xRot, yRot, 0);
            ori.rotation = Quaternion.Euler(0, yRot, 0);

            //if (!gm.isPaused)
            // {
            //      transform.rotation = Quaternion.Euler(xRot, yRot, 0);
            //       ori.rotation = Quaternion.Euler(0, yRot, 0);
            //   }
        }


    }
}
