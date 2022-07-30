public class camara_rota: Decorador{

    public camara_rota(ordenbase ordenBase):base(ordenBase){ }
    public virtual string reparar(){
        var reparacion = "La camara rota ha sido arreglada";
          return reparacion;
    }
}