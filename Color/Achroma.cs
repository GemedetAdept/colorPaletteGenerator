using userinput;
namespace colorvalues {
public class Achroma {

	// Achroma, it's just a *representation* of a color.
	public Achroma(string inputType, string inputValue) {

		InputType = inputType;
		InputValue = inputValue;

		bool loadStatus = LoadInput();
		if (loadStatus == false) {Console.WriteLine("Achroma| Failed to load inputs.");}


	}

	public string InputType {get;}
	public string InputValue {get;}

	private Color.CMYK _cmyk;
	private Color.HEX _hex;
	private Color.HSL _hsl;
	private Color.HSV _hsv;
	private Color.RGB _rgb;

	public Color.CMYK CMYK {
		get {return _cmyk;}
		set {_cmyk = value;}
	}
	public Color.HEX HEX {
		get {return _hex;}
		set {_hex = value;}
	}
	public Color.HSL HSL {
		get {return _hsl;}
		set {_hsl = value;}
	}
	public Color.HSV HSV {
		get {return _hsv;}
		set {_hsv = value;}
	}
	public Color.RGB RGB {
		get {return _rgb;}
		set {_rgb = value;}
	}

	internal bool LoadInput() {
		switch(InputType) {
			case "CMYK":
				CMYK = UserInput.InputCMYK(InputValue);
				return true;
				break;
			case "HEX":
				HEX = UserInput.InputHEX(InputValue);
				return true;
				break;
			case "HSL":
				HSL = UserInput.InputHSL(InputValue);
				return true;
				break;
			case "HSV":
				HSV = UserInput.InputHSV(InputValue);
				return true;
				break;
			case "RGB":
				RGB = UserInput.InputRGB(InputValue);
				return true;
				break;
			default:
				return false;
				break;
		}
	}
}
}
