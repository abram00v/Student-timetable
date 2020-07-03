using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Delete_CEnclosures
    {
        /// <summary>
        /// Удаление существующих данных выбранной строки из таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_1()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            bool actualUni = RefData.CUniversity.Insert(grUni);
            Assert.AreEqual(true, actualUni);
            // arrange 
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            bool expected = true;
            //act 
            bool actuali = RefData.CEnclosures.Insert(gr);
            Assert.AreEqual(expected, actuali);
            //assert 
            bool check_gr = RefData.CEnclosures.Delete(gr);
            Assert.AreEqual(true, check_gr);
            bool check_grUni = RefData.CUniversity.Delete(grUni);
            Assert.AreEqual(true, check_grUni);
        }

        /// <summary>
        /// Удаление данных из пустой таблицы
        /// </summary>
        [TestMethod]
        public void Task_395_2()
        {
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(RefData.CEnclosures.Delete(gr2), false);
        }
        /// <summary>
        /// удаление данных при совпадении всех ключевых полей
        /// </summary>
        [TestMethod]
        public void Task_395_21()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            RefData.CUniversity.Insert(grUni);
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            RefData.CEnclosures.Insert(gr);
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(RefData.CEnclosures.Delete(gr2), true);
        }
        /// <summary>
        /// Удаление данных при не совпадающих значениях поля Name
        /// </summary>
        [TestMethod]
        public void Task_395_22()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            RefData.CUniversity.Insert(grUni);
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            RefData.CEnclosures.Insert(gr);
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("М", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(RefData.CEnclosures.Delete(gr2), false);
        }
        /// <summary>
        /// Удаление данных при не совпадающих значениях поля University
        /// </summary>
        [TestMethod]
        public void Task_395_23()
        {
            MUniversity grUni = new MUniversity("4401906286", "ВТБ", "Костьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            RefData.CUniversity.Insert(grUni);
            MEnclosures gr = new MEnclosures("Я", grUni.FullName, "Дзббжинского", "112111", "8");
            RefData.CEnclosures.Insert(gr);
            MUniversity grUni2 = new MUniversity("4401906286", "ВТБ", "Цостьомкой Госуьарственный Унивеьситет", "159005, Костьомская оьласть, р. Коьтрома, пл. Дзержиьского, 27", "158005, Костьомская обьасть, р. Костьома, пл. Дзеьжинского, 47", "Алекьандр", "Наьмов", "Рудолььович", "kru@mail.ru", "84944417960");
            MEnclosures gr2 = new MEnclosures("Я", grUni2.FullName, "Дзббжинского", "112111", "8");
            Assert.AreEqual(RefData.CEnclosures.Delete(gr2), false);
        }
    }
}
