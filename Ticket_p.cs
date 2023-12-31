using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Ticket_p
    {
        public Ticket_p(string cleinte, string rev, string F_Re, string f_in, string f_out, string desc, string tot) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = rev + cleinte + ".pdf";
            sfd.Filter = "PDF Files|*.pdf";
            string relleno = Properties.Resources.plantilla_comprobate.ToString();
            relleno = relleno.Replace("@CLIEIT", cleinte);
            relleno = relleno.Replace("@RESERVAID", rev);
            relleno = relleno.Replace("@FRES", F_Re);
            relleno = relleno.Replace("@SDFA", f_in);
            relleno = relleno.Replace("@FSAL", f_out);
            relleno = relleno.Replace("@DESC", desc + "%");
            relleno = relleno.Replace("@TOT", tot);
            Reservacion_Clase resca = new Reservacion_Clase();
            resca.Habitacion_Ocupadas_dt(rev);
            string agua = "";
                foreach(DataRow actual in resca.re.Rows)
                {
                agua = agua + "<tr>";
                agua = agua + "<td>" + actual.Field<string>(0) + "</td>";
                agua = agua + "<td>" + actual.Field<decimal>(1).ToString() + "</td>";
                agua = agua + "</tr>";
                }
            relleno = relleno.Replace("@MSDFOIDSG", agua);
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream tira = new FileStream(sfd.FileName, FileMode.Create)) 
                {
                    Document doc = new Document(PageSize.A5);
                    PdfWriter escriba = PdfWriter.GetInstance(doc, tira);
                    doc.Open();
                    using (StringReader sr = new StringReader(relleno))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(escriba, doc, sr);

                    }
                    doc.Close();
                    tira.Close();
                }
            }
             
        }
        
    }
}
