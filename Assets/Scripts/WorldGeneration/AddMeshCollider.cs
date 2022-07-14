using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMeshCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        MeshCollider meshCol = gameObject.AddComponent(typeof(MeshCollider)) as MeshCollider;
    }


}
