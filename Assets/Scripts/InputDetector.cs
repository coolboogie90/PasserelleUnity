using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputDetector : MonoBehaviour
{
    [HideInInspector]
    public UnityEvent onInputDetected;

    public UnityEvent onSneeze;
    
    [System.Serializable]
    public class SneezeEvent : UnityEvent<int>{}
    public SneezeEvent onSneezeWithNumber;
    int numberOfSneezes = 0;
    
    
    /*Serialize Field fait en sorte que Unity montre un champ privé dans l'inspecteur (inverse de HideInspector)
    [SerializeField] // "Donne-moi une représention de chose"
    private int number;
    */
    
    // Awake is called before start
    void Awake()
    {
        onInputDetected = new UnityEvent();

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.anyKeyDown)
        {
            onInputDetected?.Invoke(); // ?. = "si ma condition n'est pas nulle, tu peux Invoke() cela"
            numberOfSneezes++;
            onSneeze?.Invoke();
            onSneezeWithNumber?.Invoke(numberOfSneezes); // Dans Unity, bien choisir la function Dynamic int et pas Static
        }
        
        // Equivalant à : 
        //  if(Input.anyKeyDown && onInputDetected != null)
        //      {
        //          onInputDetected.Invoke();
        //      }
        
    }
}
