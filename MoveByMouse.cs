using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
            
{
    protected Vector3 worldPosition;
    protected float speed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        worldPosition.z = 0;

    }

    // Update is called once per  
    void FixedUpdate()
    {
        
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 0;
        Vector3 newPosition =Vector3.Lerp(transform.position, worldPosition, speed);
        
        transform.position = newPosition;
        
    }
}
 