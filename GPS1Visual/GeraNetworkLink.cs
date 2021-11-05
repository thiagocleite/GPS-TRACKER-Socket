using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace GPS1Visual
{
    class GeraNetworkLink
    {
        public void GeraKmlNetworkLink()
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.fastlock);
            con.Open();
            MySqlDataAdapter adap = new MySqlDataAdapter("select * from clientes", con);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            con.Close();
            StreamWriter nt = new StreamWriter(@"C:\inetpub\wwwroot\fastlockServer\rastreadores.kml", false, Encoding.Default);
            nt.WriteLine("<Document>");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                nt.WriteLine("<NetworkLink id=\"{0}\">",row["pnumero"].ToString());
                nt.WriteLine("<name>{0}</name>",row["pnumero"].ToString());
                nt.WriteLine("<flyToView>0</flyToView>");
                nt.WriteLine("<Link>");
                nt.WriteLine("<href>http://187.75.187.245/fastlockServer/KML/{0}.kml</href>",row["pnumero"].ToString());
                nt.WriteLine("<refreshMode>onInterval</refreshMode>");
                nt.WriteLine("<refreshInterval>15</refreshInterval>");
                nt.WriteLine("<viewRefreshMode>onStop</viewRefreshMode>");
                nt.WriteLine("<viewRefreshTime>7</viewRefreshTime>");
                nt.WriteLine(@"<viewFormat>BBOX=[bboxWest],[bboxSouth],[bboxEast],[bboxNorth];CAMERA=\");
                nt.WriteLine(@"[lookatLon],[lookatLat],[lookatRange],[lookatTilt],[lookatHeading];VIEW=\");
                nt.WriteLine("[horizFov],[vertFov],[horizPixels],[vertPixels],[terrainEnabled]</viewFormat>");
                nt.WriteLine("</Link>");
                nt.WriteLine("</NetworkLink>");
                nt.WriteLine("");
            }
            nt.WriteLine("</Document>");
            nt.Close();
        }
    }
}
