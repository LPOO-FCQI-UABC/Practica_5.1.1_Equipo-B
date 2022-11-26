public class Cat : Feline, IAnimal{

	private String raza = "";
	private string color = "";
	private string especie = "";
	private float tamano = 0;
	private float peso = 0;


    public Cat(String raza, string color, string especie, float tamano, float peso) : base(raza, color, especie, tamano, peso){
        this.raza = raza;
        this.color = color;
        this.especie = especie;
        this.tamano = tamano;
        this.peso = peso;
    }

    public override void doAction(){
        Console.WriteLine("Meow!");
    }

    public new void setRaza(String raza){
        this.raza = raza;
    }

    public new String getRaza(){
        return raza;
    }

	public new string getColor()
    {
        return color;
    }

    public new void setColor(string color)
    {
        this.color = color;
    }

    public new string getEspecie()
    {
        return especie;
    }

    public new void setEspecie(string especie)
    {
        this.especie = especie;
    }

    public new float getTamano()
    {
        return tamano;
    }

    public new void setTamano(float tamano)
    {
        this.tamano = tamano;
    }

    public new float getPeso()
    {
        return peso;
    }

    public new void setPeso(float peso)
    {
        this.peso = peso;
    }
	
	public new string toString() {
		string s = "";
		s += "Raza: "+raza+"\n";
		s += "Color: "+color+"\n";
		s += "Especie: "+especie+"\n";
		s += "Tamano: "+tamano+"\n";
		s += "Peso: "+peso+"\n";
		return s + base.toString();
	}
}