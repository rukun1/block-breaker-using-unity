using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour

{

    [SerializeField] AudioClip breaksound;
    level Level;

    private void Start()
    {
        Level = FindObjectOfType<level>();
        Level.countingBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BlockDestroying();
    }

    private void BlockDestroying()
    {
        AudioSource.PlayClipAtPoint(breaksound, Camera.main.transform.position);
        Destroy(gameObject);
        Level.DestroyedBlocks();
    }
}
