using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTerminator : MonoBehaviour
{
    public GameObject lastScene;

    public void Terminate()
    {
        lastScene.SetActive(false);
    }

    public void Enable()
    {
        lastScene.SetActive(true);
    }
}
