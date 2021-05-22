using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitLayout : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        //if rocket colliding Layout its getting destroyed
        if(collision.gameObject.name=="Layout")
        {
         
            gameObject.SetActive(false);
               Destroy(gameObject,3.0f);
            print("Rocket Collide\nGAME OVER\n");
        }
         
         //if rocket colliding Obstacles its getting destroyed
         if(collision.gameObject.CompareTag("Obstacles"))
        {
            gameObject.SetActive(false);
            Destroy(gameObject,3.0f);
            print("Rocket Collide Obstacles\nGAME OVER\n");
        }
    }

private void OnTriggerEnter(Collider other)
{
     if(other.gameObject.CompareTag("Dest"))
        {
            print("WON THE GAME\nReached Destnation Point\n");
        }
}
}
