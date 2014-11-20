using UPC.CursoPruebas.DL.DALC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UPC.CursoPruebas.BL.BE;
using System.Collections.Generic;



namespace UPC.CursoPruebas.DL.DALC.Pruebas
{
    
    

    /// <summary>
    ///Se trata de una clase de prueba para CursoDALCTest y se pretende que
    ///contenga todas las pruebas unitarias CursoDALCTest.
    ///</summary>
    [TestClass()]
    public class CursoDALCTest
    {
        const int ID = 11;

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        
        #endregion


        /// <summary>
        ///Una prueba de ListarCursos
        ///</summary>
        [TestMethod()]
        public void ListarCursosValidoTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            // TODO: Inicializar en un valor adecuado
            List<CursoBE> actual;
            actual = target.ListarCursos();
            int expected = 1;
            Assert.AreEqual(expected > 0, actual.Count > 0);
        }

        /// <summary>
        ///Una prueba de ListarCursos
        ///</summary>
        
        [TestMethod()]
        public void ListarCursosInvalidoTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            //List<CursoBE> expected = null; // TODO: Inicializar en un valor adecuado
            int expected = 0;
            List<CursoBE> actual;
            actual = target.ListarCursos();
            Assert.AreEqual(expected, actual.Count);
        }
        


        /// <summary>
        ///Una prueba de InsertarCurso
        ///</summary>
        [TestMethod()]
        public void InsertarCursoValidoTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            CursoBE objCursoBE = new CursoBE(); // TODO: Inicializar en un valor adecuado
            objCursoBE.Nombre = "Arquitectura de Software";
            objCursoBE.Codigo = "Sw352";
            objCursoBE.Creditos = 4;
            objCursoBE.Requisitos = "Ninguno";
            objCursoBE.Ciclo = 7;
            bool expected = true; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = target.InsertarCurso(objCursoBE);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        ///Una prueba de InsertarCurso
        ///</summary>
        [TestMethod()]
        public void InsertarCursoInvalidoTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            CursoBE objCursoBE = null ; // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = target.InsertarCurso(objCursoBE);
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///Una prueba de ObtenerCursoPorid
        ///</summary>
        [TestMethod()]
        public void ObtenerCursoValidoPoridTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            int id = ID; // TODO: Inicializar en un valor adecuado
            
            CursoBE actual;
            actual = target.ObtenerCursoPorid(id);
            Assert.AreEqual(id, actual.IdCurso);
        }

        /// <summary>
        ///Una prueba de ObtenerCursoPorid
        ///</summary>
        [TestMethod()]
        public void ObtenerCursoInvalidoPoridTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            int id = 0; // TODO: Inicializar en un valor adecuado
            CursoBE expected = null; // TODO: Inicializar en un valor adecuado
            CursoBE actual;
            actual = target.ObtenerCursoPorid(id);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Una prueba de EliminarCurso
        ///</summary>
        [TestMethod()]
        public void EliminarCursoValidoTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            int id = ID; // TODO: Inicializar en un valor adecuado
            bool expected = true; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = target.EliminarCurso(id);
            Assert.AreEqual(expected, actual);
        }

        
        /// <summary>
        ///Una prueba de ActualizarCurso
        ///</summary>
        [TestMethod()]
        public void ActualizarCursoValidoTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            CursoBE objCursoBE = new CursoBE(); // TODO: Inicializar en un valor adecuado
            objCursoBE.IdCurso = ID;
            objCursoBE.Nombre = "Arquitectura de Software";
            objCursoBE.Codigo = "Sw352";
            objCursoBE.Creditos = 4;
            objCursoBE.Requisitos = "Ninguno";
            objCursoBE.Ciclo = 7;
            bool expected = true; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = target.ActualizarCurso(objCursoBE);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Una prueba de ActualizarCurso
        ///</summary>
        [TestMethod()]
        public void ActualizarCursoInvalidoTest()
        {
            CursoDALC target = new CursoDALC(); // TODO: Inicializar en un valor adecuado
            CursoBE objCursoBE = null; // TODO: Inicializar en un valor adecuado
            bool expected = false; // TODO: Inicializar en un valor adecuado
            bool actual;
            actual = target.ActualizarCurso(objCursoBE);
            Assert.AreEqual(expected, actual);
        }
    }
}
