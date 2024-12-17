namespace Stationery;

public abstract class WritingInstrument
{
    public abstract bool CanWrite { get; }

    public virtual void Write(string text)
    {
        if(CanWrite)
            Console.WriteLine(text);
    }
}

public class EternalLaserMarker : WritingInstrument
{
    public override bool CanWrite => true;
}

public class BallPen : WritingInstrument
{
    private bool _isOn;

    public override bool CanWrite => _isOn;

    public void Click() => _isOn = !_isOn;

    public override void Write(string text)
    {
        if (!CanWrite)
            return;

        Console.WriteLine(text);
    }
}

public class Pencil : WritingInstrument, ISharpenable
{
    private int _charactersWritten;
    public bool IsSharp { get; private set; }

    public override bool CanWrite => IsSharp;

    public void Sharpen()
    {
        IsSharp = true;
        _charactersWritten = 0;
    }

    public override void Write(string text)
    {
        if (!CanWrite)
            return;

        Console.WriteLine(text);

        _charactersWritten += text.Length;

        if (_charactersWritten > 30) // You will improve it when you work on your own
        {
            IsSharp = false;
        }
    }
}

public class Crayon : WritingInstrument, ISharpenable
{
    private int _charactersWritten;
    private ConsoleColor _color;

    public Crayon(ConsoleColor color) => _color = color;

    public override bool CanWrite => IsSharp;
    public bool IsSharp { get; private set; }

    public void Sharpen()
    {
        IsSharp = true;
        _charactersWritten = 0;
    }

    public override void Write(string text)
    {
        if (!CanWrite)
            return;

        Console.ForegroundColor = _color;
        Console.WriteLine(text);
        Console.ResetColor();

        _charactersWritten += text.Length;

        if (_charactersWritten > 30) // You will improve it when you work on your own
        {
            IsSharp = false;
        }
    }
}

public class StationeryTester
{
    public static void Write(string text, IEnumerable<WritingInstrument> instruments)
    {
        foreach (var instrument in instruments)
            instrument.Write(text);
    }
}

public interface ISharpenable
{
    bool IsSharp { get; }

    void Sharpen();
}

public static class Sharpener
{
    public static void SharpenAll(IEnumerable<ISharpenable> instruments)
    {
        foreach (var instrument in instruments)
        {
            if (!instrument.IsSharp)
            {
                instrument.Sharpen();
            }
        }
    }
}