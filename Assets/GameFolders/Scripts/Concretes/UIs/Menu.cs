using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("PlayerStory");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
    public void XButton()
    {
        GameManager.Instance.GodIndex = 0;
        GameManager.Instance.GenIndex = 0;
        SceneManager.LoadScene("Menu");
    }
    public void QuitButton()
    {
        Application.Quit();
    }

    public void KitchenButton()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void TavernButton()
    {
        SceneManager.LoadScene("Tavern");
    }
}
