﻿using NUnit.Framework;
using Tetris.Core;

namespace Tetris.Tests
{
    [TestFixture]
    public class FallingBlocksTest
    {
        [TestFixture]
        public class A_New_Board : BoardTest
        {
            private Board _board;

            [SetUp]
            public void InitializeBoard()
            {
                _board = new Board(3, 3);
            }

            [Test]
            public void Is_Empty()
            {
                Assert.That("" +
                            "...\n" +
                            "...\n" +
                            "...\n", Is.EqualTo(_board.ToString()));
            }

            //[Test]
            //public void Has_No_Falling_Blocks()
            //{
            //    Assert.That(_board.HasFalling(), Is.False);
            //}
        }
/*
        [TestFixture]
        public class When_A_Block_Is_Dropped : BoardTest
        {    
            [SetUp]
            public void DropBlock()
            {
                _board.Drop(new Block('X'));
            }

            [Test]
            public void The_Block_Is_Falling()
            {
                Assert.That(_board.HasFalling(), Is.True);
            }

            //[Test]
            //public void It_Starts_From_The_Top_Middle()
            //{
            //    Assert.That("" +
            //        ".X.\n" +
            //        "...\n" +
            //        "...\n", Is.EqualTo(_board.ToString()));
            //}

            //[Test]
            //public void It_Moves_Down_One_Row_Per_Tick()
            //{
            //    _board.Tick();
            //    Assert.That("" +
            //        "...\n" +
            //        ".X.\n" +
            //        "...\n", Is.EqualTo(_board.ToString()));
            //}

            //[Test]
            //public void At_Most_One_Block_May_Be_Falling_At_A_Time()
            //{
            //    try
            //    {
            //        _board.Drop(new Block('Y'));
            //        Assert.Fail();
            //    }
            //    catch (InvalidOperationException e)
            //    {
            //        Assert.That(e.Message, Is.StringContaining("already falling"));
            //    }
            //    Assert.That("" +
            //        ".X.\n" +
            //        "...\n" +
            //        "...\n", Is.EqualTo(_board.ToString()));
            //}
        }
 */
/*
        [TestFixture]
        public class When_A_Block_Reaches_The_Bottom : BoardTest
        {
            [SetUp]
            public void FallToLastRow()
            {
                _board.Drop(new Block('X'));
                _board.Tick();
                _board.Tick();
            }

            [Test]
            public void It_Is_Still_Falling_On_The_Last_Row()
            {
                Assert.That("" +
                    "...\n" + 
                    "...\n" +
                    ".X.\n", Is.EqualTo(_board.ToString()));
                Assert.That(_board.HasFalling(), Is.True, "the should still be able to move the block");
            }

            //[Test]
            //public void It_Stops_When_It_Hits_The_Bottom()
            //{
            //    _board.Tick();
            //    Assert.That("" +
            //        "...\n" +
            //        "...\n" +
            //        ".X.\n", Is.EqualTo(_board.ToString()));
            //    Assert.That(_board.HasFalling, Is.False, "The block should stop moving");
            //}
        }
 */
/*
        [TestFixture]
        public class When_A_Block_Lands_On_Another_Block : BoardTest
        {
            [SetUp]
            public void LandOnAnother()
            {
                _board.Drop(new Block('X'));
                _board.Tick();
                _board.Tick();
                _board.Tick();
                Assert.That("" +
                    "...\n" +
                    "...\n" +
                    ".X.\n", Is.EqualTo(_board.ToString()));
                Assert.That(_board.HasFalling(), Is.False);

                _board.Drop(new Block('Y'));
                _board.Tick();
            }

            [Test]
            public void It_Is_Still_Falling_Right_Above_The_Other_Block()
            {
                Assert.That("" +
                    "...\n" +
                    ".Y.\n" +
                    ".X.\n", Is.EqualTo(_board.ToString()));
                Assert.That(_board.HasFalling(), Is.True, "The player should still be able to avoid landing on the other block");
            }

            //[Test]
            //public void It_Stops_When_It_Hits_The_Other_Block()
            //{
            //    _board.Tick();
            //    Assert.That("" +
            //        "...\n" +
            //        ".Y.\n" +
            //        ".X.\n", Is.EqualTo(_board.ToString()));
            //    Assert.That(_board.HasFalling(), Is.False, "The block should stop moving when it lands on the other block");
            //}
        }
 */
    }

    public class BoardTest
    {
        protected Board _board;

        [SetUp]
        public void InitializeBoard()
        {
            _board = new Board(3, 3);
        }
    }
}