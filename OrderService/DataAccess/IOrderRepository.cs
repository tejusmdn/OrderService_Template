using CafeCommon;

namespace OrderService.DataAccess;

public interface IOrderRepository
{
    Order Get(string id);
}