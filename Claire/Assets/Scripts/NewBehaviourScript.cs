using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    public void Game()
    {

        SceneManager.LoadScene(1);
    }
    public void Exit()
    {

        EditorApplication.isPlaying = false;
        Application.Quit();
        //Debug.Break();                                            
    }
    public void Back()
    {

        SceneManager.LoadScene(0);
    }

}
