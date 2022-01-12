namespace Seccion6
{
    class Program
    {
        static void Main()
        {
            int i, j,nroSalones,nroAlumnos;
            double promedio, sumaAlumnos = 0, sumaCalif = 0, califMin = 10, califMax = 0;
            string mejorAlumno = "", peorAlumno = "", s;
            
            // Pedimos longitud del array principal, declaramos e instanciamos
            Console.Write("Número de salones: ");
            nroSalones = Convert.ToInt32(Console.ReadLine());
            double[][] calif = new double[nroSalones][];

            // Pedimos longitud de arrays internos, declaramos e instanciamos
            for (i = 0; i < nroSalones; i++)
            {
                Console.Write($"Nro. de alumnos Salón {i+1}: ");
                nroAlumnos = Convert.ToInt32(Console.ReadLine());
                calif[i] = new double[nroAlumnos];
                sumaAlumnos += nroAlumnos; // Tenemos la cantidad de alumnos de todos los salones

                for(j = 0; j < calif[i].Length; j++)
                {
                    Console.Write($"Nota Alumno {j + 1}: ");
                    calif[i][j] = Convert.ToDouble(Console.ReadLine());
                    sumaCalif += calif[i][j]; // Tenemos la suma de calificaciones de todos los salones

                    if (calif[i][j] > califMax) // Obtenemos la mejor nota
                    {
                        califMax = calif[i][j];
                        mejorAlumno = $"Alumno Clase {i+1} Posición {j+1}";
                    }
                    else if(calif[i][j] == califMax) mejorAlumno += $"\nAlumno Clase {i + 1} Posición {j + 1}";
                    
                    if (calif[i][j] < califMin) // Obtenemos la peor nota
                    {
                        califMin = calif[i][j];
                        peorAlumno = $"Alumno Clase {i+1} Posición {j+1}";
                    }
                    else if (calif[i][j] == califMin) peorAlumno += $"\nAlumno Clase {i + 1} Posición {j + 1}";                   
                }
            }
            promedio = sumaCalif / sumaAlumnos;  // Calculamos promedio de calificaciones

            Console.Clear();
            for(i = 0; i < nroSalones; i++)
            {
                //Console.Write($"Salón {i+1} --> ");
                s = $"Salón {i + 1} --> ";
                for (j = 0; j < calif[i].Length; j++)
                {
                    //Console.Write(calif[i][j] + " ");
                    s += $"{calif[i][j]}" + " ";
                }
                //Console.Write("\n");
                Console.Write(s + "\n");
            }
            Console.Write("\n");
            Console.WriteLine($"Número de alumnos: {sumaAlumnos}");
            Console.WriteLine($"Promedio de notas: {promedio}");
            Console.WriteLine($"Mejor nota {califMax}, \n{mejorAlumno}");
            Console.WriteLine($"Peor nota {califMin}, \n{peorAlumno}");
        }
    }
}