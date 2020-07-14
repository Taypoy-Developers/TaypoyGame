using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class KeyCollected_playtest
    {

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator KeyCollected_playtestWithEnumeratorPasses()
        {
            var gameObject = new GameObject();
            var keycoll = GameObject.Find("key");
            var keycollec = new KeyCollected();
            
            
            yield return new WaitForSeconds(2.0f);
            //Assert.True(keycoll.GetComponent<SpriteRenderer>().enabled==false);
        }
    }
}
