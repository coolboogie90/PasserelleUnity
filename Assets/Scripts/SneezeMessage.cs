using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneezeMessage : MonoBehaviour
{
    public void SneezeNoArgument(){
        Debug.Log("Atchoum!");
    }

    public void SneezeOneArgument(int numberOfTimes){
        Debug.Log($"Sneezed {numberOfTimes} times.");
    }

}