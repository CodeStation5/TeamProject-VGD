using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCall : MonoBehaviour
{

    // Opens first scene of game
    public void FirstScene (string index)
    {
        SceneManager.LoadScene(index);
    }
}
