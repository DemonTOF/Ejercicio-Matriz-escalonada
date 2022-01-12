namespace Seccion6
{
    class Program
    {
        static void Main()
        {
            int i, j, nroSalones, nroAlumnos;
            string s;
            
            // Pedimos longitud del array principal, declaramos e instanciamos
            Console.Write("Número de salones: ");
            nroSalones = Convert.ToInt32(Console.ReadLine());
           
            int[] sumaAlumnos = new int[nroSalones];     // Array 1D para guardar la suma de alumnos por salón
            double[] sumaCalif = new double[nroSalones]; // Array 1D para guardar la suma de calif. por salón
            double[] califMax = new double[nroSalones];
            double[] califMin = new double[nroSalones];
            string[] mejorAlumno = new string[nroSalones];
            string[] peorAlumno = new string[nroSalones];
            for (i = 0; i < nroSalones; i++)
            {
                sumaAlumnos[i] = 0;                      // Enceramos cada array
                sumaCalif[i] = 0;
                califMax[i] = 0;
                califMin[i] = 10;
                mejorAlumno[i] = "";
                peorAlumno[i] = "";
            }

            double[][] calif = new double[nroSalones][]; // Array escalonada, pedimos longitud de arrays       
            for (i = 0; i < nroSalones; i++)             // internos, declaramos e instanciamos
            {
                Console.Write($"Nro. de alumnos Salón {i+1}: ");
                nroAlumnos = Convert.ToInt32(Console.ReadLine());
                calif[i] = new double[nroAlumnos];
                sumaAlumnos[i] += nroAlumnos; // Tenemos la cantidad de alumnos de todos los salones

                for(j = 0; j < calif[i].Length; j++)
                {
                    Console.Write($"Nota Alumno {j + 1}: ");
                    calif[i][j] = Convert.ToDouble(Console.ReadLine());
                    sumaCalif[i] += calif[i][j]; // Tenemos la suma de calificaciones de todos los salones

                    // Obtenemos la mejor nota
                    if (calif[i][j] > califMax[i])
                    {
                        califMax[i] = calif[i][j];
                        mejorAlumno[i] = $"Alumno en posición {j+1}";
                    }
                    else if(calif[i][j] == califMax[i])
                        mejorAlumno[i] += $"\nAlumno en posición {j + 1}";

                    // Obtenemos la peor nota
                    if (calif[i][j] < califMin[i]) 
                    {
                        califMin[i] = calif[i][j];
                        peorAlumno[i] = $"Alumno en posición {j+1}";
                    }
                    else if (calif[i][j] == califMin[i])
                        peorAlumno[i] += $"\nAlumno en posición {j + 1}";
                }
            }

            // Mostramos matriz resultante en consola
            Console.Clear();
            for (i = 0; i < nroSalones; i++)
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

            // Calculamos los promedios por salón, y mostramos todos los datos en consola
            Console.Write("\n");
            double[] promedio = new double[nroSalones];
            for (i = 0; i < nroSalones; i++)
            {
                promedio[i] = sumaCalif[i] / sumaAlumnos[i];
                Console.WriteLine($"\nSalón {i + 1}:");
                Console.WriteLine($"Promedio: {promedio[i]}");
                Console.WriteLine($"Mejor nota {califMax[i]}\n{mejorAlumno[i]}");
                Console.WriteLine($"Peor nota {califMin[i]}\n{peorAlumno[i]}");
            }
        }
    }
}