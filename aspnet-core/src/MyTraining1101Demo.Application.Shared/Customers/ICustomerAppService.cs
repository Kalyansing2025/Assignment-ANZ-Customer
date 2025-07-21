using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTraining1101Demo.Customers.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyTraining1101Demo.Customers
{
    public interface ICustomerAppService : IApplicationService
    {
        Task<PagedResultDto<CustomerDto>> GetAllCustomer(GetAllCustomersInput input);

        Task<GetCustomerForEditOutput> GetViewCustomer(int id);

        Task CreateOrEditCustomer(CreateOrEditCustomerDto input);

        Task DeleteCustomer(EntityDto input);

        Task<List<UserLookupDto>> GetUnassignedAndAssignedUsers();
    }
}
