
using Microsoft.AspNetCore.SignalR;

namespace LocaliztionMultiTableSmartWay.Extention
{
    public class ProgressHub : Hub
    {
        public async Task UpdateProgress(int progress, int total)
        {
            await Clients.All.SendAsync("UpdateProgress", progress, total);
        }

        public async Task OperationCompleted()
        {
            await Clients.All.SendAsync("OperationCompleted");
        }
    }
}
