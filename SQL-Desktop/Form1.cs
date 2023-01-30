using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;
using System.Linq;
using System.Text;

namespace SQL_Desktop
{
    public partial class Form1 : Form
    {
        #region Start
        List<Query> queries;
        DataTable queryResult;
        public Form1()
        {
            InitializeComponent();
            queries = new List<Query>();
            cmboxExport.DataSource = cmboxExport.Items;
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
            queryResult = dt;

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
            switch (cmboxExport.Text)
            {
                case "HTML":
                    string table = "<table>";
                    string tr = "";
                    foreach (DataColumn col in queryResult.Columns) tr += "<th>" + col.ToString() + "</th>";
                    table += tr;
                    foreach (DataRow row in queryResult.Rows)
                    {
                        tr = "<tr>";
                        foreach (DataColumn col in queryResult.Columns)
                        {
                            string value = row[col.ToString()].ToString();
                            string th = $"<th>{value}</th>";
                            tr += th;
                        }
                        tr += "</tr>";
                        table += tr;
                    }
                    table += "</table>";
                    string defaultSettings = "<!DOCTYPE html>\r\n<html lang='it'>\r\n<head>\r\n<meta charset='UTF-8'>\r\n<style>\r\n@import url('https://fonts.googleapis.com/css2?family=Lexend&display=swap');\r\n\r\n* {\r\nmargin: 0px;\r\npadding: 0px;\r\nbox-sizing: border-box;\r\n}\r\n\r\nbody {\r\nfont-family: 'Lexend', sans-serif;\r\n}\r\n\r\ndiv {\r\nposition: absolute;\r\ntop: 50%;\r\nleft: 50%;\r\ntransform: translate(-50%, -50%);\r\n}\r\n\r\ntable {\r\nborder-collapse: collapse;\r\nmargin: 25px 0;\r\nfont-size: 0.9 rem;\r\nmin-width: 400px;\r\nbox-shadow: 0 0 20px rgba(0,0,0,0.15);\r\n}\r\n\r\ntd, tr, th {border: 1px solid black;\r\npadding: 10px 16px;\r\n}\r\n</style>\r\n<title>SQLite Database</title>\r\n</head>\r\n<body>\r\n<div>\r\n" + table + "\r\n</div>\r\n</body>\r\n</html>";
                    HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
                    html.LoadHtml(defaultSettings);

                    //Salvataggio file HTML
                    SaveFileDialog sfdHTML = new SaveFileDialog();
                    sfdHTML.Filter = "HTML Files|*.html";
                    sfdHTML.Title = "Scegli il percorso";
                    sfdHTML.FileName = "database";
                    if (sfdHTML.ShowDialog() == DialogResult.OK) html.Save(sfdHTML.FileName);
                    break;
                case "CSV":
                    //MessageBox.Show("Debug");
                    
                    string csv = "";

                    foreach (DataColumn col in queryResult.Columns) csv += col.ToString();
                    csv += "\r\n";
                    foreach (DataRow row in queryResult.Rows)
                    {
                        foreach (DataColumn col in queryResult.Columns)
                        {
                            string value = row[col.ToString()].ToString();
                            csv += $"{value},";
                        }
                        csv += ";\r\n";
                    }
                    csv += ";";

                    HtmlAgilityPack.HtmlDocument csvFILE = new HtmlAgilityPack.HtmlDocument();
                    csvFILE.LoadHtml(csv);

                    SaveFileDialog sfdCSV = new SaveFileDialog();
                    sfdCSV.Filter = "CSV Files|*.csv";
                    sfdCSV.Title = "Scegli il percorso";
                    sfdCSV.FileName = "database";
                    if (sfdCSV.ShowDialog() == DialogResult.OK) csvFILE.Save(sfdCSV.FileName);
                    break;
                    //foreach (DataColumn column in queryResult.Columns) csv += row. + ',';


                    //csv += "\r\n";


                    //foreach (DataRow row in dataGridViewDB.Rows)
                    //{
                    //    foreach (DataGridViewCell cell in row.Cells) csv += cell.Value.ToString().Replace(",", ";") + ',';
                    //    csv += "\r\n";
                    //}

                    //HtmlAgilityPack.HtmlDocument csvFile = new HtmlAgilityPack.HtmlDocument();
                    //SaveFileDialog sfdCSV = new SaveFileDialog();
                    //sfdCSV.Filter = "CSV Files|*.csv";
                    //sfdCSV.Title = "Scegli il percorso";
                    //sfdCSV.FileName = "database";
                    //if (sfdCSV.ShowDialog() == DialogResult.OK) csvFile.Save(sfdCSV.FileName);
                    break;
            }
        }
        #endregion
    }
}