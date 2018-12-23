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

        public async Task SendLine(int x1, int y1,int x2,int y2)
        {
            await Clients.All.SendAsync("ReceiveLine", x1, y1,x2,y2);
        }
    }
}
