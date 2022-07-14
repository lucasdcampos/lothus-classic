using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{

    public GameObject inv;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Inventory.Instance.isOpen)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }

    void Open()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        inv.SetActive(true);
        Inventory.Instance.isOpen = true;
    }

    void Close()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inv.SetActive(false);
        Inventory.Instance.isOpen = false;
    }
}
