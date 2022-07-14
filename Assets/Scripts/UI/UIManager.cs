using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text collectTxt;

    public static UIManager Instance;

    AudioSource source;

    public AudioClip itemcollectedSFX;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        Instance = this;
    }

   public void ItemCollected()
    {
        source.clip = itemcollectedSFX;
        source.Play();
    }
}
