namespace ToDoList
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string? Descripcion { get; set; }
        public int Duracion { get; set; } // Validar que esté entre 10 y 100
                                          // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
        //Metodo para validar la duracion entre 10 y 100
        public void validacion(int duracion){
            if (duracion > 10 && duracion < 100)
            {
                Console.WriteLine("La duracion es correcta");
            }else{
                Console.WriteLine("La duracion no puede ser menos de 10 o/y mas de 100");
            }
        }
    }

}