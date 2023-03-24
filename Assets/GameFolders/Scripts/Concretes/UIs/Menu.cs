using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Tavern");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
    public void XButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitButton()
    {
        Application.Quit();
    }

}
