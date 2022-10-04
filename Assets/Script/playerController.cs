using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class playerController : MonoBehaviour
{
    Vector3 postion;
    public float Speed = 1;
    void Start()
    {
        postion = transform.position;    
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            postion.x -= Speed*Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            postion.x += Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            postion.y += Speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            postion.y -= Speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = 0.5f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = 1.0f;
        }

        postion.x = Clamp(postion.x, -3, 3);
        postion.y = Clamp(postion.y, -5, 7);

        transform.position = postion;

        
    }
}
