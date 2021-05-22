using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second : MonoBehaviour
{
    int Speedamt1=15;

   private void OnCollisionEnter(Collision x)
    {
       //print(x.gameObject.tag);

        if(x.gameObject.CompareTag("Left"))
        {
            Speedamt1=15;
        }

        if(x.gameObject.CompareTag("Right"))
        {
            Speedamt1=-15;
        }

    }

    void Update()
    {
        transform.Translate(Speedamt1*Time.deltaTime,0,0);
    }
}