using System.Collections;
using Managers;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.PlayMode.Managers
{
    public class AppManagerTests
    {
        [UnityTest]
        public IEnumerator HasCorrectInitialState()
        {
            var gameObject = new GameObject();
            gameObject.AddComponent<AppManager>();
            var appManager = gameObject.GetComponent<AppManager>();
            Assert.That(appManager.CurrentState, Is.InstanceOf<PyxlMedia.States.State>());
            yield return null;
        }
    }
}