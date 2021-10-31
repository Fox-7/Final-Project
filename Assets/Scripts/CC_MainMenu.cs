using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CreditsMenu;
    public GameObject LevelMenu;


    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void PlayNowButton()
    {
        // Play Now Button has been pressed, begin loading
        UnityEngine.SceneManagement.SceneManager.LoadScene("Loading");
    }

    public void QuitToMainMenu()
    {
        // Quit Button has been pressed, exit to main menu
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }

    public void CreditsButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }

    public void LevelButton()
    {
        // Show Level Select Menu
        MainMenu.SetActive(false);
        LevelMenu.SetActive(true);
    }

    public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
        LevelMenu.SetActive(false);

    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}