using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public void ShowMenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void HideMenu()
    {
        menu.SetActive(false);
        Time.timeScale = 1  ;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMenu();
        }
    }
}
