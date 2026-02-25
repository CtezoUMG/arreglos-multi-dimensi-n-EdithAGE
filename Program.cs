using System;

// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrWhiteSpace(linea1))
{
    // Si no hay primera línea, terminamos (útil para autograding)
    return;
}

if (!int.TryParse(linea1, out int n) || n <= 0)
{
    // n inválido: terminamos silenciosamente
    return;
}

// Leemos la segunda línea y dividimos por espacios, eliminando vacíos
string[] entrada = Console.ReadLine()?
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    ?? Array.Empty<string>();

if (entrada.Length < n)
{
    // Evita IndexOutOfRange si vinieron menos números
    return;
}

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// --- INICIO DE LÓGICA DEL ALUMNO ---
// Buscar el valor máximo en el arreglo 'numeros'
int maximo = numeros[0];
for (int i = 1; i < n; i++)
{
    if (numeros[i] > maximo)
    {
        maximo = numeros[i];
    }
}
// --- FIN DE LÓGICA DEL ALUMNO ---

// 2. Salida: Lo que el Autograding comparará
Console.WriteLine(maximo); // Comentario: solo texto como comentario, no después del ;
