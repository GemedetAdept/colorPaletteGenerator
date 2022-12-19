﻿using userinput;
using menudriver;
using colorvalues;
using colorharmony;
using convertcolor;

var paletteHEX = new List<Color.HEX>();
var paletteHSL = new List<Color.HSL>();
var paletteHSV = new List<Color.HSV>();
var paletteRGB = new List<Color.RGB>();

// Main Menu
MenuDriver mainMenu = new MenuDriver();
	string[] mainMenuOptions = new string[] {

		"Generate New Color Palette",
		"Learn About Color Harmonies",
		"Quit Program",
	};
	mainMenu.AddOptions(mainMenuOptions);

	void MainMenu() {
		while (mainMenu.menuLoop){

			Console.Clear();
			mainMenu.DisplayMenu();
			mainMenu.SetMenuCursor();

			switch(mainMenu.selectedItem) {

				case 0:
					generationDriver();
					break;
				case 1:
					
					break;
				case 2: 
					Console.Clear();
					Environment.Exit(0);
					break;
				default:
					break;
			}
		}
	}

// Color Input Menu
MenuDriver inputMenu = new MenuDriver();
	string[] inputMenuOptions = new string[] {

		"Hexadecimal",
		"HSL",
		"HSV",
		"RGB",
		"Quit Program",
	};
	inputMenu.AddOptions(inputMenuOptions);

	string userColorInput = "Gemedet";
	var normalizedInput = new Color.HSV(1.0, 0.0, 0.0);
	Color.HSV InputMenu() {
		while (inputMenu.menuLoop){

			Console.Clear();
			inputMenu.DisplayMenu();
			inputMenu.SetMenuCursor();

			switch(inputMenu.selectedItem) {

				case 0:
					userColorInput = UserInput.Query("Enter a value between #000000 - #FFFFFF");
					var inputHEX = UserInput.InputHEX(userColorInput);
					normalizedInput = ConvertColor.HEXtoHSV(inputHEX);
					return normalizedInput;
					break;
				case 1:
					userColorInput = UserInput.Query("Enter a value between (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
					var inputHSL = UserInput.InputHSL(userColorInput);
					normalizedInput = ConvertColor.HSLtoHSV(inputHSL);
					return normalizedInput;
					break;
				case 2:
					userColorInput = UserInput.Query("Enter a value between (0.0, 0.0, 0.0) - (360.0, 100.0, 100.0)");
					var inputHSV = UserInput.InputHSV(userColorInput);
					return inputHSV;
					break;
				case 3:
					userColorInput = UserInput.Query("Enter a value between (0, 0, 0) - (255, 255, 255)");
					var inputRGB = UserInput.InputRGB(userColorInput);
					normalizedInput = ConvertColor.RGBtoHSV(inputRGB);
					return normalizedInput;
					break;
				case 4: 
					Console.Clear();
					Environment.Exit(0);
					return null;
					break;
				default:
					break;
					return null;
			}
		}
		return null;
	}

// Color Harmony Menu
MenuDriver harmonyMenu = new MenuDriver();
	string[] harmonyMenuOptions = new string[] {

		"Complementary",
		"Split Complementary",
		"Triadic",
		"Tetradic",
		"Square",
		"Analogous",
		"Monochromatic",
	};
	harmonyMenu.AddOptions(harmonyMenuOptions);

	List<Color.HSV> outputPaletteHSV = new List<Color.HSV>();
	List<Color.HSV> HarmonyMenu(Color.HSV inputHSV) {
		while (harmonyMenu.menuLoop){

			Console.Clear();
			harmonyMenu.DisplayMenu();
			harmonyMenu.SetMenuCursor();

			switch(harmonyMenu.selectedItem) {

				case 0:
					outputPaletteHSV = ColorHarmony.Complementary(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 1: 
					outputPaletteHSV = ColorHarmony.SplitComplementary(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 2: 
					outputPaletteHSV = ColorHarmony.Triadic(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 3: 
					outputPaletteHSV = ColorHarmony.Tetradic(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 4: 
					outputPaletteHSV = ColorHarmony.Square(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 5: 
					outputPaletteHSV = ColorHarmony.Analogous(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				case 6: 
					outputPaletteHSV = ColorHarmony.Monochromatic(inputHSV).ToList();
					return outputPaletteHSV;
					break;
				default:
					break;
					return null;
			}
		}
		return null;
	}

void generationDriver() {

	paletteHEX.Clear();
	paletteHSL.Clear();
	paletteHSV.Clear();
	paletteRGB.Clear();

	Color.HSV normalizedInputHSV = InputMenu();
	Console.WriteLine($"{normalizedInputHSV.Hue}, {normalizedInputHSV.Saturation}, {normalizedInputHSV.Value}");
	
	paletteHSV = HarmonyMenu(normalizedInputHSV);
	foreach (Color.HSV color in paletteHSV) {
		Console.WriteLine($"{color.Hue}, {color.Saturation}, {color.Value}");
	}
	Console.ReadKey();
}

MainMenu();