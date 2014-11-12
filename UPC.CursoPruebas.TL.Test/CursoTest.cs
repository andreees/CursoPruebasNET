using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using UPC.CursoPruebas.DL.DALC;
using UPC.CursoPruebas.BL.BE;
using Selenium;

namespace UPC.CursoPruebas.TL.Test
{
    [TestFixture]
    public class CursoTest  
    {   
        private ISelenium selenium;
        
        [TestFixtureSetUp]
        public void Init()
        {
            selenium = new DefaultSelenium("localhost", 4441, "firefox", "http://localhost:9312/");
			selenium.Start();
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            selenium.Stop();
        }

        [Test]
        public void ListarCurso_Invalido()
        {
            CursoDALC CursoD = new CursoDALC();
        
            selenium.Open("/ListarCurso.aspx");
            selenium.WaitForPageToLoad("30000");
        
            List<CursoBE> lista;
            lista = CursoD.ListarCursos();
        
            Assert.True(lista!=null && lista.Count==0);
        }

        [Test]
        public void ListarCurso_Valido()
        {
            CursoDALC CursoD = new CursoDALC();

            selenium.Open("/ListarCurso.aspx");
            selenium.WaitForPageToLoad("30000");

            List<CursoBE> lista;
            lista = CursoD.ListarCursos();

            Assert.True(lista != null);
        }
        
        [Test]
        public void CrearCurso_Valido()
        {
            CursoDALC CursoD = new CursoDALC();
            int cantidadDeCursosAlInicio, cantidadDeCursosAlFinal;

            List<CursoBE> lista;
            lista = CursoD.ListarCursos();
            cantidadDeCursosAlInicio = lista.Count;

            //Leer de excel la data
            List<List<String>> data = new Excel().LeerExcel(0);
            
            foreach(List<String> listainterna in data)
            {
                selenium.Open("/CrearCurso.aspx");
                selenium.Type("txtNombre", listainterna[0]);
                selenium.Type("txtCodigo", listainterna[1]);
                selenium.Type("txtCreditos", listainterna[2]);
                selenium.Type("txtRequisitos", listainterna[3]);
                selenium.Type("txtCiclo", listainterna[4]);
                selenium.Click("btnCrearCurso");
                selenium.WaitForPageToLoad("30000");
            
                cantidadDeCursosAlFinal = CursoD.ListarCursos().Count;
                Assert.True(cantidadDeCursosAlFinal>cantidadDeCursosAlInicio);
            }
        }

        [Test]
        public void CrearCurso_Invalido()
        {
            CursoDALC CursoD = new CursoDALC();
            int cantidadDeCursosAlInicio, cantidadDeCursosAlFinal;

            List<CursoBE> lista;
            lista = CursoD.ListarCursos();
            cantidadDeCursosAlInicio = lista.Count;

            //Leer de excel la data
            List<List<String>> data = new Excel().LeerExcel(2);

            foreach (List<String> listainterna in data)
            {
                selenium.Open("/CrearCurso.aspx");
                selenium.Type("txtNombre", listainterna[0]);
                selenium.Type("txtCodigo", listainterna[1]);
                selenium.Type("txtCreditos", listainterna[2]);
                selenium.Type("txtRequisitos", listainterna[3]);
                selenium.Type("txtCiclo", listainterna[4]);
                selenium.Click("btnCrearCurso");

                try
                {
                    selenium.WaitForPageToLoad("30000");
                }
                catch (SeleniumException e)
                {
                    if (e.Message.Equals("Timed out after 30000ms"))
                    {
                        cantidadDeCursosAlFinal = CursoD.ListarCursos().Count;
                        Assert.True(cantidadDeCursosAlFinal == cantidadDeCursosAlInicio);
                        return;
                    }
                }
                Assert.Fail();
            }
        }

        [Test]
        public void ModificarCurso_Valido()
        {
            //Leer de excel la data
            List<List<String>> data = new Excel().LeerExcel(1);

            foreach (List<String> listainterna in data)
            {
                selenium.Open("/ModificarCurso.aspx");
                selenium.Click("grdCursos_lnkModificar_0");
                selenium.WaitForPageToLoad("30000");
                selenium.Type("txtNombre", listainterna[0]);
                selenium.Type("txtCodigo", listainterna[1]);
                selenium.Type("txtCreditos", listainterna[2]);
                selenium.Type("txtRequisitos", listainterna[3]);
                selenium.Type("txtCiclo", listainterna[4]);
                selenium.Click("btnModificarCurso");
                selenium.WaitForPageToLoad("30000");

                Assert.AreEqual(selenium.GetText("lblMensaje"), "El curso ha sido modificado correctamente.");
            }
        }

        [Test]
        public void ModificarCurso_Invalido()
        {
            CursoDALC CursoD = new CursoDALC();
            int cantidadDeCursosAlInicio, cantidadDeCursosAlFinal;

            List<CursoBE> lista;
            lista = CursoD.ListarCursos();
            cantidadDeCursosAlInicio = lista.Count;

            //Leer de excel la data
            List<List<String>> data = new Excel().LeerExcel(3);

            foreach (List<String> listainterna in data)
            {
                selenium.Open("/ModificarCurso.aspx");
                selenium.Click("grdCursos_lnkModificar_0");
                selenium.WaitForPageToLoad("30000");
                selenium.Type("txtNombre", listainterna[0]);
                selenium.Type("txtCodigo", listainterna[1]);
                selenium.Type("txtCreditos", listainterna[2]);
                selenium.Type("txtRequisitos", listainterna[3]);
                selenium.Type("txtCiclo", listainterna[4]);
                selenium.Click("btnModificarCurso");

                try
                {
                    selenium.WaitForPageToLoad("30000");
                }
                catch (SeleniumException e)
                {
                    if (e.Message.Equals("Timed out after 30000ms"))
                    {
                        cantidadDeCursosAlFinal = CursoD.ListarCursos().Count;
                        Assert.True(cantidadDeCursosAlFinal == cantidadDeCursosAlInicio);
                        return;
                    }
                }
                Assert.Fail();
            }
        }

        [Test]
        public void EliminarCurso_Valido()
        {
            CursoDALC CursoD = new CursoDALC();
            int cantidadDeCursosAlInicio, cantidadDeCursosAlFinal;

            List<CursoBE> lista;
            lista = CursoD.ListarCursos();
            cantidadDeCursosAlInicio = lista.Count;

            selenium.Open("/EliminarCurso.aspx");
            selenium.Click("grdCursos_lnkEliminar_0");
            selenium.WaitForPageToLoad("30000");

            cantidadDeCursosAlFinal = CursoD.ListarCursos().Count;
            Assert.True(cantidadDeCursosAlFinal==cantidadDeCursosAlInicio-1);
            
        }
    }
}