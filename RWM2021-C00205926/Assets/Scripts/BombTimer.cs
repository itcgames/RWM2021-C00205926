using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTimer : MonoBehaviour
{
    float count = 1f;

    BombSpawner bombSpawner;

    void Start()
    {
        bombSpawner = GameObject.Find("BombSpawner").GetComponent<BombSpawner>();
    }

    void Update()
    {
        count -= Time.deltaTime;
        if (count <= 0.0f)
        {
            Destroy(gameObject);
            bombSpawner.bombAlive = false;
        }
    }
}
