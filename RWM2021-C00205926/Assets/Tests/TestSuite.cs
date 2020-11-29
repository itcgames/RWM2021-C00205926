using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

namespace Tests
{

    public class TestSuite
    {
        private BombSpawner game;
        // A Test behaves as an ordinary method
        [UnityTest]
        public IEnumerator TestSpawn()
        {
            GameObject gameGameObject = Resources.Load("bomb") as GameObject;
           game = gameGameObject.GetComponent<BombSpawner>();

            Input.GetKeyDown("space");
     
            yield return new WaitForSeconds(0.1f);

            
        }
    }
}
