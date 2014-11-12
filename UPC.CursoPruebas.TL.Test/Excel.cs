using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace UPC.CursoPruebas.TL.Test
{
    public class Excel
    {
        public List<List<String>> LeerExcel(int indiceDeHojaExcel)
        {
            List<List<String>> ListaExterna = new List<List<String>>();
            try
            {
                HSSFWorkbook archivoExcel;
                using (FileStream file = new FileStream(@"C:\ProgramasInstalados\DatosParaMatricula.xls", FileMode.Open, FileAccess.Read))
                {
                    archivoExcel = new HSSFWorkbook(file);
                }
                ISheet hojaExcel = archivoExcel.GetSheetAt(indiceDeHojaExcel);
                for (int row = 1; row <= hojaExcel.LastRowNum; row++)
                {
                    List<String> listaInterna = new List<String>();
                    if (hojaExcel.GetRow(row) != null) //null is when the row only contains empty cells 
                    {
                        List<ICell> celdas = hojaExcel.GetRow(row).Cells;
                        int celda = 0;
                        while (celda < celdas.Count)
                        {
                            if (celdas[celda].CellType == CellType.Numeric)
                            {
                                listaInterna.Add(((int)celdas[celda].NumericCellValue).ToString());
                            }
                            else
                            {
                                listaInterna.Add(celdas[celda].StringCellValue);
                            }
                            celda++;
                        }
                        ListaExterna.Add(listaInterna);
                    }
                }
            }
            catch (Exception e)
            {
                String d = e.StackTrace;
            }
            return ListaExterna;
        }
    }
}
