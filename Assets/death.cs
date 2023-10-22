using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    private string sceneIndex;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Restart();
        }
    }
        // Start is called before the first frame update
        public void Restart()
    {
            int sceneInde = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
    }
       
    // Update is called once per frame
    void Update()
    {
        
    }
}

