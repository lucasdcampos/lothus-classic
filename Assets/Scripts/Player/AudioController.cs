using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{

    [HideInInspector] public AudioSource source;
    public AudioClip[] clips;
    public bool playing;

    [HideInInspector] int index = 0;
    private Player player;

    void Start()
    {
        player = GetComponent<Player>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        Footsteps();
    }


    void Footsteps()
    {
        if (player.move.isGrounded && !source.isPlaying)
        {
            if (player.move.dir.x != 0 && player.move.dir.z != 0)
            {
                if (!playing)
                {
                    StartCoroutine(FootstepsDelay());
                    index++;

                    if (index == clips.Length) { index = 0; }
                }

            }
        }
    }
    //

    IEnumerator FootstepsDelay()
    {
        source.clip = clips[index];
        playing = true;
        source.Play();
        if (!player.move.running)
        {
            yield return new WaitForSeconds(0.7f);
            playing = false;
        }
        else
        {
            yield return new WaitForSeconds(0.25f);
            playing = false;
        }



    }
}
