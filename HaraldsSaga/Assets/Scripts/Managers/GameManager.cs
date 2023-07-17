using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }

    public void MainMenuPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenuQuit()
    {
        Application.Quit();
    }
}
