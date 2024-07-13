using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Rigidbody rb; // lực khối lượng gia tốc gì đó cu ả game dung de lam movement
    private float speed;
   
    
    // Start is called before the first frame update
    private void Awake()
    {
        speed = Const.Speed_Original;
        jumpAmount = Const.jumpForce;
    }
    void Start()
    {
        GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {   //player movement 
        //move Z
        transform.Translate(0,0,speed *Time.deltaTime);
        
}
 