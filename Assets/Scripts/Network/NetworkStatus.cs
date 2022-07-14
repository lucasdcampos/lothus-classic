using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class NetworkStatus : MonoBehaviour
{

    void Update()
    {
        if (!PhotonNetwork.OfflineMode)
        {
            GetComponent<Text>().text = "* Online";
            GetComponent<Text>().color = Color.green;
            
        }
        else
        {
            GetComponent<Text>().text = "* Offline";
            GetComponent<Text>().color = Color.red;
            
            
        }
    }
}
