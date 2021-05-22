using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketGameController : MonoBehaviour
{
    public RocketMovement player;
    public Camera camfollow;


    // Start is called before the first frame update
    void Start()
    {
        print("Welcome to Rocket Boost Game!\nPress LeftArrow key to Turn left\nPress RighttArrow key to Turn right\nPress UpArrow to boost\n");

    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null)
        {
        camfollow.transform.position= new Vector3(player.transform.position.x,camfollow.transform.position.y,player.transform.position.z);
        }
    }
}
