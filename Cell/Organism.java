import java.io.Serializable;

public class Organism implements Serializable {

	private int longevidad;
	private String ecosistema;

	public Organism(int longevidad, String ecosistema) {
		this.longevidad = longevidad;
		this.ecosistema = ecosistema;
	}

	public Organism(){}

	public int getLongevidad(){
		return longevidad;
	}

	public void setLongevidad(int longevidad) {
		this.longevidad = longevidad;
	}

	public String getEcosistema() {
		return ecosistema;
	}

	public void setEcosistema(String ecosistema) {
		this.ecosistema = ecosistema;
	}

	@Override
	public String toString() {
		String s = "";
		s += "Longevidad: "+longevidad+" anios\n";
		s += "Ecosistema: "+ecosistema+"\n";
		return s; 
	}
}