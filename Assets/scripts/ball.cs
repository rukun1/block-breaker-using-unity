using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Paddle paddle1;
    Vector2 padBalDis;
    bool hasStarted = false;
    [SerializeField] AudioClip[] ballsounds;

    //cached components
    AudioSource MyAudio; 
    void Start()
    {
        padBalDis = transform.position - paddle1.transform.position;
        MyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockOnPaddle();
            LaunchOnClick();
        }
    }

    private void LaunchOnClick()
    {
      if(Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }

    private void LockOnPaddle()
    {
        Vector2 paddlepos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + padBalDis;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            AudioClip clip = ballsounds[UnityEngine.Random.Range(0, ballsounds.Length)];
            MyAudio.PlayOneShot(clip);
        }
    }

}
