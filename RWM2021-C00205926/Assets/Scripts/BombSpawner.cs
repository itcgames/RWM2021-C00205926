using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public GameObject bomb;
    private GameObject bombRef;
    public bool bombAlive;

    void Start()
    {
        bombRef = bomb;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (bombAlive == false)
            {
                Debug.Log(bomb);
                Instantiate(bomb, transform.position, Quaternion.identity);
                bombAlive = true;
            }
        }
    }
}
