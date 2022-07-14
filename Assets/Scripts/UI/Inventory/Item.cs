using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{


    public Text quantity;


    private void Update()
    {

        if (gameObject.name.Equals("Wood")) { quantity.text = "x" + Inventory.Instance.data.wood.ToString(); }
        if (gameObject.name.Equals("Rock")) { quantity.text = "x" + Inventory.Instance.data.rock.ToString(); }
        if (gameObject.name.Equals("Coal")) { quantity.text = "x" + Inventory.Instance.data.coal.ToString(); }
        if (gameObject.name.Equals("Copper_Ore")) { quantity.text = "x" + Inventory.Instance.data.copper_ore.ToString(); }
        if (gameObject.name.Equals("Copper_Ingot")) { quantity.text = "x" + Inventory.Instance.data.copper_ingot.ToString(); }
        if (gameObject.name.Equals("Iron_Ore")) { quantity.text = "x" + Inventory.Instance.data.iron_ore.ToString(); }
        if (gameObject.name.Equals("Iron_Ingot")) { quantity.text = "x" + Inventory.Instance.data.iron_ingot.ToString(); }
        
    }
}
