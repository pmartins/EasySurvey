using System.Threading.Tasks;
using EasySurvey.SharedKernel.Interfaces;
using EasySurvey.SharedKernel;

namespace EasySurvey.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
