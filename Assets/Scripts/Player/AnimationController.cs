using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class AnimationController : MonoBehaviour
{

    public Animator anim;
    Movement move;
    PhotonView view;




    bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponentInParent<PhotonView>();
        anim = GetComponent<Animator>();
        move = GetComponentInParent<Movement>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (view.IsMine)
        {

            if (move.jumping){
                anim.SetBool("jumping", true);
            }
            else
            {
                anim.SetBool("jumping", false);
            }

            if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
            {
                anim.SetBool("walking", false);
                anim.SetBool("running", false);
            }
            else
            {
                if (move.running == true)
                {
                    anim.SetBool("walking", false);
                    anim.SetBool("running", true);
                }
                else
                {
                    anim.SetBool("walking", true);
                    anim.SetBool("running", false);


                }
            }
        
        }

    }
}
