Console.WriteLine("=== Ejercicio 2: operadores aritméticos y de asignación ===");
decimal precioCuaderno = 8500m;
int cantidad = 4;
decimal subtotal = precioCuaderno * cantidad;
decimal descuento = subtotal * 0.10m;
decimal total = subtotal - descuento;

total += 2000m; // Se agregan materiales adicionales
Console.WriteLine($"Precio unitario: {precioCuaderno:C0}");
Console.WriteLine($"Cantidad: {cantidad}");
Console.WriteLine($"Subtotal: {subtotal:C0}");
Console.WriteLine($"Descuento (10 %): {descuento:C0}");
Console.WriteLine($"Cargo adicional: {2000m:C0}");
Console.WriteLine($"Total a pagar: {total:C0}");
