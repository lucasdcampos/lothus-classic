using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SmolRock : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
           UIManager.Instance.collectTxt.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Collect();
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UIManager.Instance.collectTxt.gameObject.SetActive(false);
    }


    void Collect()
    {
        UIManager.Instance.ItemCollected();
        UIManager.Instance.collectTxt.gameObject.SetActive(false);
        Inventory.Instance.data.rock++;
        Destroy(gameObject);
    }
}
