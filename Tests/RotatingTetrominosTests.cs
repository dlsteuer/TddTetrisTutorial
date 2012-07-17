using NUnit.Framework;

namespace Tetris.Tests
{
    public class RotatingTetrominosTests
    {
        [TestFixture]
        public class All_Shape_Instances : TetrominoTest
        {
            [SetUp]
            public void CreateAnyShape()
            {
                _shape = Tetromino.T_SHAPE;
            }

            [Test]
            public void Are_Immutable()
            {
                var original = _shape.ToString();
                _shape.RotateRight();
                Assert.That(original, Is.EqualTo(_shape.ToString()));
                _shape.RotateLeft();
                Assert.That(original, Is.EqualTo(_shape.ToString()));
            }
        }

        [TestFixture]
        public class The_T_Shape : TetrominoTest
        {
            [SetUp]
            public void CreateTShape()
            {
                _shape = Tetromino.T_SHAPE;
            }

            [Test]
            public void Is_Shaped_Like_T()
            {
                Assert.That("" +
                    ".T.\n" +
                    "TTT\n" +
                    "...\n", Is.EqualTo(_shape.ToString()));
            }
        }
    }

    public class TetrominoTest
    {
        protected Tetromino _shape;
    }
}