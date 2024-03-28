using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneButtons : MonoBehaviour
{
    public GameObject pnlOptions;
    public void ToggleOptions()
    {
        if (pnlOptions != null)
        {
            bool IsOptionsActive = pnlOptions.activeSelf;
            pnlOptions.SetActive(!IsOptionsActive);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        EndGame.EndTimer += Time.timeSinceLevelLoad;
    }

    public void NextLevel()
    {
        int NextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(NextLevelIndex);
        EndGame.EndTimer += Time.timeSinceLevelLoad;
    }

    public void QuittingGame()
    {
        Application.Quit(0);
    }
}
