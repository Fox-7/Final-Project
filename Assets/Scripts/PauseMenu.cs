using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            //Opens pause menu
            if (!pausePanel.activeInHierarchy)
            {
                PauseGame();
            }
            //Closes pause menu
            else if (pausePanel.activeInHierarchy)
            {
                ContinueGame();
            }
        }
    }
    public void PauseGame()
    {
        //Disable scripts that still work while timescale is set to 0
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void ContinueGame()
    {
        //Enables the scripts again
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void QuitToMainMenu()
    {
        //Exit to main menu
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}