using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("SpaceShip_withBG");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}