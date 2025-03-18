using LibraryCalc.Calculator;
using LibraryCalc.Mem;

namespace TestCalculator1
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Test_AddMethod()
        {
            calculator.Add(10);
            Assert.AreEqual(10, calculator.Result);
        }

        [TestMethod] 
        public void Test_SubtractMethod()
        {
            calculator.Add(20);
            calculator.Subtract(5);
            calculator.Subtract(5);
            calculator.Subtract(5);
            calculator.Subtract(8);

            Assert.AreEqual(-3, calculator.Result);
        }

        [TestMethod]
        public void Test_Reset()
        {
            calculator.Add(50);
            calculator.Reset();
            Assert.AreEqual(0, calculator.Result);
        }

        [TestMethod]
        public void Test_MemorySave()
        {
            calculator.Add(25);
            calculator.MemorySave();
            List<MemoryItem> memoryItems = calculator.GetMemoryItems();
            Assert.AreEqual(1, memoryItems.Count);
            Assert.AreEqual(25, memoryItems[0].Value);
        }

        [TestMethod]
        public void Test_RemoveMemoryItem()
        {
            calculator.Add(30);
            calculator.MemorySave();
            List<MemoryItem> memoryItems = calculator.GetMemoryItems();
            calculator.RemoveMemoryItem(memoryItems[0]);

            Assert.AreEqual(0, calculator.GetMemoryItems().Count);
        }
    }

    [TestClass]
    public sealed class MemoryTest
    {
        [TestClass]
        public class MemoryTests
        {
            private Memory memory;

            [TestInitialize]
            public void Setup()
            {
                memory = new Memory();
            }

            [TestMethod]
            public void Test_SaveMethod()
            {
                double value = 25.5;

                memory.Save(value);

                Assert.AreEqual(1, memory.PrintMemoryItems().Count);
                Assert.AreEqual(value, memory.PrintMemoryItems()[0].Value);
            }

            [TestMethod]
            public void Test_PrintMemoryItems()
            {
                memory.Save(10);
                memory.Save(20);
                memory.Save(30);

                List<MemoryItem> items = memory.PrintMemoryItems();

                Assert.AreEqual(3, items.Count);
                Assert.AreEqual(10, items[0].Value);
                Assert.AreEqual(20, items[1].Value);
                Assert.AreEqual(30, items[2].Value);
            }

            [TestMethod]
            public void GetItem_ShouldReturnCorrectItem()
            {
                memory.Save(100);
                memory.Save(200);

                MemoryItem item = memory.GetItem(1);

                Assert.IsNotNull(item);
                Assert.AreEqual(200, item.Value);
            }

            [TestMethod]
            public void GetItem_InvalidIndex_ShouldReturnNull()
            {
                MemoryItem item = memory.GetItem(-1);

                Assert.IsNull(item);
            }

            [TestMethod]
            public void Clear_ShouldRemoveAllItems()
            {
                memory.Save(50);
                memory.Save(60);

                memory.Clear();

                Assert.AreEqual(0, memory.PrintMemoryItems().Count);
            }

            [TestMethod]
            public void ClearItem_ShouldRemoveSpecificItem()
            {
                memory.Save(5);
                memory.Save(10);
                memory.Save(15);
                MemoryItem item = memory.GetItem(1);

                memory.clearItem(item);

                Assert.AreEqual(2, memory.PrintMemoryItems().Count);
                Assert.IsFalse(memory.PrintMemoryItems().Contains(item));
            }
        }
    }
}

