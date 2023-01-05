using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private float transitionTime = 1f;
    [SerializeField] private Animator transitionScene;
    public void GameScene()
    {
        StartCoroutine(SceneLoad("TestScene"));
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public IEnumerator SceneLoad(string sceneIndex)
    {
        transitionScene.SetTrigger("StartTransition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
