using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Imaging;
using iTextSharp.tool.xml;
using System.Globalization;
using iTextSharp.tool.xml.html.head;

namespace SRRH
{
    public partial class Reporte : Form
    {
        public Chart grafica;
        public Reporte()
        {
            InitializeComponent();
            grafica = new Chart();
            grafica.ChartAreas.Add(new ChartArea());


            this.stratup();
        }
        public void stratup()
        {
            condicion.SelectedIndex = 0;
            parametro.SelectedIndex = 0;
            fecha.SelectedIndex = 0;
        }

        public void Pie(string[] serie, double[] dato, string titut, string leyend, bool tipe)
        {
            Chart torta = new Chart();
            torta.ChartAreas.Add(new ChartArea("PieArea"));
            torta.Titles.Add(titut);
            torta.Legends.Add(new Legend(leyend));//agregar la leyenda


            Series seen = new Series
            {
                Name = "Parametros",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            for (int i = 0; i < serie.Length; i++)
            {
                seen.Points.AddXY(serie[i], dato[i]);
                // seen.Points[i].Label = dat[i].ToString();
                seen.Points[i].LegendText = serie[i]; //agregar los textos de la leyenda
            }
            if (tipe) seen.Label = "#PERCENT";
            //para que esto funcione no se debe añadir labels una por una
            seen.Palette = ChartColorPalette.EarthTones;
            seen["PieLabelStyle"] = "Outside";
            torta.Series.Add(seen);

            torta.SaveImage("C:/Users/Administrator/source/repos/SRRH/Resources/graf.jpg", ImageFormat.Jpeg);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = ".pdf";
            sfd.Filter = "PDF Files|*.pdf";

            //agrego la configuracion html
            string relleno = Properties.Resources.cabecera.ToString();

            //configuracion html del pie
            string gato = Properties.Resources.pie.ToString();
            //esto es para sustituir 
            gato = gato.Replace("@DSFGFACHE", DateTime.Now.ToShortDateString());


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream tira = new FileStream(sfd.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A5);
                    PdfWriter escriba = PdfWriter.GetInstance(doc, tira);
                    doc.Open();
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_transparent, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(doc.LeftMargin, doc.Top - 60);
                    doc.Add(img);
                    using (StringReader sr = new StringReader(relleno))
                    {
                        //lo combierto a un doc
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }
                    Bitmap aux = new Bitmap("C:/Users/Administrator/source/repos/SRRH/Resources/graf.jpg");
                    iTextSharp.text.Image graf = iTextSharp.text.Image.GetInstance(aux, System.Drawing.Imaging.ImageFormat.Png);
                    graf.ScaleToFit(290, 280);
                    doc.Add(graf);
                    using (StringReader sr = new StringReader(gato))
                    {
                        //lo combierto a un doc
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }
                    doc.Close();
                    
                    tira.Close();
                    
                }
            }
        }

        public void Barras(string[] serie, double[] datos, string titulo)
        {
            //
            grafica.Palette = ChartColorPalette.Excel;
            grafica.Titles.Add(titulo);

            //
            Series seen = new Series();
            for (int i = 0; i < serie.Length; i++)
            {
                seen.Points.AddXY(serie[i], datos[i]);
                seen.Points[i].Label = datos[i].ToString();

            }
            // seen.Label = "#PERCENT"; este muestra el porcentaje
            seen.ChartType = SeriesChartType.Column;
            seen.Palette = ChartColorPalette.EarthTones;
            seen["PieLabelStyle"] = "Outside";
            grafica.Series.Add(seen);
            grafica.SaveImage("C:/Users/Administrator/source/repos/SRRH/Resources/graf.jpg", ImageFormat.Jpeg);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = ".pdf";
            sfd.Filter = "PDF Files|*.pdf";

            //agrego la configuracion html
            string relleno = Properties.Resources.cabecera.ToString();

            //configuracion html del pie
            string gato = Properties.Resources.pie.ToString();
            //esto es para sustituir 
            gato = gato.Replace("@DSFGFACHE", DateTime.Now.ToShortDateString());


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream tira = new FileStream(sfd.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A5);
                    PdfWriter escriba = PdfWriter.GetInstance(doc, tira);
                    doc.Open();
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_transparent, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(doc.LeftMargin, doc.Top - 60);
                    doc.Add(img);
                    using (StringReader sr = new StringReader(relleno))
                    {
                        //lo combierto a un doc
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }
                    Bitmap aux = new Bitmap("C:/Users/Administrator/source/repos/SRRH/Resources/graf.jpg");
                    iTextSharp.text.Image graf = iTextSharp.text.Image.GetInstance(aux, System.Drawing.Imaging.ImageFormat.Png);
                    graf.ScaleToFit(290, 280);
                    doc.Add(graf);
                    using (StringReader sr = new StringReader(gato))
                    {
                        //lo combierto a un doc
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }
                    doc.Close();
                    tira.Close();
                    grafica.ChartAreas.Clear();
                }
            }

        }

        private void generar_btn_Click(object sender, EventArgs e)
        {
            BoxMessage mensaje = new BoxMessage();
            mensaje.Aviso_arriba.Text = "Seleccion invalida";
            mensaje.Cuerpo_men.Text = "Debe seleccionar al menos una condicion y el año";
            mensaje.si.Visible = false;
            mensaje.no.Text = "Ok";
            if ((condicion.SelectedIndex == 0) || (fecha.SelectedIndex == 0))
            {
                mensaje.ShowDialog();
                return;
            }
            string auxiliarstr = condicion.SelectedIndex.ToString() + parametro.SelectedIndex.ToString();
            int aux = Convert.ToInt32(auxiliarstr);
            mensaje.Cuerpo_men.Text = "Combinacion invalida";
            switch (aux)
            {

                case 11: //grafica 2

                    string[] hab = new string[] { "Individual Deluxe", "Individual", "Matrimonial",
                        "Estandar", "Individual Doble", "Familiar" };
                    double[] ing = new double[] { 300, 90, 78, 70, 340, 500 };
                    this.Pie(hab, ing, "Ingreso por tipo de habitacion", "Tipo de habitacion", false);
                    this.stratup();
                    break;
                case 12: //grafica 6
                    string[] au = new string[] { "Venezolano", "Extranjero", "judirico" };
                    double[] dat = new double[] { 23000, 1900, 7870 };
                    this.Pie(au, dat, "Ingreso por tipo de cliente", "Tipo de cliente", true);
                    this.stratup();
                    break;
                case 13: //grafica 1
                    Pago_Clase paga = new Pago_Clase();
                    paga.Get_ingreso_Anual(fecha.SelectedItem.ToString());
                    string[] serie = new string[paga.pagoDT.Rows.Count];
                    double[] datos = new double[paga.pagoDT.Rows.Count];
                    int i = 0;
                    foreach (DataRow actual in paga.pagoDT.Rows)
                    {
                        serie[i] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(actual.Field<int>(0)));
                        datos[i] = (double)actual.Field<decimal>(1);
                        i = i + 1;
                    }
                    string titulo = "Ingresos mensuales del año " + fecha.SelectedItem.ToString();
                    this.Barras(serie, datos, titulo);
                    this.stratup();
                    break;
                case 22: //grafica 3
                    this.report3();
                    this.stratup();
                    break;
                case 30: //grafica 4
                    Reservacion_Clase okup = new Reservacion_Clase();
                    okup.Get_huespedes(fecha.SelectedItem.ToString());
                    string[] seriesn = new string[okup.re.Rows.Count];
                    double[] datoss = new double[okup.re.Rows.Count];
                    int j = 0;
                    foreach (DataRow actual in okup.re.Rows)
                    {
                        seriesn[j] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(actual.Field<int>(0)));
                        datoss[j] = (double)actual.Field<int>(1);
                        j = j + 1;
                    }
                    string titulo2 = "Promedio de huespedes del año " + fecha.SelectedItem.ToString();
                    this.Barras(seriesn, datoss, titulo2);
                    this.stratup();
                    break;

                case 40: //grafica 5
                    Reservacion_Clase VamosMariaC = new Reservacion_Clase();
                    VamosMariaC.Get_dias(fecha.SelectedItem.ToString());
                    string[] milei = new string[VamosMariaC.re.Rows.Count];
                    double[] presi = new double[VamosMariaC.re.Rows.Count];
                    int kk = 0;
                    foreach (DataRow actual in VamosMariaC.re.Rows)
                    {
                        milei[kk] = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(actual.Field<int>(0)));
                        presi[kk] = (double)actual.Field<int>(1);
                        kk = kk + 1;
                    }
                    string Libertad = "Promedio de dias reservados del año " + fecha.SelectedItem.ToString();
                    this.Barras(milei, presi, Libertad);
                    this.stratup();
                    break;
                default:
                    mensaje.ShowDialog();
                    break;
            }
        }

        public void report3()
        {
            //agrego la configuracion html
            string relleno = Properties.Resources.cabecera.ToString();

            //configuracion html del pie
            string gato = Properties.Resources.pie.ToString();
            //esto es para sustituir 
            gato = gato.Replace("@DSFGFACHE", DateTime.Now.ToShortDateString());
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = ".pdf";
            sfd.Filter = "PDF Files|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream tira = new FileStream(sfd.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A5);
                    PdfWriter escriba = PdfWriter.GetInstance(doc, tira);
                    doc.Open();
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_transparent, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(doc.LeftMargin, doc.Top - 60);
                    doc.Add(img);
                    using (StringReader sr = new StringReader(relleno))
                    {
                        //lo combierto a un doc
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }

                    iTextSharp.text.Image aux = iTextSharp.text.Image.GetInstance(Properties.Resources.Cantidad_de_clientes_en_un_año, System.Drawing.Imaging.ImageFormat.Png);
                    aux.ScaleToFit(290, 280);
                    doc.Add(aux);
                    using (StringReader sr = new StringReader(gato))
                    {
                        //lo combierto a un doc
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }
                    doc.Close();
                    tira.Close();
                }
            }




        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}
