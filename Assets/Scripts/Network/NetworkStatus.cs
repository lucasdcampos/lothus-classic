using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class NetworkStatus : MonoBehaviour
{

    void Update()
    {
        if (PhotonNetwork.IsConnected)
        {
            GetComponent<Text>().text = "* Online";
            GetComponent<Text>().color = Color.green;
            print("Connected!");
        }
        else
        {
            GetComponent<Text>().text = "* Offline";
            GetComponent<Text>().color = Color.red;
            print("Offline!");
            PhotonNetwork.OfflineMode = true;
        }
    }
}
