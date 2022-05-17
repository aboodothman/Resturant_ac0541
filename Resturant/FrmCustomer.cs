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


namespace FrmDBProject.Costumers
{
    public partial class Frm_Customers : Form
    {
       /* private const string connString = "data source=ABOOD\\MSSQLSERVER01; initial catalog = architecture; persist securtiy info = True; Integrated Security = SSPI;";
        private static SqlConnection conn = new SqlConnection(connString);*/

        public Frm_Customers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool sucess = true;//عرفت المتغير اذا حققت ينفذ جملة الاضافة وغير ذلك لا

            txtUserName.Text = txtUserName.Text.Trim();// trimانها تحذف الفراغ  
            if (txtUserName.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("قم بتعبئة الحقول الفارغة");
                txtUserName.Focus();
            }
            if (txtUserName.Text.Length < 3)//تشيك على عدد الاحرف
            {
                errorProvider1.SetError(txtUserName, "اسم المستخدم قصير");
                sucess = false;

            }
            if (txtPassword.Text.Length < 3 || txtPassword.Text == "")//كلمة السر اقل من 5 او فارغة
            {
                errorProvider2.SetError(txtPassword, "كلمة مرور قصيرة");
                sucess = false;
            }
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text) || txtConfirmPassword.Text == "")//كلمة المرور غير متطابقة
            {
                errorProvider3.SetError(txtConfirmPassword, "كلمة المرور غير متطابقة ");
                sucess = false;
            }
            if (txt_Phone.Text.Length < 3 || txt_Phone.Text == "")
            {
                errorProvider4.SetError(txt_Phone, "");
                sucess = false;
            }
            if (sucess)//true
            {
                /*string Sql = "INSERT INTO [dbo].[Customers] ([Cus_name],[Cus_Password],[dOb],[Cus_phone],[Email],[Joining date],[Gender])) VALUES(";
                Sql += "'" + txtUserName.Text + "',";
                Sql += "'" + txtPassword.Text + "',";
                Sql += "'" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "/" + dateTimePicker1.Value.Year + "',";                
                Sql += "'" + txt_Phone.Text + "',";
                Sql += "'" + txt_Email.Text + "',";
                Sql += "'" + Lbl_JoiningDate.Text + "',";
                Sql += ((rdMale.Checked) ? 1 : 0) + ")";*/


                MessageBox.Show("تم الحفظ ", "Mession", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleareControls();
                
                
            }
            else
            {
                DialogResult result = MessageBox.Show("فشل في عملية الحفظ", "Mession", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void CleareControls()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txt_Phone.Text = "";
            rdMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            Lbl_JoiningDate.Text = "Time: " + DateTime.Now.ToString();
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            Lbl_JoiningDate.Text = "Time: " + DateTime.Now.ToString("");

            /*string Sql = ("Select * From city");
            SqlDataAdapter Da = new SqlDataAdapter(Sql, conn);
            DataTable dt = new DataTable();
            Da.Fill(dt);*/
            //combo_City.DataSource = dt;
            combo_City.DisplayMember = "cityname";
            combo_City.ValueMember = "cityid";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
