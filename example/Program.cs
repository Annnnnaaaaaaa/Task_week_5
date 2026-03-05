// Base Class: SmartDevice
public class SmartDevice
{
    private string _model;
    public string Model
    {
        get => _model;
        set => _model = string.IsNullOrEmpty(value) ? 
            throw new Exception("Invalid Model") : value;
    }

    public string DeviceId { get; }
    protected bool IsRunning { get; set; }

    public SmartDevice(string model, string id)
    {
        _model = model; // Пряме присвоєння або через властивість
        DeviceId = id;
    }

    public virtual void Activate()
    {
        IsRunning = true;
        Console.WriteLine($"Device {DeviceId} is now active.");
    }
}


// Derived Class 1: ClimateControl
public class ClimateControl : SmartDevice
{
    public ClimateControl(string model, string id) : base(model, id) { }

    public override void Activate()
    {
        base.Activate();
        Console.WriteLine("Adjusting temperature to 22C.");
    }
}


// Derived Class 2: SecurityCamera
public class SecurityCamera : SmartDevice
{
    public SecurityCamera(string model, string id) : base(model, id) { }

    public override void Activate()
    {
        IsRunning = true;
        Console.WriteLine("Streaming encrypted video feed.");
    }
}


// System Management
public class HomeHub
{
    private List<SmartDevice> _devices = new List<SmartDevice>();

    public void Register(SmartDevice d) => _devices.Add(d);

    public void Synchronize()
    {
        foreach (var device in _devices)
        {
            // Dynamic Polymorphism: CLR resolves the method at runtime
            device.Activate();
        }
    }
}