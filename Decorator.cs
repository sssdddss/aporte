using System;
public class Decorador{
    protected ordenbase orden;

    public Decorador(ordenbase orden)
    {
        this.orden= orden;
    }
    public virtual string hardwareadd(){
      return orden.hardwareadd();
    }
    public virtual string reparar(){
      return orden.reparar();
    }
}