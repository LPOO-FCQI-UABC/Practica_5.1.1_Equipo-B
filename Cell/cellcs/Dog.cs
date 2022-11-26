using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Dog : Organism, IAnimal, ISerializable{

	private String raza = "";
	private string color = "";
	private string especie = "";
	private float tamano = 0;
	private float peso = 0;

    public Dog(String raza, string color, string especie, float tamano, float peso){
        this.raza = raza;
        this.color = color;
        this.especie = especie;
        this.tamano = tamano;
        this.peso = peso;
    }
    public Dog(){}
	public String getRaza() {
		return raza;
	}

	public void setRaza(String raza) {
		this.raza = raza;
	}

	public new String toString() {
		String s = "";
		s += "Raza: "+raza+"\n";
		s += "Color: "+color+"\n";
		s += "Especie: "+especie+"\n";
		s += "Tamano: "+tamano+"\n";
		s += "Peso: "+peso+"\n";
		return s + base.toString();
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
    public new void GetObjectData(SerializationInfo info, StreamingContext context){
		info.AddValue("raza", raza);
        info.AddValue("color", color);
        info.AddValue("especie", especie);
        info.AddValue("tamano", tamano);
        info.AddValue("peso", peso);
	}

	public Dog(SerializationInfo info, StreamingContext context){
        try{
            raza = (String)info.GetValue("raza", typeof(String));
            color = (String)info.GetValue("color", typeof(String));
            especie = (String)info.GetValue("especie", typeof(String));
            tamano = (float)info.GetValue("tamano", typeof(float));
            peso = (float)info.GetValue("peso", typeof(float));
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
	}
}