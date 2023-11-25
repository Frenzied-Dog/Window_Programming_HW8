using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw8_11_24 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.屬性_克制屬性_被克制屬性' 資料表。您可以視需要進行移動或移除。
            this.屬性_克制屬性_被克制屬性TableAdapter.Fill(this.database1DataSet.屬性_克制屬性_被克制屬性);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.屬性_克制屬性_被克制屬性' 資料表。您可以視需要進行移動或移除。
            this.屬性_克制屬性_被克制屬性TableAdapter.Fill(this.database1DataSet.屬性_克制屬性_被克制屬性);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.寶可夢_招式' 資料表。您可以視需要進行移動或移除。
            this.寶可夢_招式TableAdapter.Fill(this.database1DataSet.寶可夢_招式);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.招式_屬性_威力' 資料表。您可以視需要進行移動或移除。
            this.招式_屬性_威力TableAdapter.Fill(this.database1DataSet.招式_屬性_威力);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
