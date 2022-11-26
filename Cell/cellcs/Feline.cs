public class Feline : Organism, IAnimal{

	private String raza = "";
	private string color = "";
	private string especie = "";
	private float tamano = 0;
	private float peso = 0;
    public Feline(String raza, string color, string especie, float tamano, float peso){
        this.raza = raza;
        this.color = color;
        this.especie = especie;
        this.tamano = tamano;
        this.peso = peso;
    }

    public virtual void doAction(){
        Console.WriteLine("Noise");
    }
	public void setRaza(String raza){
        this.raza = raza;
    }

    public String getRaza(){
        return raza;
    }

	public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public string getEspecie()
    {
        return especie;
    }

    public void setEspecie(string especie)
    {
        this.especie = especie;
    }

    public float getTamano()
    {
        return tamano;
    }

    public void setTamano(float tamano)
    {
        this.tamano = tamano;
    }

    public float getPeso()
    {
        return peso;
    }

    public void setPeso(float peso)
    {
        this.peso = peso;
    }
	
	public new string toString() {
		return base.toString();
	}
}