using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    [SerializeField] int breakableblocks;


    ScreenLoader sceenloader;

    private void Start()
    {
        sceenloader = FindObjectOfType<ScreenLoader>();
    }



    public void countingBlocks()
    {
        breakableblocks++;
    }

    public void DestroyedBlocks()
    {
        breakableblocks--;
        if (breakableblocks <= 0)
        {
            sceenloader.LoadNextScene();
        }
    }
}
