namespace menudriver {
public class Cursor {
	
	private string _pip = ">";
	private int _paddingLeft = 0;
	private int _paddingRight = 1;

	public Cursor() {
	}

	public string Pip {
		get {_pip;}
		set {_pip = value;}
	}
	public int PaddingLeft {
		get {_paddingLeft;}
		set {_paddingLeft = value;}
	}
	public int PaddingRight {
		get {_paddingRight;}
		set {_paddingRight = value;}
	}
}
}
