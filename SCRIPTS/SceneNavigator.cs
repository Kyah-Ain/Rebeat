using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneNavigator : MonoBehaviour
{
    public GameObject activeScene;
    public GameObject nextScene;

    public void ButtonNextScene()
    {
        if (activeScene != null)
        {
            activeScene.SetActive(false);
        }

        if (nextScene != null)
        {
            nextScene.SetActive(true);
        }
        else
        {
            Debug.Log("Wala napong scene bossing. ; (");
        }
    }

}
