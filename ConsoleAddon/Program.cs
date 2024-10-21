using SharpGMad;
using System.IO;

// RealtimeAddon realtimeAddon = new RealtimeAddon()

string addon = @"D:\Steam\steamapps\workshop\content\4000\104619813\104619813.gma";

RealtimeAddon realtimeAddon = RealtimeAddon.Load(addon, !FileExtensions.CanWrite(addon));
foreach (ContentFile item in realtimeAddon.OpenAddon.Files)
{
    Console.WriteLine(item);
}
Console.ReadLine();