public class Eucariota : Celula{
    private Boolean nucleo = true;

    public Eucariota(Boolean nucleo){
        this.nucleo = nucleo;
    }
    public Eucariota(){}

    public Boolean getNucleo() {
        return nucleo;
    }

    public void setNucleo(Boolean nucleo) {
        this.nucleo = nucleo;
    }

    public new String toString(){
        return base.toString() + "Existe nucleo? "+nucleo+"\n";
    }    
}