using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UPC.CursoPruebas.BL.BE;


using System.Data;
using System.Configuration;

using MySql.Data.MySqlClient;

namespace UPC.CursoPruebas.DL.DALC
{
    public class CursoDALC
    {
        public List<CursoBE> ListarCursos()
        {
            String query;
            String sConn;
            List<CursoBE> L;
            try
            {
                
                sConn = "server=localhost;database=matriculadb;user id=root";
                MySqlConnection con = new MySqlConnection(sConn);
                query = "SELECT * FROM curso";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds,"curso");
                
                L = new List<CursoBE>();
                for (int i = 0;i<ds.Tables[0].Rows.Count ;i++)
                {
                    CursoBE curso = new CursoBE();
                    curso.IdCurso = Int32.Parse(ds.Tables[0].Rows[i]["idcurso"].ToString());
                    curso.Nombre = ds.Tables[0].Rows[i]["nombre"].ToString();
                    curso.Codigo = ds.Tables[0].Rows[i]["codigo"].ToString();
                    curso.Creditos = Int32.Parse(ds.Tables[0].Rows[i]["creditos"].ToString());
                    curso.Requisitos = ds.Tables[0].Rows[i]["requisitos"].ToString();
                    curso.Ciclo = Int32.Parse(ds.Tables[0].Rows[i]["ciclo"].ToString());
                    L.Add(curso);
                }
                ds.Dispose();
                return L;
            }
            catch (Exception ex)
            {
                return null;
                
            }
        }
        
        public CursoBE ObtenerCursoPorid(int id)
        {
            String query;
            String sConn;

            try
            {
                
                sConn = "server=localhost;database=matriculadb;user id=root";
                MySqlConnection con = new MySqlConnection(sConn);
                query = "SELECT * FROM curso WHERE idcurso=" + id.ToString();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "curso");

                CursoBE curso = new CursoBE();
                curso.IdCurso = Int32.Parse(ds.Tables[0].Rows[0]["idcurso"].ToString());
                curso.Nombre = ds.Tables[0].Rows[0]["nombre"].ToString();
                curso.Codigo = ds.Tables[0].Rows[0]["codigo"].ToString();
                curso.Creditos = Int32.Parse(ds.Tables[0].Rows[0]["creditos"].ToString());
                curso.Requisitos = ds.Tables[0].Rows[0]["requisitos"].ToString();
                curso.Ciclo = Int32.Parse(ds.Tables[0].Rows[0]["ciclo"].ToString());

                if (curso.Nombre == null)
                {
                    curso = null;
                }
                ds.Dispose();
                return curso;
            }
            catch (Exception ex)
            {
                
                return null;
            }
        }

        public bool InsertarCurso(CursoBE objCursoBE)
        {
            String query;
            String sConn;

            try
            {
                
                sConn = "server=localhost;database=matriculadb;user id=root";
                MySqlConnection con = new MySqlConnection(sConn);
                query = "INSERT INTO curso(idcurso, nombre, codigo, creditos, requisitos, ciclo) VALUES('" + null + "','" + objCursoBE.Nombre + "','" + objCursoBE.Codigo + 
                    "'," + objCursoBE.Creditos.ToString() + ",'" + objCursoBE.Requisitos + "'," + objCursoBE.Ciclo.ToString() + ")";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "curso");
                ds.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                
            }
        }
        
        public bool ActualizarCurso(CursoBE objCursoBE)
        {
            String query;
            String sConn;

            try
            {
                
                sConn = "server=localhost;database=matriculadb;user id=root";
                MySqlConnection con = new MySqlConnection(sConn);
                query = "UPDATE curso SET nombre='"+objCursoBE.Nombre+"',codigo='"+objCursoBE.Codigo+"',creditos="+objCursoBE.Creditos.ToString()+
                    ",requisitos='"+objCursoBE.Requisitos+"',ciclo="+objCursoBE.Ciclo.ToString()+" WHERE idcurso="+objCursoBE.IdCurso.ToString();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "curso");
                ds.Dispose();
                return true;

                

            
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool EliminarCurso(int id)
        {
            String query;
            String sConn;

            try
            {
                
                sConn = "server=localhost;database=matriculadb;user id=root";
                MySqlConnection con = new MySqlConnection(sConn);
                query = "DELETE FROM curso WHERE idcurso="+id.ToString();
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "curso");
                ds.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                
            }
        }
    }


}
