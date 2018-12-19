using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WarnasRecommender
{
    public class WeightedProducts
    {
        Weightval wvin =new Weightval();
        DataTable dtin = new DataTable();
        DataTable dtO = new DataTable();
        DataTable dtU = new DataTable();

        public double Total; 
        double weightsum, vsSum;
        double vs1=0, vs2=0, vs3=0,vs4=0,vv1, vv2, vv3, vv4;

        public  WeightedProducts(Weightval owo, DataTable uwu)
        {
            wvin = owo;
            dtO = uwu.Copy();
            dtin = uwu;
           
          
            normalize();
            findVectorS();
            findVectorV();
        }

        public DataTable getWPresult()
        {
            return dtin;
        }
        public DataTable getTableforUser()
        {
            int i;
            double uwu =0;
            dtU.Columns.Add("Nama Warung", typeof(String));
            dtU.Columns.Add("Skor Vector V", typeof(String));
            dtU.Rows.Add();

            for (i = 0; i <= dtin.Rows.Count - 1; i++)
            {
                uwu = double.Parse(dtin.Rows[i][7].ToString());

                dtU.Rows.Add(dtin.Rows[i][0], Math.Round(uwu, 3).ToString("#0.##%")        );
            }
            DataView dv = dtU.DefaultView;
            dv.Sort = "Skor Vector V DESC";
            DataTable sortedDT = dv.ToTable();
            dtU.DefaultView.Sort = "Skor Vector V ";
//            dtU = dtU.DefaultView.ToTable();
            return sortedDT;
        }
        public DataTable getOriTable()
        {
            return dtO;
        }
        public DataTable getCompleteTable()
        {
            DataTable ultraComplete= new DataTable();
            int i; double uwu;

            ultraComplete.Columns.Add("Nama Warung", typeof(String));
            ultraComplete.Columns.Add("Kualitas Makanan", typeof(double));
            ultraComplete.Columns.Add("Harga Makanan", typeof(double));
            ultraComplete.Columns.Add("Pelayanan Warung", typeof(double));
            ultraComplete.Columns.Add("Suasana Warung", typeof(double));
            ultraComplete.Columns.Add("Jarak rumah ke Warung (M)", typeof(double));
            ultraComplete.Columns.Add("Vector S", typeof(double));
            ultraComplete.Columns.Add("Vector V", typeof(double));
            ultraComplete.Columns.Add("Skor Vector V", typeof(String));

            for (i = 0; i <= dtin.Rows.Count - 1; i++)
            {
                uwu = double.Parse(dtin.Rows[i][7].ToString());

                // add nama 0 kualitas 1 harga 2 pelayanan 3 suasana 4 jarak rumah 5 vector s 6 vector v 7
                ultraComplete.Rows.Add(dtO.Rows[i][0], dtO.Rows[i][1], dtO.Rows[i][2], dtO.Rows[i][3], dtO.Rows[i][4], dtO.Rows[i][5], dtin.Rows[i][6], dtin.Rows[i][7], Math.Round(uwu, 3).ToString("#0.##%"));
            }
            DataView dv2 = ultraComplete.DefaultView;
            dv2.Sort = "Skor Vector V DESC";
            DataTable sortedDT = dv2.ToTable();
            
            //            dtU = dtU.DefaultView.ToTable();
            return sortedDT;
           
        }
        public Weightval getNormalresult()
        {
            return wvin;
        }
        public double getWeightSum()
        {
            return weightsum;
        }
        public double getSV1()
        {
            return vs1;
        }

        public int getCol()
        {
            int i = 0;
            foreach (DataColumn col in dtin.Columns)
            {
                i++;
            }
            return i;
        }

        public void normalize()
        {
            weightsum=wvin.hargaweight     +
                          wvin.jarakweight     +
                          wvin.Kualitasweight  +
                          wvin.pelayananweight +
                          wvin.suasanaweight;

            wvin.hargaweight     =  wvin.hargaweight / weightsum;
            wvin.jarakweight     =  wvin.jarakweight / weightsum;
            wvin.Kualitasweight  =  wvin.Kualitasweight / weightsum;
            wvin.pelayananweight =  wvin.pelayananweight / weightsum;
            wvin.suasanaweight   =  wvin.suasanaweight / weightsum;
        }

        public void findVectorS()
        {
            int i = 0;
            
            for (i = 0; i <= dtin.Rows.Count - 1; i++)
            {
                dtin.Rows[i][1] = Math.Pow(Convert.ToDouble(dtin.Rows[i][1]), wvin.Kualitasweight);
                dtin.Rows[i][2] = Math.Pow(Convert.ToDouble(dtin.Rows[i][2]), -wvin.hargaweight);
                dtin.Rows[i][3] = Math.Pow(Convert.ToDouble(dtin.Rows[i][3]), wvin.pelayananweight);
                dtin.Rows[i][4] = Math.Pow(Convert.ToDouble(dtin.Rows[i][4]), wvin.suasanaweight);
                dtin.Rows[i][5] = Math.Pow(Convert.ToDouble(dtin.Rows[i][5]), -wvin.jarakweight);
            }
            vs1 = Convert.ToDouble(dtin.Rows[0][1]) * Convert.ToDouble(dtin.Rows[0][2]) * Convert.ToDouble(dtin.Rows[0][3]) * Convert.ToDouble(dtin.Rows[0][4]) * Convert.ToDouble(dtin.Rows[0][5]);
            vs2 = Convert.ToDouble(dtin.Rows[1][1]) * Convert.ToDouble(dtin.Rows[1][2]) * Convert.ToDouble(dtin.Rows[1][3]) * Convert.ToDouble(dtin.Rows[1][4]) * Convert.ToDouble(dtin.Rows[1][5]);
            vs3 = Convert.ToDouble(dtin.Rows[2][1]) * Convert.ToDouble(dtin.Rows[2][2]) * Convert.ToDouble(dtin.Rows[2][3]) * Convert.ToDouble(dtin.Rows[2][4]) * Convert.ToDouble(dtin.Rows[2][5]);
            vs4 = Convert.ToDouble(dtin.Rows[3][1]) * Convert.ToDouble(dtin.Rows[3][2]) * Convert.ToDouble(dtin.Rows[3][3]) * Convert.ToDouble(dtin.Rows[3][4]) * Convert.ToDouble(dtin.Rows[3][5]);

            dtin.Columns.Add("Vector S", typeof(double));
            dtin.Rows[0][6] = vs1;
            dtin.Rows[1][6] = vs2;
            dtin.Rows[2][6] = vs3;
            dtin.Rows[3][6] = vs4;
        }
        public void findVectorV()
        {

            vsSum = vs1 + vs2 + vs3 + vs4;

            vv1 = vs1 / vsSum;
            vv2 = vs2 / vsSum;
            vv3 = vs3 / vsSum;
            vv4 = vs4 / vsSum;


            dtin.Columns.Add("Vector V", typeof(double));
            dtin.Rows[0][7] = vv1;
            dtin.Rows[1][7] = vv2;
            dtin.Rows[2][7] = vv3;
            dtin.Rows[3][7] = vv4;
        }


    }
}
