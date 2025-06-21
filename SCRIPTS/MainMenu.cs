using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GameButtonStart()
    {
        SceneManager.LoadScene("RebeatVisualNovelPart1");
    }

    public void GameButtonRestart()
    {
        SceneManager.LoadScene("RebeatMainMenu");
    }

    public void GameButtonQuit()
    {
        Application.Quit();
    }
}
