using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoHomeScene()
    {
        SceneManager.LoadScene("Home");
    }

    // Update is called once per frame
    public void GotoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

}
