using System.Threading.Tasks;

namespace api2.Interfaces
{
    public interface ICalculateInterestService
    {
        Task<string> CalculateCompoundInterest(decimal initialValue, int months);
    }
}
