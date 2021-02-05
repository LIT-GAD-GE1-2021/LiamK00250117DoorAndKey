using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{

    public Animator switchAnimator;

    private bool switchOn = false;

    private bool playerCheck = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && playerCheck == true)
        {

            LevelManager.instance.TurnOn();


        }



    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Collision works");

            playerCheck = true;

        }


        else
        {
            switchAnimator.SetBool("SwitchTrigger", false);
            playerCheck = false;

        }

    }

    

}
