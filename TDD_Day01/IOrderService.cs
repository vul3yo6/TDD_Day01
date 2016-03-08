using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Day01
{
    public interface IOrderService
    {
        IEnumerable<int> GetSumList(int num);
    }
}
