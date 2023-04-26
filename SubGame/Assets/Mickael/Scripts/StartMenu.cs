using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Made by Mickael

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Det denna kod g�r �r att byta scene till den som kommer efter n�r du tryckt p� Play.
    }



    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit(); // Denna kod st�nger av spelet 
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
