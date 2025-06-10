using ToDoList;

Random numeroRandom = new Random();
int cantidadTareas = numeroRandom.Next(1, 11);

//Random numeroRandom2 = new Random();


/* int cantidadTareas = 5;
int CantidadDuracion = 11; */
string? descripcion;

List<Tarea> tareasPendientes = new List<Tarea>();

for (int i = 0; i < cantidadTareas; i++)
{
    Tarea NuevaTarea = new Tarea();
    NuevaTarea.TareaID = i + 1;
    Console.WriteLine($"Ingresa una descripcion de la tarea {NuevaTarea.TareaID}: ");
    descripcion = Console.ReadLine();
    NuevaTarea.Descripcion = descripcion;
    int CantidadDuracion = numeroRandom.Next(10, 100);
    NuevaTarea.Duracion = CantidadDuracion;

    //Aniado tarea
    tareasPendientes.Add(NuevaTarea);
}

foreach (Tarea tareaActual in tareasPendientes)
{
    Console.WriteLine("=================================");
    Console.WriteLine("Id = " + tareaActual.TareaID);
    Console.WriteLine("Descripcion = " + tareaActual.Descripcion);
    Console.WriteLine("Duracion = " + tareaActual.Duracion);

}