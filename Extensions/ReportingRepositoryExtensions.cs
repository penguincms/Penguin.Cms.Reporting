using Penguin.Persistence.Abstractions.Interfaces;
using System.Linq;

namespace Penguin.Cms.Reporting.Extensions
{
    public static class ReportingRepositoryExtensions
    {
        public static ParameterInfo GetByProcedureAndName(this IRepository<ParameterInfo> repository, string ProcedureName, string ParameterName)
        {
            return repository.Where(p => p.ProcedureName == ProcedureName && p.ParameterName == ParameterName).FirstOrDefault();
        }
    }
}