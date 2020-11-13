using System.Threading.Tasks;
using EasySurvey.SharedKernel;

namespace EasySurvey.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}