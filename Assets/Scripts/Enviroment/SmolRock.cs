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
        else
        {
            
            UIManager.Instance.collectTxt.gameObject.SetActive(false);
        }
    }


    void Collect()
    {
        Inventory.Instance.data.rock++;
        Destroy(gameObject);
    }
}
