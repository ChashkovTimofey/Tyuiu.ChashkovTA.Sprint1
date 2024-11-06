namespace Tyuiu.ChashkovTA.Sprint1.Task0.V14.Test
{
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}