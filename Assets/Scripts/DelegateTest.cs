using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    delegate void SimpleFunction();

    SimpleFunction attack;
    // Start is called before the first frame update
    void Start()
    {
        attack += DealDamage;
        attack += PlaySound;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown){
            attack();
        }
    }

    void DealDamage(){
        Debug.Log("2 damage!");
    }

    void PlaySound(){
        Debug.Log("Baby Don't Hurt Me! No More! *insert eurobeat track*");
    }

}


/* Website --- https://gamedevbeginner.com/events-and-delegates-in-unity/ */ 

/* Quand une var est static elle existe UNE FOIS pour TOUTES les instances de la classe, SANS besoin de passer par un objet 
    Elle est pas liée à une instance de la classe mais à la classe elle-même.
*/ 