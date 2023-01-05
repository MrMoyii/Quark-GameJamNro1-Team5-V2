using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject buttomPause;
    [SerializeField] private GameObject menuPause;

    [SerializeField] private float transitionTime = 1f;
    [SerializeField] private Animator transitionScene;

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
    public void MainMenu()
    {
        //SceneManager.LoadScene("MainMenu");
        //StartCoroutine(SceneLoad("MainMenu"));

        Invoke("Transition", transitionTime);
        SceneManager.LoadScene("MainMenu");
    }

    public void Transition()
    {
        transitionScene.SetTrigger("StartTransition");
    }

    //public IEnumerator SceneLoad(string sceneIndex)
    //{
    //    transitionScene.SetTrigger("StartTransition");
    //    Debug.Log("Toyaqui");
    //    yield return new WaitForSeconds(transitionTime);
    //    Debug.Log("Toyalla");
    //    SceneManager.LoadScene(sceneIndex);
    //}
}
