using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    bool bombAlive = false;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")) 
            if(bombAlive == false)
            {
                {
                    Instantiate(bomb, transform.position, Quaternion.identity);
                    bombAlive = true;
                }
            }

    }
}
