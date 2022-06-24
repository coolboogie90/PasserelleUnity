using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour 
{
    public enum Direction
    {
        up, down, left, right
    }

    public Direction actualDirection = Direction.up;

    [Tooltip("Elevator speed.")]
    [Range(0, 5f)] public float speed = 3f;

    public bool on = false;
        
    // Update is called once per frame
    virtual protected void Update()
    {
        if(!on) return;

        Vector3 movement = Vector3.zero;   //Vector3(x, y, z) ---> si pas spécifié, va donner les valeurs par défaut du Vector3 = (0, 0, 0)
        //Ou : Vector3 movement = new Vector3();   

        switch (actualDirection)
        {
            case Direction.up: 
                movement = Vector3.up;  //Shorthand for writing Vector3(0, 1, 0) ---> y = 1 pour monter
                break;
            case Direction.down: 
                movement = Vector3.down;    //Shorthand for writing Vector3(0, -1, 0) ---> y = -1 pour descendre
                break;
            case Direction.left: 
                movement = Vector3.left;
                break;
            case Direction.right: 
                movement = Vector3.right;
                break;
        }
        
        transform.position += movement * speed * Time.deltaTime;
    }
    
    public void Active(){
        on = true;
    }

    public void ChangeSpeed(float speed){
        this.speed = speed;  //si on nomme une variable locale comme une variable attribut = effet de masque : la var locale est masquée par la var attribut
    }

}

    
    
/* Obtenir déplacement : quand on multiplie un vecteur par un scalaire, on multiplie chaque valeur à la fois ==> (0, 1, 0) * 5 = (0, 5, 0)
déplacement = vitesse * temps





/* -----Différence entre classe et structure-----

a1 = A()
a2 = a1
a2.b = 3

- class : a1 = emplacement de mémoire > a1 et a2 ont le même emplacement de mémoire = pas d'augmentation de la mémoire/ passage de référence,  par la mémoire/point(eur)
- struct : on copie les données mais pas les pointeurs >>> la variable b de a2 n'est pas égale au b de a1 = passage par la valeur


Autre ex: si mon Orc est une class :
m1 = Orc() - adresse en mémoire de là on se trouve mes données
m2 = Orc()
m3 = m1 ---> même emplacement de mémoire = même variable que l'on est en train d'affecter

Si mon Orc est une struct :
on augmente la mémoire car m1 et m2 ne sont pas au même emplacement de mémoire
Vector3 = une struct qui permet de copier les données ET de les modifier pour chaque variable/objet(ex: changer de position)

*/