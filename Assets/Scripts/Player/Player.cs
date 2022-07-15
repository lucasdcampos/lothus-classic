using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [HideInInspector] public Movement move;
    [HideInInspector] public AnimationController anim;
    [HideInInspector] public Stats stats;
    [HideInInspector] public ParticlesController particles;

    public static Player Instance;



    private void Awake()
    {
        Instance = this;
        move = GetComponent<Movement>();
        particles = GetComponent<ParticlesController>();
        anim = GetComponent<AnimationController>();
        stats = GetComponent<Stats>();
    }




}
