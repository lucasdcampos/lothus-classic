using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{


    public Text quantity;


    private void Start()
    {
        quantity = GetComponentInChildren<Text>();

        if (gameObject.name.Equals("Wood")) { quantity.text = "x" + Inventory.Instance.wood.ToString(); }
        if (gameObject.name.Equals("Rock")) { quantity.text = "x" + Inventory.Instance.rock.ToString(); }
        if (gameObject.name.Equals("Copper_Ore")) { quantity.text = "x" + Inventory.Instance.copper_ore.ToString(); }
        if (gameObject.name.Equals("Copper_Ingot")) { quantity.text = "x" + Inventory.Instance.copper_ingot.ToString(); }
        if (gameObject.name.Equals("Iron_Ore")) { quantity.text = "x" + Inventory.Instance.iron_ore.ToString(); }
        if (gameObject.name.Equals("Iron_Ingot")) { quantity.text = "x" + Inventory.Instance.iron_ingot.ToString(); }
        
    }
}
