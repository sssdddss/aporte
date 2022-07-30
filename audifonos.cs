public class audifonos: Decorador{
    
    public audifonos(ordenbase ordenBase):base(ordenBase){
        
    }
    public override string hardwareadd(){
        var hardware = "Los audifonos han sido agregados con exito";
        return hardware;
    }
}