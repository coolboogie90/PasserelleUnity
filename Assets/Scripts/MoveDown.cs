using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [Tooltip("Move Down.")]

    public float speed = 1f;
    private float factor = -1f;
    //on peut également ajouter un range >>> crée un slider dans unity avec un min/max
    //ex : [Range(0, 5f)]

    public GameObject maxYPosition;
    public GameObject minYPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed * factor, 0) * Time.deltaTime;
        
        if(minYPosition != null && transform.position.y <= minYPosition.transform.position.y)
        {
            factor = 1f;            //inverse la position en y quand on arrive à 0 => après sa chute, l'objet remonte
        }
        else if(maxYPosition != null && transform.position.y >= maxYPosition.transform.position.y)
        {
            factor = -1f;
        }
    }
}
// Ne pas oublier d'assigner une target dans Unity