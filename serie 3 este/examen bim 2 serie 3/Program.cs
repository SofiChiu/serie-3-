using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_bim_2_serie_3
{
    class Program
    {
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab01
    {
        class Program
        {
            public static string usuario { get; set; }
            public static string pass = "", rol = "";
            public static string[,] usuarios;
            public static string[,] productos;
            public static string[,] facturas;
            public static string[,] DetalleFact;
            static void Main()
            {
                int opcion = 0;
                string R = "N";



                usuarios = new string[100, 6];
                productos = new string[100, 4];
                facturas = new string[100, 6];
                DetalleFact = new string[100, 6];
                Login();
                while (R == "N")
                {
                    opcion = (DevolverSeleccion(rol));
                    if (opcion == 1 && rol == "administrador")
                    {
                        CrearUsuario();
                    }
                    else if (opcion == 2 && rol == "administrador")
                    {
                        MostrarUsuarios();
                    }
                    else if (opcion == 3 && rol == "administrador")
                    {
                        CargarDatos(2);
                        MostrarProductos();
                    }
                    else if (opcion == 4 && rol == "administrador")
                    {
                        CargarDatos(3);
                        Mostrarfacturacion();
                    }
                    else if (opcion == 1 && rol == "trabajador")
                    {
                        CargarDatos(2);
                        CargarInventario();
                    }
                    else if (opcion == 2 && rol == "trabajador")
                    {
                        CargarDatos(3);
                        CargarFactura();
                    }



                    Console.Write("¿Desea cerrar sesión?  (S/N): ");
                    R = Console.ReadLine();
                }
                Console.Clear();
                Main();
                Console.ReadKey();
            }
            public static void CrearUsuario()
            {
                string opcion = "S";
                while (opcion == "S")
                {
                    string nombre, apellido, telefono, usuario, password;
                    int rolusuario, num, x;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****CREAR NUEVO USUARIO****");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ingrese el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese el apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Ingrese el telefono: ");
                    telefono = Console.ReadLine();
                    Console.Write("Ingrese el nombre de usuario: ");
                    usuario = Console.ReadLine();
                    Console.Write("Ingrese la contraseña: ");
                    password = Console.ReadLine();
                    Console.Write("Ingrese el tipo de Rol (1)Administrador o (2)Trabajador(Ingresar No): ");
                    rolusuario = int.Parse(Console.ReadLine());

                    if (usuario == "" || usuario == null)
                    {
                        Console.Write("El nombre de usuario es obligatorio");
                        Console.ReadKey();
                        CrearUsuario();
                    }
                    if (rolusuario != 1 && rolusuario != 2)
                    {
                        Console.Write("El rol seleccionado no existe");
                        Console.ReadKey();
                        CrearUsuario();
                    }

                    x = 0;
                    num = 0;
                    while (x < (usuarios.Length / 6) - 1)
                    {

                        if ((usuarios[x, 3]) != null)
                        {
                            num = num + 1;
                        }
                        x = x + 1;
                    }
                    usuarios[num, 0] = nombre;
                    usuarios[num, 1] = apellido;
                    usuarios[num, 2] = telefono;
                    usuarios[num, 3] = usuario;
                    usuarios[num, 4] = password;
                    if (rolusuario == 1)
                    

            }
            

                   
            public static void MostrarUsuarios()
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------  USUARIOS  ----------------------------------------------");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                Console.WriteLine("NOMBRE        APELLIDO             TELEFONO           USER             PASSWORD            ROL");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                int x = 0;
                while (x < (usuarios.Length / 6) - 1)
                {

                    if ((usuarios[x, 3]) != null)
                    {
                        Console.SetCursorPosition(1, x + 4);
                        Console.Write(usuarios[x, 0]);
                        Console.SetCursorPosition(15, x + 4);
                        Console.Write(usuarios[x, 1]);
                        Console.SetCursorPosition(35, x + 4);
                        Console.Write(usuarios[x, 2]);
                        Console.SetCursorPosition(53, x + 4);
                        Console.Write(usuarios[x, 3]);
                        Console.SetCursorPosition(73, x + 4);
                        Console.Write(usuarios[x, 4]);
                        Console.SetCursorPosition(93, x + 4);
                        Console.Write(usuarios[x, 5]);
                    }

                    x = x + 1;

                }
                Console.WriteLine();
            }
           

                }
                Console.WriteLine();
            }
            public static string ValidarUsuario(string pass, string passingresado)
            {
                string dato = "";
                if (usuario == "admin" && passingresado == "password")
                {
                    rol = "administrador";
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    dato = "Bienvenid(@) " + usuario;
                    Console.SetCursorPosition(58, 0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Usuario: " + usuario);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(1, 1);
                }
                
                }
                else if (pass == passingresado)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    dato = "Bienvenid(@) " + usuario;
                    Console.SetCursorPosition(58, 0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Usuario: " + usuario);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(1, 1);

                }

                return dato;

            }
            public static int DevolverSeleccion(string RolUsuario)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Bienvenid(@) " + usuario);
                Console.SetCursorPosition(58, 0);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Usuario: " + usuario);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, 1);
                int dato = 0;
               
                
               
            }
            public static string DevolverRol(string usuario, int col)
            {
                string dato = "NO";
                for (int x = 0; x < 100; x++)

                {

                    if (usuarios[x, 3] == usuario)
                    {
                        dato = (usuarios[x, col]);
                    }

                }
                return dato;
            }
            public static void Login()
            {
                Console.Write("Ingrese su usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Ingrese la contraseña: ");
                pass = "";
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);
                Console.SetCursorPosition(1, 2);
                CargarDatos(1);
                rol = (DevolverRol(usuario, 5));

                Console.WriteLine(ValidarUsuario(DevolverRol(usuario, 4), pass));
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void CargarDatos(int opcion)
            {
                if (opcion == 1)
                {
                    StreamReader sr = new StreamReader("@usuarios.txt");
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        LlenarMatriz(line, 1);
                    }
                    sr.Close();
                }
               
                    sr.Close();
                }
            }
            public static string EscribirArchivo(string[,] Matriz, int Filas, int Columnas)
            {
                int x, y;
                string campo, registro = "";
                y = 0;
                while (y < Filas)
                {
                    x = 0;
                    campo = "";
                    while (x < Columnas)
                    {
                        campo = campo + Matriz[y, x] + ",";
                        x = x + 1;
                    }
                    registro = registro + campo + "*";
                    y = y + 1;
                }


                return registro;

            }

            public static void LlenarMatriz(String str, int opcion)
            {
                int x, y;

                String[] strlist = str.Split('*');
                x = 0;
                while (x < strlist.Length - 1)
                {
                    int limite = 0;
                    if (opcion == 1)
                    {
                        limite = 6;
                    }
                    else if (opcion == 2)
                    {
                        limite = 4;
                    }
                    if (opcion == 3)
                    {
                        limite = 6;
                    }
                    if (opcion == 4)
                    {
                        limite = 6;
                    }
                    String[] strlist2 = strlist[x].Split(',');
                    y = 0;
                    while (y < limite)
                    {
                        if (opcion == 1)
                        {
                            usuarios[x, y] = strlist2[y];
                        }
                        else if (opcion == 2)
                        {
                            productos[x, y] = strlist2[y];
                        }
                        else if (opcion == 3)
                        {
                            facturas[x, y] = strlist2[y];
                        }
                        else if (opcion == 4)
                        {
                            DetalleFact[x, y] = strlist2[y];
                        }
                        y = y + 1;
                    }
                    x = x + 1;
                }
                Console.ReadKey();

            }
        }
    }
        {
        }
    }
}
