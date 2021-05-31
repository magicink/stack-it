using NUnit.Framework;
using States;

namespace Tests.PlayMode.States
{
    public class GameStatesTests
    {
        [Test]
        public void ExposesStates()
        {
            Assert.That(GameStates.Playing, Is.InstanceOf<PyxlMedia.States.State>());
            Assert.That(GameStates.Idle, Is.InstanceOf<PyxlMedia.States.State>());
            Assert.That(GameStates.Demo, Is.InstanceOf<PyxlMedia.States.State>());
        }
    }
}