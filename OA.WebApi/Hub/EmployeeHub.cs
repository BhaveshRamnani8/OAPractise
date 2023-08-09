using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using OA.Repo;
using OA.Service;
using OA.WebApi.DTO;

namespace OA.WebApi
{
    public class EmployeeHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            //await Clients.All.RefreshEmployeeList($"{Context.ConnectionId} has joined");
        }

        public async Task SendMessage (object empData)
        {
            await Clients.All.SendAsync("ReceiveMessage", empData);
        }
    }
}
