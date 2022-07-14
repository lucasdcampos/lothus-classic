using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadingTips : MonoBehaviour
{
    public Text errorText;
    public Text text;
    int index;
   

    void Start()
    {
        StartCoroutine(ChangeTip());
        StartCoroutine(ErrorLog());

    }

    private IEnumerator ErrorLog()
    {
        yield return new WaitForSeconds(15);
        errorText.gameObject.SetActive(true);
    }

    private IEnumerator ChangeTip()
    {
        index = Random.Range(1, 16);
        yield return new WaitForSeconds(5);
        Restart();
    }

    void Restart()
    {
        StartCoroutine(ChangeTip());
    }


    private void Update()
    {
        if (index == 1)
        {
            text.text = "Monsters will spawn more often at night. Be ready!";
        }

        if (index == 2)
        {
            text.text = "The game is easier (and funnier) with friends!";
        }

        if (index == 3)
        {
            text.text = "Do people really read these lines? Oh.";
        }

        if (index == 4)
        {
            text.text = "Punch trees to get wood!";
        }

        if (index == 5)
        {
            text.text = "Baked meal will give you more energy!";
        }

        if (index == 6)
        {
            text.text = "Build a house to protect yourself against monsters.";
        }

        if (index == 7)
        {
            text.text = "New updates soon!";
        }

        if (index == 8)
        {
            text.text = "Wooden Armor is a great start!";
        }

        if (index == 9)
        {
            text.text = "Press alt + f4 to see an easter egg!";
        }

        if (index == 10)
        {
            text.text = "Running makes your hunger low down more quickly.";
        }

        if (index == 11)
        {
            text.text = "Apples sometimes can be found chopping down trees.";
        }

        if (index == 12)
        {
            text.text = "Report bugs at lazycat.cf/discord";
        }

        if (index == 13)
        {
            text.text = "Change your settings on the menu.";
        }

        if (index == 14)
        {
            text.text = "Interact with water with a empty bucket to full it.";
        }

        if (index == 15)
        {
            text.text = "Change the seed to get a completely different world!";
        }

    }


}
