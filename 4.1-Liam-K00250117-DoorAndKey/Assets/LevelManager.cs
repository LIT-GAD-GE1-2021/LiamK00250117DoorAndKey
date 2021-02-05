using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
   
    public static LevelManager instance;
    public GameObject keyObject;
    public GameObject doorSwitch;

    private bool keyControl = false;

    private bool doorOpen = false;

    public OpenTheDoor doorOpenner;

    

     public void TurnOn()
     {
        if (Input.GetKeyDown(KeyCode.Space) == true && keyControl == true)
        {
            Debug.Log("Level Switch works");
            
            doorOpen = true;

            doorOpenner.DoorOpen();

           // Open



        }
      
     }
  

    private void Awake()
    {
        instance = this;
    }

    public void KeyGet()
    {

        keyControl = true;
        
        Debug.Log("Key Gotten");

    }

   





}
