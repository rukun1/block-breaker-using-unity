using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestatus : MonoBehaviour
{
    // Start is called before the first frame update

   [Range(0.1f,2.5f)] [SerializeField] float gamespeed = 1f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gamespeed;
    }
}
