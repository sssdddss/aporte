public class Puerto_de_carga: Decorador{

    public Puerto_de_carga(ordenbase ordenBase):base(ordenBase){ }
    public virtual string reparar(){
        var hardware = "El puerto usb de su dispositivo ha sido arreglado";
          return hardware;
    }
}