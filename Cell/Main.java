import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Main {
    public static void main(String[] args) {
        Dog dog = new Dog();
        Procariota proc = new Procariota();
        Eucariota euca = new Eucariota();
        Feline cat = new Cat(); //<- Polimorfismo
        dog.setEcosistema("Terrestre");
        dog.setEspecie("Canino");
        dog.setRaza("Beagle");
        dog.setColor("Cafe y blanco");
        dog.setLongevidad(15);
        dog.setTamano(50);
        dog.setPeso(45);
        proc.setName("Procariota");
        euca.setName("Eucariota");
        cat.setEcosistema("Terrestre");
        cat.setEspecie("Felino");
        cat.setRaza("Persa");
        cat.setColor("Café");
        cat.setLongevidad(14);
        cat.setTamano(50);
        cat.setPeso(25);
        System.out.println(dog.toString()+proc.toString()+euca.toString());
        System.out.println(cat.toString());
        cat.doAction();

        try{
            ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("data.log"));
            oos.writeObject(dog);
            oos.writeObject(proc);
            oos.writeObject(euca);
            oos.writeObject(cat);
            oos.close();
        } catch (Exception e){
            e.printStackTrace();
        }

        try{
            ObjectInputStream ois = new ObjectInputStream(new FileInputStream("data.log"));
            Dog dog2 = (Dog) ois.readObject();
            Procariota proc2 = (Procariota) ois.readObject();
            Eucariota euca2 = (Eucariota) ois.readObject();
            Feline cat2 = (Feline) ois.readObject();
            System.out.println(dog2.toString()+proc2.toString()+euca2.toString());
            System.out.println(cat2.toString());
            cat2.doAction();
            ois.close();
        } catch (Exception e){
            e.printStackTrace();
        }
    }
}
