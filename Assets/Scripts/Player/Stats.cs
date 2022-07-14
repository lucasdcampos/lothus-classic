using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Stats : MonoBehaviour
{

    PhotonView view;

    public float Hunger;
    public float Stamina;
    public int HP;
    public float decimalHealth;





    void Start()
    {
        view = GetComponent<PhotonView>();

        if (view.IsMine)
        {
            decimalHealth = 100;
            Stamina = 100;
            Hunger = 100;
        }


    }


    void Update()
    {
        if (view.IsMine)
        {
            if (Hunger > 0.1f)
            {
                Hunger -= 0.1f * Time.deltaTime;
            }
            else
            {
                decimalHealth -= Time.deltaTime;
                HP = Mathf.RoundToInt(decimalHealth);
            }

            HP = Mathf.RoundToInt(decimalHealth);
        }
    }
}
