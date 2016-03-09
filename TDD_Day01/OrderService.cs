using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Day01
{
    public class OrderService
    {
        public IEnumerable<Order> OrderList { get; private set; }

        public OrderService()
        {

        }

        public OrderService(IEnumerable<Order> orderList)
        {
            OrderList = orderList;
        }

        public IEnumerable<int> GetSumList(int num)
        {
            IEnumerable<int> list = null;
            // todo 這邊可以用簡單工廠
            switch(num)
            {
                case 3:
                    list = GetCostSum();
                    break;
                case 4:
                default:
                    list = GetRevenueSum();
                    break;
            }
            return list;
        }

        public IEnumerable<int> GetSumList<T>(IEnumerable<T> objList, Func<T, int> fun, int num) where T : class
        {
            var list = new List<int>();
            int sum = 0;
            for (int i = 0; i < objList.Count(); i++)
            {
                T obj = objList.ElementAt(i);
                sum += fun(obj);
                if ((i + 1) % num == 0 || (i + 1) == objList.Count())
                {
                    list.Add(sum);
                    sum = 0;
                }
            }
            return list;
        }

        // 感覺計算方法很類似, 也許可以抽出來?
        private IEnumerable<int> GetRevenueSum()
        {
            var list = new List<int>();
            int sum = 0;
            for (int i = 0; i < OrderList.Count(); i++)
            {
                var order = OrderList.ElementAt(i);
                sum += order.Revenue;
                if ((i + 1) % 4 == 0 || (i + 1) == OrderList.Count())
                {
                    list.Add(sum);
                    sum = 0;
                }
            }
            return list;
        }

        // 感覺計算方法很類似, 也許可以抽出來?
        private IEnumerable<int> GetCostSum()
        {
            var list = new List<int>();
            int sum = 0;
            for (int i = 0; i < OrderList.Count(); i++)
            {
                var order = OrderList.ElementAt(i);
                sum += order.Cost;
                if ((i + 1) % 3 == 0 || (i + 1) == OrderList.Count())
                {
                    list.Add(sum);
                    sum = 0;
                }
            }
            return list;
        }
    }
}
