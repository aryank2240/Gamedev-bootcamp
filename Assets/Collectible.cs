using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
    public class Collectible : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player")) {
                Destroy(gameObject);
                Debug.Log("Item Collected");
            }
        }
    }
// Start is called before the first frame update


    // Update is called once per frame
   