using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using OA.Repo;
using OA.Service;
using OA.WebApi.DTO;

namespace OA.WebApi
{
    public class EmployeeHub : Hub<IEmployeeHub>
    {
        public override async Task OnConnectedAsync()
        {
            //await Clients.All.RefreshEmployeeList($"{Context.ConnectionId} has joined");
        }

        public async Task RefreshEmployeeList (EmployeeDto emp)
        {
            await Clients.All.RefreshEmployeeList(emp);
        }
    }
}
