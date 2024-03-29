using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestructionElevator : UltraElevator
{
    [Tooltip("Number of Trips before autodestruction.")]
    public int numberOfTrips = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    override protected void Update()
    {
        base.Update();
        if (count >= numberOfTrips){
            Destroy(gameObject);
        }
    }
}
