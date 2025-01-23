using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public string loadLevel;
    public GameObject LoadingScreen;
    public Slider bar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load()
    {
        LoadingScreen.SetActive(true);
        //SceneManager.LoadScene(loadLevel);


        StartCoroutine(LoadAsync());
    }





    IEnumerator LoadAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(loadLevel);

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            bar.value = asyncLoad.progress;
            if (asyncLoad.progress >= .9f && !asyncLoad.allowSceneActivation)
            {
                if (Input.anyKeyDown && (Input.anyKey))
                {
                    asyncLoad.allowSceneActivation = true;
                }
            }
            yield return null;
            
        }
    }
}
