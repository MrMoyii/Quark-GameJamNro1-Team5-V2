using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject buttomPause;
    [SerializeField] private GameObject menuPause;

    public void Pause()
    {
        Time.timeScale = 0f;
        buttomPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f; 
        buttomPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
