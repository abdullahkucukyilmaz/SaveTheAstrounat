using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneControl : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(2);
    }
    public void help()
    {
        SceneManager.LoadScene(1);
    }
    public void home()
    {
        SceneManager.LoadScene(0);
    }
}
