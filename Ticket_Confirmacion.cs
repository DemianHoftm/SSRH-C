using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Ticket_Confirmacion
    {
        public Ticket_Confirmacion(DataRow miuna) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = miuna.Field<string>(3) + ".pdf";
            sfd.Filter = "PDF Files|*.pdf";
            string relleno = Properties.Resources.plantilla_ticket.ToString();
            relleno = relleno.Replace("@CLIENTE", miuna.Field<string>(3));
            relleno = relleno.Replace("@RESR", miuna.Field<string>(2));
            relleno = relleno.Replace("@IDPAG", miuna.Field<string>(0));
            relleno = relleno.Replace("@TOTIM", miuna.Field<Decimal>(1).ToString());
            relleno = relleno.Replace("@FECH", DateTime.Now.ToString());
            Reservacion_Clase resca = new Reservacion_Clase();
            

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
