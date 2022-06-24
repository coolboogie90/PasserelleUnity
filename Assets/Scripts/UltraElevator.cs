using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraElevator : Elevator
{
    public float timeToInverse = 2f;
    public float chrono = 0f;
    public int count = 0;   // cointains the number trips

    override protected void Update() 
    {
        base.Update();

        chrono += Time.deltaTime;
        
        if (chrono >= timeToInverse)
        {
            chrono = 0f; 
            count++; //count += 1;

            switch (actualDirection) {
                case Direction.up: 
                    actualDirection = Direction.down;  //Shorthand for writing Vector3(0, 1, 0) ---> y = 1 pour monter
                    break;
                case Direction.down: 
                    actualDirection = Direction.up;    //Shorthand for writing Vector3(0, -1, 0) ---> y = -1 pour descendre
                    break;
                case Direction.left: 
                    actualDirection = Direction.right;
                    break;
                case Direction.right: 
                    actualDirection = Direction.left;
                    break;
            }
        }
    }
}
        //Debug.Log(chrono);  // !!! ralentit notre programme, il faut être parcimonieux avec les log
