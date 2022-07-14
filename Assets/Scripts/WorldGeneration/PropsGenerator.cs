using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsGenerator : MonoBehaviour
{
    GameObject prefab;

    public GameObject[] prefabs;
    public int maxPrefabs;
    public float scale;
    public float range;

    private void Start()
    {
        Generate();
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, -transform.up, Color.green);
    }


    public void Generate()
    {
        for (int x = 0; x <= maxPrefabs; x++)
        {
            int randomPrefab = Random.Range(0, prefabs.Length);
            prefab = prefabs[randomPrefab];
            float randomScale = Random.Range(scale -= 10 / 100 * scale, scale + 10 / 100 * scale);
            Vector3 randomPos = new Vector3(Random.Range(-range, range), 150, Random.Range(-range, range));

            Ray ray = new Ray(randomPos, -transform.up);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Ground")
                {
                    Vector3 randomRot = new Vector3(0, Random.Range(0, 360), 0);
                    Instantiate(prefab, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.Euler(randomRot));
                    prefab.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
                }

            }
        }
    }
}
