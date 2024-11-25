using PI_Task_6;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(task6.sum_number(1, 2) == 3);
            Assert.IsTrue(task6.sum_number(2, 1) == 3);
            Assert.IsTrue(task6.sum_number(10, 20) == 30);
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(task6.sum_number(0, 2) == 2);
            Assert.IsTrue(task6.sum_number(2, 0) == 2);
            Assert.IsTrue(task6.sum_number(0, 0) == 0);
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(task6.sum_number(-1, 2) == 1);
            Assert.IsTrue(task6.sum_number(-2, 1) == -1);
            Assert.IsTrue(task6.sum_number(-10, -20) == -30);
            Assert.IsTrue(task6.sum_number(-10, 0) == -10);
        }
    }
}