using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour
{
    public GameObject pickupeffect;
    public GameObject something;
    void pickup()
    {
        Instantiate(pickupeffect, transform.position, transform.rotation);
        Destroy(pickupeffect);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { pickup();
            Destroy(gameObject);
            something.transform.localScale = new Vector3(3f,3f,3f);
            Debug.Log("powerup collectd");
        } 
        
    }
    
}
