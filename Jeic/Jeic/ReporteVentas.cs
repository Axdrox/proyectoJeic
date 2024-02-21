using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//EXCEL
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ExcelDataReader;
using System.Data.SqlClient;
using Refracciones;
using System.Windows.Forms;
using SpreadsheetLight;
using Refracciones.Forms;

namespace Jeic
{
    internal class ReporteVentas
    {

        private SqlCommand Comando;
        private SqlDataReader Lector;
        OperBD operBD = new OperBD();

        private Style GetStyleHeader(Workbook wb)
        {
            Style style = wb.Styles.Add("MiEstilo");
            style.Font.Bold = true;
            style.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            //style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            //style.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);

            return style;
        }

        public void generarExcelTest(string ruta, string fecha1, string fecha2, decimal costoOperativo, string cvePed, bool valesLiberados)
        {

            

            int totalRegistrosExportar = 0;
            int temp = 0;
            Double tempd = 0;
            double costoAdq = 0;
            double precioV = 0;
            double utilidadAdq = 0;
            double utilidadFinal = 0;
            double gasto = 0;
            string tempSAE;
            DateTime datevalue;
            File.WriteAllBytes(ruta, Jeic.Properties.Resources.Plantilla);
            DateTime hoy = DateTime.Today;

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;



            Workbook workbook = excelApp.Workbooks.Open(ruta);

            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            worksheet.Cells[2, 13] = hoy.ToString("dd-MM-yyyy");//Se agrega la fecha al excel


            using (SqlConnection nuevaConexion = Conexion.conexion())
            {
                nuevaConexion.Open();
                int celdaContenido = 9;



                if (valesLiberados)
                    Comando = new SqlCommand(string.Format("SELECT Count(ven.cve_venta) AS 'TOTAL DE REGISTROS A EXPORTAR' FROM VENTAS ven  INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta  WHERE ped.vale_liberado = 1 AND ven.fecha_asignacion BETWEEN @fecha1 AND @fecha2 AND ven.cve_pedido LIKE '{0}%'", cvePed), nuevaConexion);
                else
                    Comando = new SqlCommand(string.Format("SELECT Count(ven.cve_venta) AS 'TOTAL DE REGISTROS A EXPORTAR' FROM VENTAS ven  INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta  WHERE ven.fecha_asignacion BETWEEN @fecha1 AND @fecha2 AND ven.cve_pedido LIKE '{0}%'", cvePed), nuevaConexion);

                Comando.Parameters.AddWithValue("@fecha1", fecha1);
                Comando.Parameters.AddWithValue("@fecha2", fecha2);
                totalRegistrosExportar = Int32.Parse(Comando.ExecuteScalar().ToString());
                MessageBox.Show("El número de registros encontrados son: " + totalRegistrosExportar.ToString() + "\n" + "Recuerda que utilizando esta opción puedes dejar esta sesión abierta y iniciar una nueva para continuar realizando tus actividades", "Generar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                if (valesLiberados)
                    Comando = new SqlCommand(string.Format("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', ped.costoEnvio AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', ven.fecha_asignacion  AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa  AS 'FECHA PROMESA', ent.fecha  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ped.fecha_baja  AS 'FECHA DE BAJA', dev.fecha  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ped.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision  AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(ped.costoEnvio + ped.costo_neto) AS 'COSTO ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',(ped.gasto + ped.precio_reparacion) AS 'GASTO',ven.cve_venta,pie.cve_pieza, ess.estado AS 'ESTADO',ped.conductorMod AS 'CHOFER', ped.ubicacion AS 'UBICACION', ped.vale_liberado AS 'VALE LIBERADO' FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_nombre = val.cve_cliente INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ped.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion INNER JOIN Estado_Siniestro ess ON ped.estado = ess.cve_estado WHERE ped.vale_liberado = 1 AND  ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2 AND ven.cve_pedido LIKE '{0}%' ORDER BY ven.fecha_asignacion ", cvePed), nuevaConexion);//13/NOV/2023 vales liberados solamente
                else
                    Comando = new SqlCommand(string.Format("SELECT ven.cve_pedido AS 'PEDIDO', ven.cve_siniestro AS 'SINIESTRO', c.cve_nombre AS 'CLIENTE', val.nombre AS 'VALUADOR', t.nombre AS 'TALLER', vh.modelo AS 'VHEICULO MODELO',marca.marca AS 'MARCA', vh.anio 'AÑO', pro.nombre AS 'PROVEEDOR', pie.nombre AS 'PIEZA', ped.cve_producto AS 'CLAVE PRODUCTO', ped.cantidad AS 'TOTAL DE PIEZAS', ped.cve_guia AS 'GUÍA DE ENVIO', opie.origen AS 'ORIGEN PIEZA', por.nombre 'PORTAL', ped.costoEnvio AS 'COSTO ENVÍO', ped.costo_neto AS 'COSTO', ped.precio_venta AS 'PRECIO VENTA', dest.destino AS 'DESTINO',vendedor.cve_vendedor AS 'NUMERO DE VENDEDOR', vendedor.nombre AS 'VENDEDOR', ven.fecha_asignacion  AS 'FECHA DE ASIGNACIÓN', ven.fecha_promesa  AS 'FECHA PROMESA', ent.fecha  AS 'FECHA DE ENTREGA', ped.pzas_entregadas AS 'PIEZAS ENTREGADAS', ped.entrega_enTiempo AS 'ENTREGA EN TIEMPO', ped.dias_entrega AS 'DÍAS DE ENTREGA', ped.fecha_baja  AS 'FECHA DE BAJA', dev.fecha  AS 'FECHA DEVOLUCIÓN', dev.motivo AS 'MOTIVO DE DEVOLUCIÓN', ped.pzas_devolucion AS 'CANTIDAD DE PIEZAS DEVUELTAS', dev.penalizacion AS 'PENALIZACIÓN POR DEVOLUCIÓN', ped.cve_factura AS 'FACTURA ACTUAL', fact.cve_refactura AS 'FACTURA ANTERIOR', fact.fecha_ingreso  AS 'FECHA INGRESO FACTURA', estfact.estado AS 'ESTADO DE LA FACTURA', fact.fecha_revision  AS 'FECHA DE REVISIÓN FACTURA', fact.fecha_pago  AS 'FECHA DE PAGO FACTURA', ped.precio_venta AS 'FACTURA SIN IVA', (ped.precio_venta * 1.16) AS 'FACTURA NETO', si.comentario AS 'COMENTARIOS SINIESTRO', fact.comentario AS 'COMENTARIOS FACTURA',(ped.costoEnvio + ped.costo_neto) AS 'COSTO ADQUISICION', (@costoOperativo) AS 'COSTO OPERATIVO',(ped.gasto + ped.precio_reparacion) AS 'GASTO',ven.cve_venta,pie.cve_pieza, ess.estado AS 'ESTADO',ped.conductorMod AS 'CHOFER', ped.ubicacion AS 'UBICACION', ped.vale_liberado AS 'VALE LIBERADO' FROM VENTAS ven INNER JOIN VALUADOR val ON ven.cve_valuador = val.cve_valuador INNER JOIN CLIENTE c ON c.cve_nombre = val.cve_cliente INNER JOIN TALLER t ON ven.cve_taller = t.cve_taller INNER JOIN SINIESTRO si ON ven.cve_siniestro = si.cve_siniestro INNER JOIN VEHICULO vh ON si.cve_vehiculo = vh.cve_vehiculo INNER JOIN PEDIDO ped ON ven.cve_venta = ped.cve_venta INNER JOIN PROVEEDOR pro ON ped.cve_proveedor = pro.cve_proveedor INNER JOIN PIEZA pie ON ped.cve_pieza = pie.cve_pieza INNER JOIN ORIGEN_PIEZA opie ON ped.cve_origen = opie.cve_origen INNER JOIN PORTAL por ON ped.cve_portal = por.cve_portal INNER JOIN DESTINO dest ON ven.cve_destino = dest.cve_destino LEFT OUTER JOIN FACTURA fact ON ped.cve_factura = fact.cve_factura FULL JOIN ESTADO_FACTURA estfact ON fact.cve_estado = estfact.cve_estado INNER JOIN VENDEDOR vendedor ON ven.cve_vendedor = vendedor.cve_vendedor INNER JOIN MARCA marca ON vh.cve_marca = marca.cve_marca FULL JOIN ENTREGA ent ON ped.cve_entrega = ent.cve_entrega FULL JOIN DEVOLUCION dev ON ped.cve_devolucion = dev.cve_devolucion INNER JOIN Estado_Siniestro ess ON ped.estado = ess.cve_estado WHERE ven.fecha_asignacion BETWEEN  @fecha1 AND @fecha2 AND ven.cve_pedido LIKE '{0}%' ORDER BY ven.fecha_asignacion", cvePed), nuevaConexion);//13/NOV/2023


                Comando.Parameters.AddWithValue("@fecha1", fecha1);
                Comando.Parameters.AddWithValue("@fecha2", fecha2);
                Comando.Parameters.AddWithValue("@costoOperativo", costoOperativo);
                Lector = Comando.ExecuteReader();

                for (int r = 0; r < totalRegistrosExportar; r++)

                {
                    Lector.Read();

                    worksheet.Cells[celdaContenido, 1] = Lector["PEDIDO"].ToString();//A

                    worksheet.Cells[celdaContenido, 2] = Lector["SINIESTRO"].ToString();//B

                    worksheet.Cells[celdaContenido, 3] = "CLIENTE";//C

                    worksheet.Cells[celdaContenido, 4] = Lector["VALUADOR"].ToString();//D

                    worksheet.Cells[celdaContenido, 5] = Lector["TALLER"].ToString();//E

                    worksheet.Cells[celdaContenido, 6] = Lector["VHEICULO MODELO"].ToString();//F

                    worksheet.Cells[celdaContenido, 7] = Lector["MARCA"].ToString();//G

                    worksheet.Cells[celdaContenido, 8] = Lector["AÑO"].ToString();//H

                    worksheet.Cells[celdaContenido, 9] = Lector["PROVEEDOR"].ToString();//I

                    worksheet.Cells[celdaContenido, 10] = Lector["PIEZA"].ToString();//J

                    worksheet.Cells[celdaContenido, 11] = Lector["CLAVE PRODUCTO"].ToString();//K

                    tempSAE = operBD.DescSAE(Lector["VHEICULO MODELO"].ToString(), Lector["PIEZA"].ToString(), Lector["MARCA"].ToString(), Lector["AÑO"].ToString());
                    worksheet.Cells[celdaContenido, 12] = tempSAE;//L

                    worksheet.Cells[celdaContenido, 13] = Lector["TOTAL DE PIEZAS"].ToString();//M

                    worksheet.Cells[celdaContenido, 14] = Lector["GUÍA DE ENVIO"].ToString();//N

                    worksheet.Cells[celdaContenido, 15] = Lector["ORIGEN PIEZA"].ToString();//O

                    worksheet.Cells[celdaContenido, 16] = Lector["PORTAL"].ToString();//P

                    worksheet.Cells[celdaContenido, 17] = Lector["COSTO ENVÍO"].ToString();//Q

                    worksheet.Cells[celdaContenido, 18] = Lector["COSTO"].ToString();//R

                    worksheet.Cells[celdaContenido, 19] = Lector["PRECIO VENTA"].ToString();//S

                    worksheet.Cells[celdaContenido, 20] = Lector["DESTINO"].ToString();//T

                    worksheet.Cells[celdaContenido, 21] = Lector["NUMERO DE VENDEDOR"].ToString();//U

                    worksheet.Cells[celdaContenido, 22] = Lector["VENDEDOR"].ToString();//V

                    worksheet.Cells[celdaContenido, 23] = Lector["FECHA DE ASIGNACIÓN"].ToString();//W

                    worksheet.Cells[celdaContenido, 24] = Lector["FECHA PROMESA"].ToString();//X

                    worksheet.Cells[celdaContenido, 25] = Lector["FECHA DE ENTREGA"].ToString();//Y

                    worksheet.Cells[celdaContenido, 26] = Lector["PIEZAS ENTREGADAS"].ToString();//Z

                    if (Lector["ENTREGA EN TIEMPO"].ToString().ToUpper() == "TRUE")
                    {
                        worksheet.Cells[celdaContenido, 27] = "SI";//AA
                    }
                    else
                    {
                        worksheet.Cells[celdaContenido, 27] = Lector["ENTREGA EN TIEMPO"].ToString();//AA
                    }

                    worksheet.Cells[celdaContenido, 28] = Lector["DÍAS DE ENTREGA"].ToString();//AB

                    worksheet.Cells[celdaContenido, 29] = Lector["FECHA DE BAJA"].ToString();//AC

                    worksheet.Cells[celdaContenido, 30] = Lector["FECHA DEVOLUCIÓN"].ToString();//AD

                    worksheet.Cells[celdaContenido, 31] = Lector["MOTIVO DE DEVOLUCIÓN"].ToString();//AE

                    worksheet.Cells[celdaContenido, 32] = Lector["CANTIDAD DE PIEZAS DEVUELTAS"].ToString();//AF

                    worksheet.Cells[celdaContenido, 33] = Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString();//AG

                    worksheet.Cells[celdaContenido, 34] = operBD.PiezasDevueltas(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString()));//AH

                    worksheet.Cells[celdaContenido, 35] = operBD.PiezasDevueltasPen(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString()));//AI

                    worksheet.Cells[celdaContenido, 36] = Lector["FACTURA ACTUAL"].ToString();//AJ

                    worksheet.Cells[celdaContenido, 37] = Lector["FACTURA ANTERIOR"].ToString();//AK

                    worksheet.Cells[celdaContenido, 38] = Lector["FECHA INGRESO FACTURA"].ToString();//AL

                    worksheet.Cells[celdaContenido, 39] = Lector["ESTADO DE LA FACTURA"].ToString();//AM

                    worksheet.Cells[celdaContenido, 40] = Lector["FECHA DE REVISIÓN FACTURA"].ToString();//AN

                    worksheet.Cells[celdaContenido, 41] = Lector["FECHA DE PAGO FACTURA"].ToString();//AO

                    worksheet.Cells[celdaContenido, 42] = Lector["FACTURA SIN IVA"].ToString();//AP

                    worksheet.Cells[celdaContenido, 43] = Lector["FACTURA NETO"].ToString();//AQ

                    worksheet.Cells[celdaContenido, 44] = Lector["COMENTARIOS SINIESTRO"].ToString();//AR

                    worksheet.Cells[celdaContenido, 45] = Lector["ESTADO"].ToString();//AS

                    worksheet.Cells[celdaContenido, 46] = Lector["COMENTARIOS FACTURA"].ToString();//AT

                  

                    if (Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString() != "")
                    {
                        double costo = Double.Parse(Lector["COSTO ADQUISICION"].ToString());
                        double penalizacion = Double.Parse(Lector["PENALIZACIÓN POR DEVOLUCIÓN"].ToString()) / 100;//Porcentaje de penalización
                        costoAdq = (costo * penalizacion) + costo;
                        worksheet.Cells[celdaContenido, 47] = costoAdq;//AU
                    }
                    else if (operBD.PiezasDevueltasPen(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString())) != 0)
                    {
                        double costo = Double.Parse(Lector["COSTO ADQUISICION"].ToString());
                        double penalizacion = operBD.PiezasDevueltasPen(Convert.ToInt32(Lector["cve_venta"].ToString()), Convert.ToInt32(Lector["cve_pieza"].ToString()));//Porcentaje de penalización
                        costoAdq = (costo * penalizacion) + costo;
                        worksheet.Cells[celdaContenido, 47] = costoAdq;//AU
                    }
                    else
                    {
                        worksheet.Cells[celdaContenido, 47] = Lector["COSTO ADQUISICION"].ToString();
                        costoAdq = Double.Parse(Lector["COSTO ADQUISICION"].ToString());//AU
                    }

                    if (Double.TryParse(Lector["PRECIO VENTA"].ToString(), out tempd))
                    {
                        precioV = Double.Parse(Lector["PRECIO VENTA"].ToString());
                    }
                    else
                    {
                        precioV = 0;
                    }

                    utilidadAdq = precioV - costoAdq;

                    worksheet.Cells[celdaContenido, 48] = utilidadAdq;//AV

                    worksheet.Cells[celdaContenido, 49] = Lector["COSTO OPERATIVO"].ToString();//AW

                    if (Lector["GASTO"].ToString() == "")
                    {
                        worksheet.Cells[celdaContenido, 50] = "0";//AW
                        gasto = 0;
                    }
                    else
                    {
                        worksheet.Cells[celdaContenido, 50] = Lector["GASTO"].ToString();
                        gasto = Double.Parse(Lector["GASTO"].ToString());//AW
                    }

                    utilidadFinal = precioV - (costoAdq + gasto + double.Parse(costoOperativo.ToString()));
                    worksheet.Cells[celdaContenido, 51] = utilidadFinal;//AY

                    if (Lector["UBICACION"].ToString() == "" || Lector["UBICACION"].ToString() == "-1")
                    {
                        worksheet.Cells[celdaContenido, 52] = "-";//AZ

                    }
                    else if (Lector["UBICACION"].ToString() == "0")
                    {
                        worksheet.Cells[celdaContenido, 52] = "Proveedor";//AZ

                    }
                    else if (Lector["UBICACION"].ToString() == "1")
                    {
                        worksheet.Cells[celdaContenido, 52] = "Jeic Almacén";//AZ
                    }

                    worksheet.Cells[celdaContenido, 53] = Lector["CHOFER"].ToString();//BA

                    if (Lector["VALE LIBERADO"].Equals(true))//Vale liberado cambio solicitado JEIC 13 NOV 2023
                    {
                        worksheet.Cells[celdaContenido, 54] = "LIBERADO";//BB

                    }
                    else
                    {
                        worksheet.Cells[celdaContenido, 54] = "NO LIBERADO";//BB
                    }

                    celdaContenido++;
                }


                Lector.Close();
                nuevaConexion.Close();
            }

            //var style = GetStyleHeader(workbook);
            //excelApp.Range[excelApp.Cells[8, 1], excelApp.Cells[totalRegistrosExportar + 8, 16]].Style = style;

            worksheet.Range["A:BB"].Columns.AutoFit();



            //workbook.Close();
            //SaveFileDialog guarda = new SaveFileDialog();
            //guarda.Filter = "Libro de Excel|*.xlsx";
            //guarda.Title = "Guardar Reporte";
            //guarda.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if (guarda.ShowDialog() == DialogResult.OK)
            //{
            //    workbook.SaveAs(guarda.FileName);
            //    MessageBOX.SHowDialog(3, "Archivo Guardado");
            //}

            //string tempFile = System.IO.Path.GetTempFileName() + ".xls";
            //workbook.SaveAs(tempFile);

        }

    }
}
