using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text collectTxt;

    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    void ItemCollected()
    {

    }
}
