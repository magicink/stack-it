using System.Collections;
using Factories;
using Managers;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class AppManagerFactoryTests
{
    [UnityTest]
    public IEnumerator InstanceIsAnAppManager()
    {
        var gameObject = new GameObject();
        gameObject.AddComponent<AppManagerFactory>();
        Assert.That(AppManagerFactory.Instance, Is.TypeOf<AppManager>());
        yield return null;
    }
}
