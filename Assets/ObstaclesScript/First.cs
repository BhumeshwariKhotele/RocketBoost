using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    int Speedamt3=15;

   private void OnCollisionEnter(Collision z)
    {
        //print(z.gameObject.name);

        if(z.gameObject.CompareTag("Left"))
        {
            Speedamt3=-15;
        }

        if(z.gameObject.CompareTag("Right"))
        {
            Speedamt3=15;
        }

    }

    void Update()
    {
        transform.Translate(0,0,Speedamt3*Time.deltaTime);
    }
}