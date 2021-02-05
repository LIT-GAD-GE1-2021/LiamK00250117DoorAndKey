using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    

    public Rigidbody2D theRB;

    public void DoorOpen()
    {
          theRB.velocity = Vector2.up * 10;
    }


    void Update()
    {

        
        

    }

    

}
