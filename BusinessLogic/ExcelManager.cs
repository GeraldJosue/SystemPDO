using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ExcelManager
    {
        Microsoft.Office.Interop.Excel.Application excel;
        Workbook excelworkBook;
        Worksheet excelSheet;
        List<Colaborador> colaboradores;
        Colaborador colaborador;
        public ExcelManager()
        {
            colaboradores = new Colaborador().obtener_lista_activos();
        }
        public Boolean export(List<Pago> pagos)
        {
            try
            {
                // Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();

                // for making Excel visible
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Add(Type.Missing);
                excelworkBook.SaveAs(pagos[0].Id_planilla);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;


                //excelSheet.Name = String.Format("{0:yyyy}-{0:MM}-{0:dd}", DateTime.Now);
                excelSheet.Name = pagos[0].Id_planilla.ToString();

                Int32 x = 1;
                Int32 y = -11;
                Int32 contador = 0;

                List<Range> lista;

                foreach(Pago p in pagos) {

                    colaborador = set_colaborador(p.Id_colaborador);

                    if(contador == 4)
                    {
                        x += 7;
                        y = 1;
                        contador = 1;
                    } else
                    {
                        y += 12;
                        ++contador;
                    }

                    lista = new List<Range>();

                    Range cuadro = excelSheet.Range[excelSheet.Cells[y + 10, x], excelSheet.Cells[y, x + 5]];
                    Borders borde = cuadro.Borders;
                    borde[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    borde[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    borde[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                    borde[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;


                    Range encabezado = excelSheet.Range[excelSheet.Cells[y, x], excelSheet.Cells[y, x + 5]];
                    lista.Add(encabezado);
                    Range info = excelSheet.Range[excelSheet.Cells[y + 2, x], excelSheet.Cells[y + 2, x + 3]];
                    lista.Add(info);
                    Range planilla = excelSheet.Range[excelSheet.Cells[y + 2, x + 5], excelSheet.Cells[y + 2, x + 5]];
                    lista.Add(planilla);
                    Range horas = excelSheet.Range[excelSheet.Cells[y + 5, x], excelSheet.Cells[y + 5, x + 2]];
                    lista.Add(horas);
                    Range incentivos = excelSheet.Range[excelSheet.Cells[y + 7, x], excelSheet.Cells[y + 7, x + 2]];
                    lista.Add(incentivos);
                    Range deducciones = excelSheet.Range[excelSheet.Cells[y + 9, x], excelSheet.Cells[y + 9, x + 2]];
                    lista.Add(deducciones);
                    Range bruto = excelSheet.Range[excelSheet.Cells[y + 5, x + 4], excelSheet.Cells[y + 5, x + 5]];
                    lista.Add(bruto);
                    Range neto = excelSheet.Range[excelSheet.Cells[y + 7, x + 4], excelSheet.Cells[y + 7, x + 5]];
                    lista.Add(neto);

                    foreach (Range r in lista)
                    {
                        dibujar_reporte(r);
                    }


                    excelSheet.Cells[y, x] = "Distribuidora de Carnes Oviedo";

                    excelSheet.Cells[y + 2, x] = "Colaborador";
                    excelSheet.Cells[y + 3, x] = colaborador.Nombre + " " + colaborador.Apellido + " " + colaborador.Segundo_apellido;

                    excelSheet.Cells[y + 2, x + 3] = "Fecha";
                    excelSheet.Cells[y + 3, x + 3] = p.FechaPago.ToShortDateString();

                    excelSheet.Cells[y + 2, x + 5] = "Planilla";
                    excelSheet.Cells[y + 3, x + 5] = p.Id_planilla;

                    excelSheet.Cells[y + 5, x] = "Horas Laboradas";
                    excelSheet.Cells[y + 6, x] = p.HorasLaboradas;

                    excelSheet.Cells[y + 5, x + 2] = "Horas Extras";
                    excelSheet.Cells[y + 6, x + 2] = p.HorasExtra;

                    excelSheet.Cells[y + 5, x + 4] = "Salario Bruto";
                    excelSheet.Cells[y + 6, x + 4] = p.SalarioBruto.ToString("C");

                    excelSheet.Cells[y + 7, x] = "Bonos";
                    excelSheet.Cells[y + 8, x] = p.Bono.ToString("C");

                    excelSheet.Cells[y + 7, x + 1] = "Vacaciones";
                    excelSheet.Cells[y + 8, x + 1] = p.Vacaciones.ToString("C");

                    excelSheet.Cells[y + 7, x + 2] = "Aguinaldo";
                    excelSheet.Cells[y + 8, x + 2] = p.Aguinaldo.ToString("C");

                    excelSheet.Cells[y + 7, x + 4] = "Salario Neto";
                    excelSheet.Cells[y + 8, x + 4] = p.SalarioNeto.ToString("C");

                    excelSheet.Cells[y + 9, x] = "Adelantos";
                    excelSheet.Cells[y + 10, x] = p.Adelanto.ToString("C");

                    excelSheet.Cells[y + 9, x + 1] = "Rebajos";
                    excelSheet.Cells[y + 10, x + 1] = p.Rebajo.ToString("C");

                    excelSheet.Cells[y + 9, x + 2] = "Seguro";
                    excelSheet.Cells[y + 10, x + 2] = p.Seguro.ToString("C");


                }

                excel.Visible = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void dibujar_reporte(Range rango)
        {
            //rango.EntireColumn.AutoFit();
            rango.Interior.ColorIndex = 15;
            rango.Font.Bold = true;
            Borders borde = rango.Borders;
            borde[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borde[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borde[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borde[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
        }

        public Colaborador set_colaborador(Int32 id)
        {
            Colaborador colaborador = new Colaborador();
            foreach (Colaborador c in colaboradores)
            {
                if (id == c.Id)
                {
                    return c;
                }
            }
            return colaborador;
        }
    }
}