using System.Threading.Tasks;
using EasySurvey.SharedKernel;

namespace EasySurvey.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}