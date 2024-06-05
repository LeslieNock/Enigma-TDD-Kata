using NUnit.Framework;

namespace Enigma.Tests
{
    [TestFixture]
    [Parallelizable]
    public class GivenAPlugBoard
    {
        private PlugBoard _subject;

        [OneTimeSetUp]
        public void WhenNoConfigurationHasBeenDefined()
        {
            _subject = new PlugBoard();
        }

        [Test]
        public void ThenTheUsersInputIsNotModified()
        {
            Assert.That(_subject.Process('A'), Is.EqualTo('A'));
        }
    }
}