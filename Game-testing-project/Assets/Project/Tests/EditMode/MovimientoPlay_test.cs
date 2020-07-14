using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MovimientoPlay_test
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MovimientoPlay_testSimplePasses()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(2, new MovimientoPlay().caminar);
            Assert.AreEqual(3, new MovimientoPlay().saltar);
            Assert.AreEqual(0.5f, new MovimientoPlay().fallMultiplayer);
            Assert.AreEqual(1f, new MovimientoPlay().lowMultiplayer);
        }

    }
}
