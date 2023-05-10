using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float p=16f ;
    float mousePos;
    float minX = 1.3f;
    float minY = 14.7f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = (Input.mousePosition.x / Screen.width * p);
       // Debug.Log(mousePos);
       
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mousePos, minX, minY);
        transform.position = paddlepos;

    }
}
