Console.WriteLine("=== Ejercicio 3: interpolación de strings ===");
string producto = "Cuaderno universitario";
int unidades = 3;
decimal precio = 8500m;
decimal total = unidades * precio;
Console.WriteLine($"Producto: {producto} | Unidades: {unidades} | Precio unitario: {precio:C0} | Total: {total:C0}");
