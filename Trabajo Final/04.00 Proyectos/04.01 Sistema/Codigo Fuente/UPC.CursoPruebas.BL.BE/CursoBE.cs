using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.CursoPruebas.BL.BE
{
    public class CursoBE
    {
        private int _idCurso;
        private String _nombre;
        private String _codigo;
        private int _creditos;
        private String _requisitos;
        private int _ciclo;

        public int IdCurso
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }
        

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        

        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        

        public int Creditos
        {
            get { return _creditos; }
            set { _creditos = value; }
        }
        

        public String Requisitos
        {
            get { return _requisitos; }
            set { _requisitos = value; }
        }
        

        public int Ciclo
        {
            get { return _ciclo; }
            set { _ciclo = value; }
        }
    }
}
