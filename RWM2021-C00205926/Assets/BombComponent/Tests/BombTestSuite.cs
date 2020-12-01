using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;



    public class BombTestSuite
    {
        // A Test behaves as an ordinary method
        [UnityTest]
        public IEnumerator TestSpawn()
        {

            yield return new WaitForSeconds(0.1f);

            
        }
    }
