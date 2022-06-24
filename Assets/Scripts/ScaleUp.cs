using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScaleUp : MonoBehaviour
{
    [Range(0f, 20f)] public float speed = 1f;
    public Vector3 maximumScale = new Vector3(3,3,3);

    private bool maximalScaleIsReached = false;
    public UnityEvent whenMaximalScaleIsReached;

    // public enum Scale {one}
    // public LocalScale actualScale = Scale.one;

    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale += Vector3.right * 2;
    }

    // Update is called once per frame
    
    void Update()
    {
        
        if(transform.localScale != maximumScale)
        {
            transform.localScale += Vector3.one * speed * Time.deltaTime;
            transform.localScale = Vector3.Min(transform.localScale, maximumScale);
        }
        else if (!maximalScaleIsReached)
        {
            maximalScaleIsReached = true;
            whenMaximalScaleIsReached.Invoke();  // dans Unity, notre cube ElevatorEvent ne se mettra à montrer que si notre cylindre a fini d'obtenir son maximumScale
        }
    }
}
        // Vector3 inflation = Vector3.one * speed * Time.deltaTime;
                            // Vector3.one = new Vector3(1,1,1)w
        // transform.localScale += inflation;


        //Rappel : déplacement = vitesse * temps
        //Exemple : Si on veut up et right, mais pas forward : transform.localScale += (Vector3.up + Vector3.right) * speed * Time.deltaTime

        // switch (actualScale)
        // {
        //     case Scale.one: 
        //         inflation = Scale.zero;  
        //         break;
        // }