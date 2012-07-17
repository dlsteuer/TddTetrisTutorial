using NUnit.Framework;
using Tetris.Core;

namespace Tetris.Tests
{
    public class FallingPiecesTests
    {
/*
        [TestFixture]
        public class When_A_Piece_Is_Dropped : FallingPieceTest
        {

            [SetUp]
            public void DropPiece()
            {
                _board.Drop(Tetromino.T_SHAPE);
            }

            [Test]
            public void It_Starts_From_Top_Middle()
            {
                var expected = "" +
                    "....T...\n" +
                    "...TTT..\n" +
                    "........\n" +
                    "........\n" +
                    "........\n" +
                    "........\n";
                Assert.That(_board.ToString(), Is.EqualTo(expected));
            }
        }
*/
/*
        [TestFixture]
        public class When_A_Piece_Reaches_The_Bottom
        {
            [SetUp]
            public void FallToLastRow()
            {
                _board.Drop(Tetromino.T_SHAPE);
                _board.Tick();
                _board.Tick();
                _board.Tick();
                _board.Tick();
            }

            [Test]
            public void It_Is_Still_Falling_On_The_Last_Row()
            {
                var expected = "" +
                    "........\n" +
                    "........\n" +
                    "........\n" +
                    "........\n" +
                    "....T...\n" +
                    "...TTT..\n";
                Assert.That(_board.ToString(), Is.EqualTo(expected));
                Assert.That(_board.HasFalling(), Is.True);
            }

            //[Test]
            //public void It_Stops_When_It_Hits_The_Bottom()
            //{
            //    _board.Tick();
            //    var expected = "" +
            //        "........\n" +
            //        "........\n" +
            //        "........\n" +
            //        "........\n" +
            //        "....T...\n" +
            //        "...TTT..\n";
            //    Assert.That(_board.ToString(), Is.EqualTo(expected));
            //    Assert.That(_board.HasFalling(), Is.False);
            //}
        }
*/
/*
        [TestFixture]
        public class When_A_Piece_Lands_On_Another_Piece : FallingPieceTest
        {
            [SetUp]
            public void LandOnAnother()
            {
                _board.Drop(Tetromino.T_SHAPE);
                _board.Tick();
                _board.Tick();
                _board.Tick();
                _board.Tick();
                _board.Tick();
                var expected = "" +
                    "........\n" +
                    "........\n" +
                    "........\n" +
                    "........\n" +
                    "....T...\n" +
                    "...TTT..\n";
                Assert.That(_board.ToString(), Is.EqualTo(expected));
                Assert.That(_board.HasFalling(), Is.False);

                _board.Drop(Tetromino.T_SHAPE);
                _board.Tick();
                _board.Tick();
            }

            [Test]
            public void It_Is_Still_Falling_Right_Above_The_Other_Piece()
            {
                var expected = "" +
                    "........\n" +
                    "........\n" +
                    "....T...\n" +
                    "...TTT..\n" +
                    "....T...\n" +
                    "...TTT..\n";
                Assert.That(_board.ToString(), Is.EqualTo(expected));
                Assert.That(_board.HasFalling(), Is.True);
            }

            //[Test]
            //public void It_Stops_When_It_Hits_The_Other_Piece()
            //{
            //    _board.Tick();
            //    var expected = "" +
            //        "........\n" +
            //        "........\n" +
            //        "....T...\n" +
            //        "...TTT..\n" +
            //        "....T...\n" +
            //        "...TTT..\n";
            //    Assert.That(_board.ToString(), Is.EqualTo(expected));
            //    Assert.That(_board.HasFalling(), Is.False);
            //}
        }
 */
    }

    public class FallingPieceTest
    {
        protected Board _board = new Board(6, 8);
    }
}