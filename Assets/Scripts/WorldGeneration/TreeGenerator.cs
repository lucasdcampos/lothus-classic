using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    GameObject prefab;

    public GameObject[] prefabs;
    public int maxPrefabs;
    public float scale;

    [Space]
    [Header("X Values:")]
    public float minX;
    public float maxX;
    [Space]
    [Header("Z Values:")]
    public float minZ;
    public float maxZ;


    private void Start()
    {
        Generate();
    }


    public void Generate()
    {

        for (int i = 0; i < maxPrefabs; i++)
        {
            int randomPrefab = Random.Range(0, prefabs.Length);
            prefab = prefabs[randomPrefab];
            float randomScale = Random.Range(scale-=10/100*scale, scale+10/100*scale);
            Vector3 randomPos = new Vector3(Random.Range(minX, maxX), 30, Random.Range(minZ, maxZ));
            Vector3 randomRot = new Vector3(0, Random.Range(0,360), 0);
            Instantiate(prefab, randomPos, Quaternion.Euler(randomRot));
            prefab.transform.localScale = new Vector3(randomScale, randomScale, randomScale);

        }
    }

}
