using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
public class lore : MonoBehaviour
{

    
    public GameObject LorePanel;
    public void Start()
    {
        LorePanel.SetActive(false);
    }
    public void ShowLorePanel()
    {
        LorePanel.SetActive(true);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void Update()
    {
        {
          
            if (Input.GetKeyDown(KeyCode.L)) { LorePanel.SetActive(false); }
        }
    }
}

