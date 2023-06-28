namespace Tonestro.Maui.Amplitude.Android.UsageChecker;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        var instance = Com.Amplitude.Api.Amplitude.Instance;
        
        instance?.Initialize(this, "your_amplitude_token")
            .EnableForegroundTracking(Application)
            .TrackSessionEvents(true);

        instance?.LogEvent("android binding working");

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }
}