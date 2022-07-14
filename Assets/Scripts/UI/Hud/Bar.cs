using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Bar : MonoBehaviour
{

    PhotonView view;


    [Header("HP:")]
    private float maxHP = 100f;
    public Image HP_Bar;
    public Text HP_Text;
    public Text Stam_Text;
    public Text Hunger_Text;


    [Header("Hunger")]

    private float maxHunger = 100f;
    public Image Hunger_Bar;


    [Header("Stamina:")]

    private float maxStam = 100f;
    public Image Stam_Bar;




    private void Update()
    {

        HP_Bar.fillAmount = Player.Instance.stats.HP / maxHP;
        Stam_Bar.fillAmount = Player.Instance.stats.Stamina / maxStam;
        Hunger_Bar.fillAmount = Player.Instance.stats.Hunger / maxHunger;
        HP_Text.text = Player.Instance.stats.HP + "/" + maxHP;
        Stam_Text.text = Player.Instance.stats.Stamina + "/" + maxStam;
        Hunger_Text.text = Player.Instance.stats.Hunger + "/" + maxHunger;


        

    }
}
