
namespace BackgroundAppDemo;


//IHostedSevice Tells D code to run in the background
public class BackgroundRefresh : IHostedService, IDisposable
{
    //Initializes a new instance of the BackgroundRefresh
    private Timer? _timer;
    private readonly Sampledata _data;

    public BackgroundRefresh(Sampledata data)
    {
        _data = data;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(AddToCache, null, TimeSpan.Zero, TimeSpan.FromSeconds(value: 5));

        return Task.CompletedTask;
    }

    private void AddToCache(object? state)
    {
        _data.Data.Add(item: $"The new data was added at {DateTime.Now.ToShortTimeString()}");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

}
