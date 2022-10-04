using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFire : MonoBehaviour
{ 
    public GameObject bulletFactory;
    // 총구 
    public GameObject firePosition;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            GameObject bullet = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.transform.position;
        }
    }
}
