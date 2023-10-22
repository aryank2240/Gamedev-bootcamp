using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shit : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapstrength = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * flapstrength;


        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * flapstrength;


        }
    }
    
   
    
}
