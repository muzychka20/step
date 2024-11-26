/*
Вы разрабатываете систему управления умным домом. В доме есть разные подсистемы:
Освещение(LightingSystem)
Музыка(MusicSystem)
Климат - контроль(ClimateControlSystem)
Каждая подсистема имеет свои методы управления, но пользователям неудобно работать с ними по отдельности.
Нужно создать фасад, который объединит управление всеми подсистемами.
*/

using System;

public class LightingSystem
{
	public void On() => Console.WriteLine("LightingSystem on.");
	public void SetBrightness(int level) => Console.WriteLine($"LightingSystem set brightness: {level}.");
	public void Off() => Console.WriteLine("LightingSystem off.");
}

public class MusicSystem
{
	public void On() => Console.WriteLine("MusicSystem on.");
	public void SetVolume(int level) => Console.WriteLine($"MusicSystem set volume: {level}.");
	public void SetSong(string song) => Console.WriteLine($"Playing: {song}.");
	public void Off() => Console.WriteLine("MusicSystem off.");
}

public class ClimateControlSystem
{
	public void On() => Console.WriteLine("ClimateControlSystem on.");
	public void SetTemperature(int level) => Console.WriteLine($"ClimateControlSystem set temperature: {level}.");
	public void Off() => Console.WriteLine("ClimateControlSystem off.");
}





public class SmartHouse
{
	private readonly LightingSystem _lightingSystem;
	private readonly MusicSystem _musicSystem;
	private readonly ClimateControlSystem _climateControlSystem;

	public SmartHouse(LightingSystem lightingSystem, MusicSystem musicSystem, ClimateControlSystem climateControlSystem)
	{
		_lightingSystem = lightingSystem;
		_musicSystem = musicSystem;
		_climateControlSystem = climateControlSystem;
	}

	public void StartMusic(string song)
	{
		Console.WriteLine("Prepare for listening music...");
		_lightingSystem.On();
		_lightingSystem.SetBrightness(60);
		_musicSystem.On();
		_musicSystem.SetVolume(55);
		_musicSystem.SetSong(song);
		_climateControlSystem.On();
		_climateControlSystem.SetTemperature(25);
	}

	public void EndMusic()
	{
		Console.WriteLine("End listening...");
		_lightingSystem.Off();
		_musicSystem.Off();
		_climateControlSystem.Off();
	}
}

class Program
{
	static void Main()
	{	
		var lightingSystem = new LightingSystem();
		var musicSystem = new MusicSystem();
		var climateControlSystem = new ClimateControlSystem();

		var smartHouse = new SmartHouse(lightingSystem, musicSystem, climateControlSystem);

		smartHouse.StartMusic("Last Christmas");
		Console.WriteLine();
		smartHouse.EndMusic();
	}
}