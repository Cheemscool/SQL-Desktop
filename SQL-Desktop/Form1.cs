using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace SQL_Desktop
{
    public partial class Form1 : Form
    {
        List<Query> queries;
        public Form1()
        {
            InitializeComponent();
            queries = new List<Query>();
        }

        private void btnPathDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File SQL (*.db)|*.db";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) txtPathDB.Text = openFileDialog.FileName;
        }

        private void btnPathQuery_Click(object sender, EventArgs e)
        {
            string file;
            OpenFileDialog opDialog = new OpenFileDialog();
            opDialog.Filter = "File di testo (*.txt)|*.txt";

            DialogResult dialogResult = opDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) txtQueryPath.Text = opDialog.FileName;

            try
            {
                StreamReader sr = new StreamReader(txtQueryPath.Text);
                file = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            queries = DecodeFile(file);

            cmboxQuery.DataSource = null;
            cmboxQuery.Items.Clear();

            cmboxQuery.DataSource = queries;

            cmboxQuery.DisplayMember = "Title";
            cmboxQuery.ValueMember = "Content";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source={txtPathDB.Text};Version=3", queryContent = txtSQL.Text;

            queryContent = ApplyPar(queryContent);

            DataTable dt = new DataTable();

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(queryContent, connectionString);

            try
            {
                dataAdapter.Fill(dt);
                dataGridViewDB.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string ApplyPar(string input)
        {
            if (txtFirstPar.Text != "") input = input.Replace("//P1//", txtFirstPar.Text);
            if (txtSecondPar.Text != "") input = input.Replace("//P2//", txtSecondPar.Text);
            if (txtThirdPar.Text != "") input = input.Replace("//P3//", txtThirdPar.Text);
            if (txtFourthPar.Text != "") input = input.Replace("//P4//", txtFourthPar.Text);
            if (txtFifthPar.Text != "") input = input.Replace("//P5//", txtFifthPar.Text);
            if (txtSixthPar.Text != "") input = input.Replace("//P6//", txtSixthPar.Text);

            return input;
        }

        private List<Query> DecodeFile(string input)
        {
            List<Query> output = new List<Query>();
            string[] contentSplitted = input.Split('>'), rowSplitted;
            string content, title;

            foreach (string queryString in contentSplitted)
            {
                if (queryString == "") continue;

                content = "";

                rowSplitted = queryString.Split("\r\n");

                title = rowSplitted[0];

                content = string.Join(" ", rowSplitted.Skip(1));

                Query q = new Query(title, content.Trim());
                output.Add(q);
            }
            return output;
        }

        private void cmboxQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = (Query)cmboxQuery.SelectedItem;
            if (query != null) { txtSQL.Text = query.Content; }
        }
    }
 }