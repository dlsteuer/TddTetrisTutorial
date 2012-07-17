using NUnit.Framework;

namespace Tetris.Tests
{
    public class RotatingPiecesOfBlocksTests
    {
/*
        [TestFixture]
        public class A_Piece_Of_3X3_Blocks : PieceTest
        {
            [SetUp]
            public void CreatePiece()
            {
                _piece = new Piece("" +
                    ".X.\n" +
                    ".X.\n" +
                    "...\n");
            }

            [Test]
            public void Consists_Of_Many_Blocks()
            {
                Assert.That("" +
                    ".X.\n" +
                    ".X.\n" +
                    "...\n", Is.EqualTo(_piece.ToString()));
            }

            //[Test]
            //public void Can_Be_Rotated_Right()
            //{
            //    _piece = _piece.RotateRight();
            //    Assert.That("" +
            //        "...\n" +
            //        ".XX\n" +
            //        "...\n", Is.EqualTo(_piece.ToString()));
            //}

            //[Test]
            //public void Can_Be_Rotated_Left()
            //{
            //    _piece = _piece.RotateLeft();
            //    Assert.That("" +
            //        "...\n" +
            //        "XX.\n" +
            //        "...\n", Is.EqualTo(_piece.ToString()));
            //}
        }

        [TestFixture]
        public class A_Piece_Of_5X5_Blocks : PieceTest
        {
            [SetUp]
            public void CreatePiece()
            {
                _piece = new Piece("" +
                    "..XXX\n" +
                    "..XX.\n" +
                    "..X..\n" +
                    ".....\n" +
                    ".....\n");
            }

            [Test]
            public void Consists_Of_Many_Blocks()
            {
                Assert.That("" +
                    "..XXX\n" +
                    "..XX.\n" +
                    "..X..\n" +
                    ".....\n" +
                    ".....\n", Is.EqualTo(_piece.ToString()));
            }

            //[Test]
            //public void Can_Be_Rotated_Right()
            //{
            //    _piece = _piece.RotateRight();
            //    Assert.That("" +
            //        ".....\n" +
            //        ".....\n" +
            //        "..XXX\n" +
            //        "...XX\n" +
            //        "....X\n", Is.EqualTo(_piece.ToString()));
            //}

            //[Test]
            //public void Can_Be_Rotated_Left()
            //{
            //    _piece = _piece.RotateLeft();
            //    Assert.That("" +
            //        "X....\n" +
            //        "XX...\n" +
            //        "XXX..\n" +
            //        ".....\n" +
            //        ".....\n", Is.EqualTo(_piece.ToString()));
            //}
        }
    }
*/
    public class PieceTest
    {
        protected Piece _piece;
    }
}