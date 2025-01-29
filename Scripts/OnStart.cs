using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStart : MonoBehaviour
{

    private GameObject toDestroy;
    private float timerDelay = 4f;
    private float timeElapsed;


    public void DestroyAll()
    {
        toDestroy = GameObject.FindWithTag("Destroy");
        Destroy(toDestroy);
    }
}
  

