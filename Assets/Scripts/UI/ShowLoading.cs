using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLoading : MonoBehaviour
{
    public GameObject loading;

    void Awake()
    {
        loading.SetActive(true);
    }


}
