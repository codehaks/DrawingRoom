using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DrawingRoom.Hubs
{
    public class DrawingHub : Hub
    {
        public async Task SendCoord(int x, int y)
        {
            await Clients.All.SendAsync("ReceiveCoord", x, y);
        }
    }
}
