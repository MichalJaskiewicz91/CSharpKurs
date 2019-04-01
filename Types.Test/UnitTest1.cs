using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentDiary;


namespace Types.Test
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void CalculateMaxGrate()
        {
            Diary diary = new Diary();
            diary.addRating(9f);
            diary.addRating(8f);
            diary.addRating(7f);
            diary.addRating(5f);
            diary.addRating(3f);
            diary.addRating(11f);

            DiaryStatistics stats = diary.computeStatistics();

            Assert.AreEqual(9f, stats.maxGrade);
        }
        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";

            SetName(diary);

            Assert.AreEqual("Marcin", diary.Name);
        }

        [TestMethod]
        public void PassByValueInt()
        {
            int x1 = 5;

            IncrementNumber(x1);

            Assert.AreEqual(5, x1);
        }

        [TestMethod]
        public void PassByReferenceInt()
        {
            int x1 = 5;

            IncrementNumber(ref x1);

            Assert.AreEqual(15, x1);
        }

        private void IncrementNumber(ref int x1)
        {
            x1 = 15;

        }

        private void IncrementNumber(int x1)
        {
            x1 = 15;
            
        }

        private void SetName(Diary diary)
        {
            diary.Name = "Marcin";
        }
    }
}
