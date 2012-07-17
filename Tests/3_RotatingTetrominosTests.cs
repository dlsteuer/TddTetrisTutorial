using NUnit.Framework;

namespace Tetris.Tests
{
    public class RotatingTetrominosTests
    {
/*
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
*/
 /*
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
                var expected = "" + 
                    ".T.\n" + 
                    "TTT\n" + 
                    "...\n";
                Assert.That(_shape.ToString(), Is.EqualTo(expected));
            }

            //[Test]
            //public void Can_Be_Rotated_Right_3_Times()
            //{
            //    _shape = _shape.RotateRight();
            //    var expected = "" + 
            //        ".T.\n" + 
            //        ".TT\n" + 
            //        ".T.\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //    _shape = _shape.RotateRight();
            //    expected = "" +
            //        "...\n" +
            //        "TTT\n" +
            //        ".T.\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //    _shape = _shape.RotateRight();
            //    expected = "" +
            //        ".T.\n" +
            //        "TT.\n" +
            //        ".T.\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //}

            //[Test]
            //public void Can_Be_Rotated_Left_3_Times()
            //{
            //    _shape = _shape.RotateLeft();
            //    var expected = "" +
            //        ".T.\n" +
            //        "TT.\n" +
            //        ".T.\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //    _shape = _shape.RotateLeft();
            //    expected = "" +
            //        "...\n" +
            //        "TTT\n" +
            //        ".T.\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //    _shape = _shape.RotateLeft();
            //    expected = "" +
            //        ".T.\n" +
            //        ".TT\n" +
            //        ".T.\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //}

            //[Test]
            //public void Rotating_It_4_Times_Will_Go_Back_To_The_Original_Shape()
            //{
            //    var originalShape = _shape.ToString();
            //    _shape = _shape.RotateRight().RotateRight().RotateRight().RotateRight();
            //    Assert.That(_shape.ToString(), Is.EqualTo(originalShape));
            //    _shape = _shape.RotateLeft().RotateLeft().RotateLeft().RotateLeft();
            //    Assert.That(_shape.ToString(), Is.EqualTo(originalShape));
            //}
        }
*/
 /*
        [TestFixture]
        public class The_I_Shape : TetrominoTest
        {
            [SetUp]
            public void CreateIShape()
            {
                _shape = TetrominoTest.I_SHAPE;
            }

            [Test]
            public void Is_Shaped_Like_I()
            {
                var expected = "" +
                    ".....\n" +
                    ".....\n" +
                    "IIII.\n" +
                    ".....\n" +
                    ".....\n";
                Assert.That(_shape.ToString(), Is.EqualTo(expected));
            }

            //[Test]
            //public void Can_Be_Rotated_Right_Once()
            //{
            //    _shape = _shape.RotateRight();
            //    var expected = "" +
            //        ".....\n" +
            //        "..I..\n" +
            //        "..I..\n" +
            //        "..I..\n" +
            //        "..I..\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //}

            //[Test]
            //public void Can_Be_Rotated_Left_Once()
            //{
            //    _shape = _shape.RotateLeft();
            //    var expected = "" +
            //        ".....\n" +
            //        "..I..\n" +
            //        "..I..\n" +
            //        "..I..\n" +
            //        "..I..\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //}

            //[Test]
            //public void Rotating_It_Twice_Will_Get_Back_To_The_Original_Shape()
            //{
            //    var originalShape = _shape.ToString();
            //    _shape = _shape.RotateRight().RotateRight();
            //    Assert.That(_shape.ToString(), Is.EqualTo(originalShape));
            //    _shape = _shape.RotateLeft().RotateLeft();
            //    Assert.That(_shape.ToString(), Is.EqualTo(originalShape));
            //}
        }
*/
 /*
        [TestFixture]
        public class The_O_Shape : TetrominoTest
        {
            [SetUp]
            public void CreateOShape()
            {
                _shape = Tetromino.O_SHAPE;
            }

            [Test]
            public void Is_Shaped_Like_O()
            {
                var expected = "" + 
                    ".OO\n" + 
                    ".OO\n" + 
                    "...\n";
                Assert.That(_shape.ToString(), Is.EqualTo(expected));
            }

            //[Test]
            //public void Can_Not_Be_Rotated_Right()
            //{
            //    _shape = _shape.RotateRight();
            //    var expected = "" +
            //        ".OO\n" +
            //        ".OO\n" +
            //        "...\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //}

            //[Test]
            //public void Can_Not_Be_Rotated_Left()
            //{
            //    _shape = _shape.RotateLeft();
            //    var expected = "" +
            //        ".OO\n" +
            //        ".OO\n" +
            //        "...\n";
            //    Assert.That(_shape.ToString(), Is.EqualTo(expected));
            //}
        }
  */
    }

    public class TetrominoTest
    {
        //protected Tetromino _shape;
    }
}