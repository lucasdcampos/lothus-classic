using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCounter : MonoBehaviour
{
    public Animator anim;
    public Text text;
    


    private void OnTriggerEnter(Collider other)
    {
        UpdateDay();
    }

    private void OnCollisionEnter(Collision collision)
    {
        UpdateDay();
    }

    private void OnCollisionStay(Collision collision)
    {
        UpdateDay();
    }

    private void OnTriggerStay(Collider other)
    {
        UpdateDay();
    }


    public void UpdateDay()
    {
        GameManager.Instance.day++;
        text.text = "- DAY: " + GameManager.Instance.day + " -";
        anim.SetTrigger("start");
        GetComponent<AudioSource>().Play();
    }
}
