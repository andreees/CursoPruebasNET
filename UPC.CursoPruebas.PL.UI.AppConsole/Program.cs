using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UPC.CursoPruebas.BL.BE;
using UPC.CursoPruebas.DL.DALC;

namespace UPC.CursoPruebas.PL.UI.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertarCurso("IA1", "SI101", 3, "Nada", 1);
            Console.ReadLine();
        }
        static void ListarTodo()
        {
            List<CursoBE> Lista;
            CursoDALC objUDALC;
            try
            {
                objUDALC = new CursoDALC();
                Lista = objUDALC.ListarCursos();
                Console.WriteLine("Datos Curso: ");
                Console.WriteLine("-----------------");
                for (int i = 0; i < Lista.Count; i++)
                {
                    Console.WriteLine("id de Curso: " + Lista[i].IdCurso.ToString());
                    Console.WriteLine("Nombre: " + Lista[i].Nombre);
                    Console.WriteLine("Codigo: " + Lista[i].Codigo);
                    Console.WriteLine("Creditos: " + Lista[i].Creditos.ToString());
                    Console.WriteLine("Requisitos: " + Lista[i].Requisitos);
                    Console.WriteLine("Ciclo: " + Lista[i].Ciclo.ToString());
                    Console.WriteLine();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(":o hubo un problema!");

                return;
            }
        }

        static void ObtenerCursoPorid(int id)
        {
            CursoDALC cur=new CursoDALC();
            CursoBE curso=cur.ObtenerCursoPorid(id);
            
            Console.WriteLine("id de Curso: " + curso.IdCurso.ToString());
            Console.WriteLine("Nombre: " + curso.Nombre);
            Console.WriteLine("Codigo: " + curso.Codigo);
            Console.WriteLine("Creditos: " + curso.Creditos.ToString());
            Console.WriteLine("Requisitos: " + curso.Requisitos);
            Console.WriteLine("Ciclo: " + curso.Ciclo.ToString());
            Console.WriteLine();
        }

        static bool InsertarCurso(String nombre, String codigo, int creditos, String requisitos, int ciclo)
        {
            CursoDALC cur = new CursoDALC();
            CursoBE curso=new CursoBE();
            curso.Nombre=nombre;
            curso.Codigo=codigo;
            curso.Creditos=creditos;
            curso.Requisitos=requisitos;
            curso.Ciclo=ciclo;
            bool respuesta = cur.InsertarCurso(curso);
            return respuesta;
        }

        static bool ActualizarCurso(int idCurso, String nombre, String codigo, int creditos, String requisitos, int ciclo)
        {
            CursoDALC cur = new CursoDALC();
            CursoBE curso = new CursoBE();
            curso.IdCurso = idCurso;
            curso.Nombre = nombre;
            curso.Codigo = codigo;
            curso.Creditos = creditos;
            curso.Requisitos = requisitos;
            curso.Ciclo = ciclo;
            bool respuesta = cur.ActualizarCurso(curso);
            return respuesta;
        }

        static bool EliminarCurso(int id)
        {
            CursoDALC cur = new CursoDALC();
            return cur.EliminarCurso(id);
        }
    }
}
