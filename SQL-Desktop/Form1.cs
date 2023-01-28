using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SQL_Desktop
{
    public partial class Form1 : Form
    {
        #region Start
        List<Query> queries;
        string defaultSettings = "<!DOCTYPE html>\r\n<html lang='it'>\r\n<head>\r\n<meta charset='UTF-8'>\r\n<title>SQLite Database</title>\r\n</head>\r\n<body>\r\n\r\n</body>\r\n</html>";
        public Form1()
        {
            InitializeComponent();
            queries = new List<Query>();
            if (!File.Exists("default.html"))
            {
                StreamWriter sr = new StreamWriter("default.html");
                sr.WriteLine(defaultSettings);
                sr.Close();
            }
        }
        #endregion

        #region Seleziona il DB
        private void btnPathDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File SQL (*.db)|*.db";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK) txtPathDB.Text = openFileDialog.FileName;
        }
        #endregion

        #region Seleziona le Query
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
        #endregion

        #region Esegue le Query prendendo come DB il file selezionato dall'utente
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
        #endregion

        #region Metodo per dare determinati parametri a certe query
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
        #endregion

        #region Decodifica la lista delle Query
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
        #endregion

        #region Aggiorna la Text Box quando viene scelta un'altra query
        private void cmboxQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = (Query)cmboxQuery.SelectedItem;
            if (query != null) { txtSQL.Text = query.Content; }
        }
        #endregion

        #region Esporta il DB come file HTML
        private void btnExport_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "HTML Files|*.html";
            sd.Title = "Scegli il percorso";
            sd.FileName = "Database";
            if (sd.ShowDialog() == DialogResult.OK) html.Save(sd.FileName);
            //html.LoadHtml(...);
        }
        #endregion
    }
}