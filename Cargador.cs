public class Cargador: Decorador{
    
    public Cargador(ordenbase ordenBase):base(ordenBase){
        
    }
    public override string hardwareadd(){
        var teclado = "Has agregado el cargador adicional";
      return teclado;
    }
}