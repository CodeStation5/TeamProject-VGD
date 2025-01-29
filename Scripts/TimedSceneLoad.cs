using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedSceneLoad : MonoBehaviour
{
    public CanvasGroup canvasgroup;
    [SerializeField]
    public float timerDelay = 55f;
    [SerializeField]
    public string sceneLoad;
    private float timeElapsed;
    public bool fadeInBlack;
    public bool fadeOutBlack;
    public float fadeTime;
    public bool isTimed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= (timerDelay - fadeTime) && isTimed == true)
        {
            if (fadeInBlack == true)
            {
                canvasgroup.alpha = 1;
            }
            if (fadeOutBlack == true)
            {
                canvasgroup.alpha = 0;
            }
            if (timeElapsed > timerDelay && isTimed == true)
            {
                SceneManager.LoadScene(sceneLoad);
            }
        }
    }

    public void FadeIn()
    {
        fadeInBlack = true;
    }
    public void FadeOut()
    {
        fadeOutBlack = true;
    }
}
