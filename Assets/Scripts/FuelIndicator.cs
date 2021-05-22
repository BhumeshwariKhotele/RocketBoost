using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FuelIndicator : MonoBehaviour
{
    float CurrentFuel=0.0f;
    float InitialFuel=999.0f;

    public Text GamwOver;
   public Text FuelIndication;
    // Start is called before the first frame update
    void Start()
    {
        CurrentFuel=InitialFuel;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentFuel -= 5 *Time.deltaTime;
        FuelIndication.text= CurrentFuel.ToString ("0");

        if( CurrentFuel <= 0.0f)
        {
            CurrentFuel=0;
            GamwOver.text="GAME OVER";
        }
    }

    
}
