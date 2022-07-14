using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCounter : MonoBehaviour
{
    public Animator anim;
    public Text text;
    [HideInInspector] public int day;

    private void Start()
    {
        StartCoroutine(Day());
    }


    public IEnumerator Day()
    {
        day++;
        text.text = "- DAY: " + day + " -";
        anim.SetTrigger("start");
        yield return new WaitForSeconds(1);
        GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(24 / GetComponent<LightingManager>().multiplier);
        Restart();
    }

    public void Restart()
    {
        StartCoroutine(Day());
    }
}
