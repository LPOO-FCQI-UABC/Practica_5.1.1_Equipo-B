public class Dog extends Organism implements Animal{
	private String raza;
	private String color;
	private String especie;
	private int tamano;
	private int peso;

	public Dog(String raza, String color, String especie, int tamano, int peso) {
		this.raza = raza;
		this.color = color;
		this.especie = especie;
		this.tamano = tamano;
		this.peso = peso;
	}

	public Dog(){}

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
		System.out.println("Woof!");
	}


	public String toString() {
		String s = "";
		s += "Color: "+color+"\n";
		s += "Especie: "+especie+"\n";
		s += "Tamano: "+tamano+"\n";
		s += "Peso: "+peso+"\n";
		s += "Raza: "+raza+"\n";
		return s + super.toString();
	}
}