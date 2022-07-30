public class USB: Decorador{

    public USB(ordenbase ordenBase):base(ordenBase){ }

    public override string hardwareadd(){
        var hardware = "El usb ha sido agregado con exito ";
      return hardware;
    }
}