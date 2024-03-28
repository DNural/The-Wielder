using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartingGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuittingGame()
    {
        Application.Quit(0);
    }
}
