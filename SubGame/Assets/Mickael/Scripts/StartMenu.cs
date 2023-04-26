using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Made by Mickael

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Det denna kod gör är att byta scene till den som kommer efter när du tryckt på Play.
    }



    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit(); // Denna kod stänger av spelet 
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
