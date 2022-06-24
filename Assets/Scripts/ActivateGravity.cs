using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGravity : MonoBehaviour
{
    Rigidbody rb; 
    // Start is called before the first frame update
    private void Start()
    {
        InputDetector detector =  GetComponent<InputDetector>(); //on crée une variable contenant une instance d'une classe puis on lui dit "Va me chercher un objet de TYPE InputDetector (toute la class)
        detector.onInputDetected.AddListener(StartFalling); // On va creuser encore plus : après avoir cherché notre InputDetector(), on va trouver son UnityEvent onInputDetected
        //Equivalent à :
        //  GetComponent<InputDetector>().onInputDetected.AddListener(StartFalling)
        rb = GetComponent<Rigidbody>();
        
    }

    public void StartFalling(){
        rb.useGravity = true;
        Debug.Log("GERONIMOOOOOOOOOOOOOOOOOOooooooooooooooooooo.........");
    }
}
