using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    
    int RocketSpeed=2000;
    int boost=1;
    Vector3 Direction;
  /*  void Start()
    {
        this.GetComponent<Rigidbody>().velocity=new Vector3(GetComponent<Rigidbody>().velocity.x,GetComponent<Rigidbody>().velocity.y,RocketSpeed*Time.deltaTime);
    }*/
    // Update is called once per frame

    void Update()
    {
        Direction=Vector3.zero;
        //rocket movement
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(0.0f,0.0f,90.0f);        
            }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(0.0f,0.0f,-90.0f);            
            }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                boost++;
                RocketSpeed=RocketSpeed*boost;
                
            } 
                this.GetComponent<Rigidbody>().velocity=new Vector3(GetComponent<Rigidbody>().velocity.x,GetComponent<Rigidbody>().velocity.y,RocketSpeed*Time.deltaTime);

    }
}
