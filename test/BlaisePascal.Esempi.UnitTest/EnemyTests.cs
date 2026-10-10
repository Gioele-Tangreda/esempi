using BlaisePascal.esempi.Domain;

namespace BlaisePascal.Esempi.UnitTest
{
    public class EnemyTests
    {
        [Fact]
        public void Test1()
        {
            Enemy enemy = new Enemy();

            Assert.Equal(100, enemy.Health);
        }
    }
}
