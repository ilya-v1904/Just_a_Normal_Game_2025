using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonOpenScene : MonoBehaviour
{
    public int sceneId;
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneId);
    }

}
