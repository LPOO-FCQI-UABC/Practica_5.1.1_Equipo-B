public class Celula{
	private String name = "";

	public Celula(String name){
		this.name = name;
	}
	public Celula(){}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String toString() {
		return "Name: "+name+"\n";
	}
}