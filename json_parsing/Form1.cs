using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace json_parsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            товар tovar1 = new товар(10, "Стол", 4500);
            this.label1.Text = string.Format("код={0}" +
                            "\n наименование={1} " +
                            "\n цена = {2}", tovar1.код, tovar1.наименование, tovar1.цена);

            System.Runtime.Serialization.Json.DataContractJsonSerializer ps = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(товар));
            System.IO.Stream память = new System.IO.MemoryStream();
            ps.WriteObject(память, tovar1);
            память.Position = 0;
            System.IO.StreamReader чтение_из_памяти = new System.IO.StreamReader(память);
            string s = чтение_из_памяти.ReadToEnd();
            this.textBox1.Text = s;

            // Десериализация строки в объект
            string s1
           = "{\"код\":11,\"наименование\":\"Стул\",\"цена\":500}";
            System.IO.Stream поток = new System.IO.MemoryStream(Encoding.UTF8
           .GetBytes(s1));
            this.label1.Text += string.Format("\n n={0}", поток.Length);
            товар tov2 = (товар)ps.ReadObject(поток);
            this.label1.Text += string.Format("\n код={0}\n наименование={1} \n цена ={2}", tov2.код, tov2.наименование, tov2.цена);

        }
    }
}
