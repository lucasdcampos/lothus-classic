using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadingText : MonoBehaviour
{
    public Text text;
    int index;
    [SerializeField] GameObject button;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject dayCycle;
    [HideInInspector] public SpawnPlayers spawn;


    void Awake()
    {
        dayCycle.SetActive(false);
        button.SetActive(false);
        text.text = "Creating World...";
        StartCoroutine(ChangeTip());
        spawn = FindObjectOfType<SpawnPlayers>();

        
    }

    private IEnumerator ChangeTip()
    {
        yield return new WaitForSeconds(3);
        text.text = "Done";
        button.SetActive(true);
    }





   public void Ready()
    {
        panel.SetActive(false);
        dayCycle.SetActive(true);
    }



}
