using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToSearch : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoHomeScreen()
    {
        SceneManager.LoadScene("Home");
    }

    // Update is called once per frame
    public void GotoSearchScene()
    {
        SceneManager.LoadScene("SearchScene");
    }
}
