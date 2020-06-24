using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 此类用于切换scene
 * 1.初始界面scene名为First_UI
 * 2.游戏界面scene名为SampleScene
 */
public class StartUIController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EnterGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("First_UI");
    }
}
