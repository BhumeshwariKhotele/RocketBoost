using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Third : MonoBehaviour
{
    int Speedamt2=15;

   private void OnCollisionEnter(Collision y)
    {
      //  print(y.gameObject.tag);

        if(y.gameObject.CompareTag("Right"))
        {
            Speedamt2=15;
        }

        if(y.gameObject.CompareTag("Left"))
        {
            Speedamt2=-15;
        }

    }

    void Update()
    {
        transform.Translate(Speedamt2*Time.deltaTime,0,0);
    }
}