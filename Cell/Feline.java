public class Feline extends Organism implements Animal{
    private String raza;
	private String color;
	private String especie;
	private int tamano;
	private int peso;

	public Feline(String raza, String color, String especie, int tamano, int peso) {
		this.raza = raza;
		this.color = color;
		this.especie = especie;
		this.tamano = tamano;
		this.peso = peso;
	}

	public Feline(){}

	public String getEspecie() {
		return especie;
	}

	public void setEspecie(String especie) {
		this.especie = especie;
	}

	public int getTamano() {
		return tamano;
	}

	public void setTamano(int tamano) {
		this.tamano = tamano;
	}

	public int getPeso() {
		return peso;
	}

	public void setPeso(int peso) {
		this.peso = peso;
	}

	public String getRaza() {
		return raza;
	}

	public void setRaza(String raza) {
		this.raza = raza;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public void doAction(){
		System.out.println("Noise");
	}

	public String toString() {
		String s = "";
		return s + super.toString();
	}
}