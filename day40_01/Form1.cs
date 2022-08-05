using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day40_01
{
    public partial class Form1 : Form
    {
        int NewNid = int.Parse(DateTime.Now.ToString("MMddhhmm"));
        int NewInvoice = int.Parse(DateTime.Now.ToString("ddhhmmss"));
        int NewNidn = 0;
        SqlConnection conn;
        SqlDataAdapter SDA_People, SDA_Fruit;
        DataSet Dset;
        SqlCommandBuilder SCB_People, SCB_Fruit;

        string connString = "server = .\\SQLEXPRESS; database = test; uid = sa; password = alencia;";

        private void Form1_Load(object sender, EventArgs e)
        {
            Initcmd();
        }

        private void TB01_BTN_Input_Click(object sender, EventArgs e)
        {
            DataRow NewRow = Dset.Tables["testTable02"].NewRow();
            NewRow["Nid"] = NewNid * 10 + NewNidn++;
            NewRow["Name"] = INPUT_Name.Text;
            NewRow["Age"] = int.Parse(INPUT_Age.Text);
            Dset.Tables[0].Rows.Add(NewRow);

            SDA_People.Update(Dset, "testTable02");
            Dset.Clear();
            SDA_People.Fill(Dset, "testTable02");
            SDA_Fruit.Fill(Dset, "testTable03");
            DGVShow();
        }

        private void TB01_BTN_Delete_Click(object sender, EventArgs e)
        {
            int temp = (int)dataGridView1.CurrentRow.Cells["Nid"].Value;
            string selectNid = "Nid = " + temp;

            DataRow[] Find_TB02 = Dset.Tables["testTable02"].Select(selectNid);
            DataRow[] Find_TB03 = Find_TB02[0].GetChildRows("testTable02_testTable03");
            if(Find_TB03.Length > 0)
            {
                foreach(DataRow row in Find_TB03)
                {
                    row.Delete();
                }
            }
            Find_TB02[0].Delete();

            SDA_Fruit.Update(Dset, "testTable03"); // 종속관계를 갖는 테이블을 먼저 업데이트, 삭제한다.
            SDA_People.Update(Dset, "testTable02");

            DGVShow();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void TB01_BTN_Update_Click(object sender, EventArgs e)
        {
            int temp = (int)dataGridView1.CurrentRow.Cells["Nid"].Value;
            string selectNid = "Nid = " + temp;

            DataRow[] FindRow = Dset.Tables["testTable02"].Select(selectNid);
            FindRow[0]["Name"] = INPUT_Name.Text;
            FindRow[0]["Age"] = int.Parse(INPUT_Age.Text);

            SDA_People.Update(Dset, "testTable02");
            DGVShow();
        }

        private void TB02_BTN_Input_Click(object sender, EventArgs e)
        {
            DataRow NewRow = Dset.Tables["testTable03"].NewRow();
            NewRow["ORDER_NO"] = NewInvoice;
            NewRow["ORDER_Nid"] = int.Parse(INPUT_Nid.Text);
            NewRow["Fruit_Name"] = INPUT_Fruit.Text;
            NewRow["Num"] = int.Parse(INPUT_Num.Text);
            Dset.Tables["testTable03"].Rows.Add(NewRow);

            SDA_Fruit.Update(Dset, "testTable03");
            Dset.Tables["testTable03"].Clear();
            SDA_Fruit.Fill(Dset, "testTable03");
            DGVShow();
        }

        private void TB02_BTN_Delete_Click(object sender, EventArgs e)
        {
            int temp = (int)dataGridView2.CurrentRow.Cells["ORDER_NO"].Value;
            string selectNid = "ORDER_NO = " + temp;

            DataRow[] Find_TB03 = Dset.Tables["testTable03"].Select(selectNid);
            Find_TB03[0].Delete();

            SDA_Fruit.Update(Dset, "testTable03");
            DGVShow();
        }

        private void TB02_BTN_Update_Click(object sender, EventArgs e)
        {
            int temp = (int)dataGridView2.CurrentRow.Cells["ORDER_NO"].Value;
            string selectNid = "ORDER_NO = " + temp;

            DataRow[] Find_TB03 = Dset.Tables["testTable03"].Select(selectNid);
            if(!string.IsNullOrEmpty(INPUT_Fruit.Text))Find_TB03[0]["Fruit_Name"] = INPUT_Fruit.Text;
            if (!string.IsNullOrEmpty(INPUT_Num.Text)) Find_TB03[0]["Num"] = int.Parse(INPUT_Num.Text);
            SDA_Fruit.Update(Dset, "testTable03");
            DGVShow();
        }

        private void TB01_BTN_Show_Click(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder();
            int temp = (int)dataGridView1.CurrentRow.Cells["Nid"].Value;
            string selectNid = "Nid = " + temp;

            DataRow[] Find_TB02 = Dset.Tables["testTable02"].Select(selectNid);
            DataRow[] Find_TB03 = Find_TB02[0].GetChildRows("testTable02_testTable03");
            if (Find_TB03.Length > 0)
            {
                foreach (DataRow row in Find_TB03)
                {
                   SB.Append(row["Fruit_Name"].ToString() +"   " + row["Num"] + "개 \n");
                }
                MessageBox.Show(SB.ToString(), "Invoice");
            }
        }

        private void Initcmd()
        {
            conn = new SqlConnection(connString);
            SDA_People = new SqlDataAdapter("SELECT * FROM testTable02", conn);
            SDA_Fruit = new SqlDataAdapter("SELECT * FROM testTable03", conn);
            Dset = new DataSet();

            SCB_People = new SqlCommandBuilder(SDA_People);
            SCB_Fruit = new SqlCommandBuilder(SDA_Fruit);

            SDA_People.Fill(Dset, "testTable02");
            SDA_Fruit.Fill(Dset, "testTable03");

            //relation 설정
            DataRelation relationD = new DataRelation("testTable02_testTable03", Dset.Tables["testTable02"].Columns["Nid"], Dset.Tables["testTable03"].Columns["ORDER_Nid"]);

            Dset.Relations.Add(relationD);
            DGVShow();
        }

        private void DGVShow()
        {
            dataGridView1.DataSource = Dset.Tables["testTable02"];
            dataGridView2.DataSource = Dset.Tables["testTable03"];
        }
    }
}
