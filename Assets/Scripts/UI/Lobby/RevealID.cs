using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealID : MonoBehaviour
{

    [SerializeField] GameObject button;
    [SerializeField] GameObject id;

    void Start()
    {
        id.SetActive(false);
        button.SetActive(true);
        //
    }


    public void Reveal()
    {
        id.SetActive(true);
        button.SetActive(false);
    }

}
