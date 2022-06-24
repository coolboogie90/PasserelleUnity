using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ChangeColor : MonoBehaviour
{
    public Color color = Color.cyan;
    public float chrono = 5f;

    private bool isColorChanged = false;
    public UnityEvent whenColorChanged;

    // Start is called before the first frame update
    void Start()
    {
        // Renderer renderer = GetComponent<Renderer>();
        // Material material = renderer.material;
        // material.color = color;         // !!! on ne peut pas travailler comme ça avec une structure
    
    }

    // Update is called once per frame
    void Update()
    {
        chrono -= Time.deltaTime;  //va décrémenter le chrono
        
        if(chrono <= 0f){
            if (!isColorChanged){
                isColorChanged = true;
                GetComponent<Renderer>().material.color = color;
                whenColorChanged.Invoke();
            }
        }
    }
}
