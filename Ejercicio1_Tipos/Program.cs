Console.WriteLine("=== Ejercicio 1: tipos de datos y variables ===");
string aprendiz = "Nombre del aprendiz"; // Cambia este texto por tu nombre
int edad = 20;
decimal promedio = 4.3m;
bool estaMatriculado = true;
char grupo = 'A';
DateTime fechaRegistro = new DateTime(2026, 10, 17);

Console.WriteLine($"Aprendiz: {aprendiz}");
Console.WriteLine($"Edad: {edad} años");
Console.WriteLine($"Promedio: {promedio:F1}");
Console.WriteLine($"Matriculado: {estaMatriculado}");
Console.WriteLine($"Grupo: {grupo}");
Console.WriteLine($"Fecha de registro: {fechaRegistro:dd/MM/yyyy}");
