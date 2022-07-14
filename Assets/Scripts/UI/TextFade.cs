using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextFade : MonoBehaviour
{

    // the image you want to fade, assign in inspector
    public Text txt;

    public void OnButtonClick()
    {
        // fades the image out when you click
        StartCoroutine(FadeText(true));
    }

    IEnumerator FadeText(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                txt.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                txt.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}