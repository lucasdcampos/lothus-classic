using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesManager : MonoBehaviour
{
    public ParticleSystem leaves;
    public ParticleSystem fireflies;
    public ParticleSystem stars;


    void Update()
    {
        if (LightingManager.Instance.isNight)
        {
            stars.Play();
            fireflies.Play();
            leaves.Stop();
        }
        else
        {
            stars.Stop();
            fireflies.Stop();
            leaves.Play();
        }
    }
}
