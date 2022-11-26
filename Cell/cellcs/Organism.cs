using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Organism : ISerializable{

	private int longevidad = 0;
	private String ecosistema = "";
	public Organism(int longevidad, String ecosistema){
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

	public void GetObjectData(SerializationInfo info, StreamingContext context){
		info.AddValue("longevidad", longevidad);
		info.AddValue("ecosistema", ecosistema);
	}

	public Organism(SerializationInfo info, StreamingContext context){
		longevidad = (int)info.GetValue("longevidad", typeof(int));
		ecosistema = (String)info.GetValue("ecosistema", typeof(String));
	}

	public string toString() {
		string s = "";
		s += "Longevidad: "+longevidad+" anios\n";
		s += "Ecosistema: "+ecosistema+"\n";
		return s;
	}
}