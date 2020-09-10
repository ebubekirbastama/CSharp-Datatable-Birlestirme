using System;
using System.Data;
using System.Windows.Forms;

//EBS SEcurty By& Ebubekir Bastama 
//İletişim: 05554128854
namespace TableBirlestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dt1.Rows.Add(dt2.Rows[i].ItemArray[0], dt2.Rows[i].ItemArray[1], dt2.Rows[i].ItemArray[2], dt2.Rows[i].ItemArray[3], dt2.Rows[i].ItemArray[4]);
            }
            dataGridView1.DataSource = dt1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dt1.Columns.Add("veri1");
            dt1.Columns.Add("veri2");
            dt1.Columns.Add("veri3");
            dt1.Columns.Add("veri4");
            dt1.Columns.Add("veri5");
            for (int i = 0; i < 15; i++)
            {
                dt1.Rows.Add(i+" veri",i+" veri", i + " veri", i + " veri", i + " veri");
            }
            dt2.Columns.Add("ebs securty");
            dt2.Columns.Add("ebs securty1");
            dt2.Columns.Add("ebs securty3");
            dt2.Columns.Add("ebs securty4");
            dt2.Columns.Add("ebs securty5");
            for (int i = 0; i < 25; i++)
            {
                dt2.Rows.Add(i + " ebs securty", i + " ebs securty", i + " ebs securty", i + " ebs securty", i + " ebs securty");
            }

        }
    }
}
