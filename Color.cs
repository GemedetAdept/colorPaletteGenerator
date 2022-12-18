namespace colorvalues {
public class Color {

	public Color() {

	}

	public class HEX {

		private string _value;

		public HEX(string? hexValue) {

			Value = hexValue;
		}

		public string Value {
			get {return _value;}
			set {
				if (value.Contains("#")) {_value = value.Substring(1);}
				else {_value = value;}
			}
		}
	}
	public class HSL {

		private double _hue;
		private double _saturation;
		private double _lightness;

		public HSL(double hueHSL, double saturationHSL, double lightnessHSL) {

			Hue = hueHSL;
			Saturation = saturationHSL;
			Lightness = lightnessHSL;
		}

		public double Hue {
			get {return _hue;}
			set {_hue = value;}
		}
		public double Saturation {
			get {return _saturation;}
			set {_saturation = value;}
		}
		public double Lightness {
			get {return _lightness;}
			set {_lightness = value;}
		}
	}
	public class HSV {

		private double _hue;
		private double _saturation;
		private double _value;

		public HSV(double hueHSV, double saturationHSV, double valueHSV) {

			Hue = hueHSV;
			Saturation = saturationHSV;
			Value = valueHSV;
		}

		public double Hue {
			get {return _hue;}
			set {_hue = value;}
		}
		public double Saturation {
			get {return _saturation;}
			set {_saturation = value;}
		}
		public double Value {
			get {return _value;}
			set {_value = value;}
		}
	}
	public class RGB {

		private double _red;
		private double _green;
		private double _blue;

		public RGB(double redRGB, double greenRGB, double blueRGB) {

			Red = redRGB;
			Green = greenRGB;
			Blue = blueRGB;
		}

		public double Red {
			get {return _red;}
			set {_red = value;}
		}
		public double Green {
			get {return _green;}
			set {_green = value;}
		}
		public double Blue {
			get {return _blue;}
			set {_blue = value;}
		}
	}
	}
}