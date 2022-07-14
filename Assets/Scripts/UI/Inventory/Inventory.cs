using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [HideInInspector] public InventoryData data;
    [HideInInspector] public bool isOpen;

    public static Inventory Instance;
    

    void Awake()
    {
        Instance = this;
        data = GetComponent<InventoryData>();

    }


    void Hotbar()
    {
        if(data.rock > 1)
        {

        }
    }

    public void Equip()
    {

    }


}
