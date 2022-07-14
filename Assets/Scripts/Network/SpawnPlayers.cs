using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPref;

    public float range;

    public void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-range, range), 200, Random.Range(-range, range));
            Ray ray = new Ray(randomPos, -transform.up);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Ground")
                {
                    Vector3 randomRot = new Vector3(0, Random.Range(0, 360), 0);
                    PhotonNetwork.Instantiate(playerPref.name, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
                    return;
                }
                else
                {
                    i = 0;
                }

            }
        }


    }


}
