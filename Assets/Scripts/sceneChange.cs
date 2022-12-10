using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    
    
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void sceneGeneralStore()
    {
        SceneManager.LoadScene("General Store");
    }
    public void sceneHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void sceneMinigameStore()
    {
        SceneManager.LoadScene("Minigame Store");
    }

    public void scenePremiumStore()
    {
        SceneManager.LoadScene("Premium Store");
    }
}
