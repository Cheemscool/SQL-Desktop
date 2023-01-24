namespace SQL_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPathDB = new System.Windows.Forms.Label();
            this.lblQueryPath = new System.Windows.Forms.Label();
            this.lblSelectQuery = new System.Windows.Forms.Label();
            this.txtPathDB = new System.Windows.Forms.TextBox();
            this.txtQueryPath = new System.Windows.Forms.TextBox();
            this.cmboxQuery = new System.Windows.Forms.ComboBox();
            this.btnPathDb = new System.Windows.Forms.Button();
            this.btnQueryPath = new System.Windows.Forms.Button();
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.lblSQL = new System.Windows.Forms.Label();
            this.txtFirstPar = new System.Windows.Forms.TextBox();
            this.lblFirstPar = new System.Windows.Forms.Label();
            this.lblParameters = new System.Windows.Forms.Label();
            this.txtSecondPar = new System.Windows.Forms.TextBox();
            this.lblSecondPar = new System.Windows.Forms.Label();
            this.txtFourthPar = new System.Windows.Forms.TextBox();
            this.lblFourthPar = new System.Windows.Forms.Label();
            this.txtThirdPar = new System.Windows.Forms.TextBox();
            this.lblThirsPar = new System.Windows.Forms.Label();
            this.txtSixthPar = new System.Windows.Forms.TextBox();
            this.lblSixthPar = new System.Windows.Forms.Label();
            this.txtFifthPar = new System.Windows.Forms.TextBox();
            this.lblFifthPar = new System.Windows.Forms.Label();
            this.lblExport = new System.Windows.Forms.Label();
            this.cmboxExport = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SQL Desktop";
            // 
            // lblPathDB
            // 
            this.lblPathDB.AutoSize = true;
            this.lblPathDB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPathDB.Location = new System.Drawing.Point(39, 77);
            this.lblPathDB.Name = "lblPathDB";
            this.lblPathDB.Size = new System.Drawing.Size(129, 23);
            this.lblPathDB.TabIndex = 1;
            this.lblPathDB.Text = "Percorso DB:";
            // 
            // lblQueryPath
            // 
            this.lblQueryPath.AutoSize = true;
            this.lblQueryPath.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQueryPath.Location = new System.Drawing.Point(39, 108);
            this.lblQueryPath.Name = "lblQueryPath";
            this.lblQueryPath.Size = new System.Drawing.Size(156, 23);
            this.lblQueryPath.TabIndex = 2;
            this.lblQueryPath.Text = "Percorso Query:";
            // 
            // lblSelectQuery
            // 
            this.lblSelectQuery.AutoSize = true;
            this.lblSelectQuery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectQuery.Location = new System.Drawing.Point(39, 139);
            this.lblSelectQuery.Name = "lblSelectQuery";
            this.lblSelectQuery.Size = new System.Drawing.Size(70, 23);
            this.lblSelectQuery.TabIndex = 3;
            this.lblSelectQuery.Text = "Query:";
            // 
            // txtPathDB
            // 
            this.txtPathDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPathDB.Location = new System.Drawing.Point(228, 77);
            this.txtPathDB.Name = "txtPathDB";
            this.txtPathDB.Size = new System.Drawing.Size(203, 25);
            this.txtPathDB.TabIndex = 4;
            // 
            // txtQueryPath
            // 
            this.txtQueryPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQueryPath.Location = new System.Drawing.Point(228, 108);
            this.txtQueryPath.Name = "txtQueryPath";
            this.txtQueryPath.Size = new System.Drawing.Size(203, 25);
            this.txtQueryPath.TabIndex = 5;
            // 
            // cmboxQuery
            // 
            this.cmboxQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmboxQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxQuery.FormattingEnabled = true;
            this.cmboxQuery.Location = new System.Drawing.Point(228, 139);
            this.cmboxQuery.Name = "cmboxQuery";
            this.cmboxQuery.Size = new System.Drawing.Size(203, 25);
            this.cmboxQuery.TabIndex = 6;
            this.cmboxQuery.SelectedIndexChanged += new System.EventHandler(this.cmboxQuery_SelectedIndexChanged);
            // 
            // btnPathDb
            // 
            this.btnPathDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathDb.Location = new System.Drawing.Point(437, 76);
            this.btnPathDb.Name = "btnPathDb";
            this.btnPathDb.Size = new System.Drawing.Size(29, 29);
            this.btnPathDb.TabIndex = 7;
            this.btnPathDb.Text = "...";
            this.btnPathDb.UseVisualStyleBackColor = true;
            this.btnPathDb.Click += new System.EventHandler(this.btnPathDb_Click);
            // 
            // btnQueryPath
            // 
            this.btnQueryPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQueryPath.Location = new System.Drawing.Point(437, 107);
            this.btnQueryPath.Name = "btnQueryPath";
            this.btnQueryPath.Size = new System.Drawing.Size(29, 29);
            this.btnQueryPath.TabIndex = 8;
            this.btnQueryPath.Text = "...";
            this.btnQueryPath.UseVisualStyleBackColor = true;
            this.btnQueryPath.Click += new System.EventHandler(this.btnPathQuery_Click);
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Location = new System.Drawing.Point(12, 432);
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.RowHeadersWidth = 51;
            this.dataGridViewDB.RowTemplate.Height = 29;
            this.dataGridViewDB.Size = new System.Drawing.Size(942, 261);
            this.dataGridViewDB.TabIndex = 9;
            // 
            // btnRun
            // 
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Location = new System.Drawing.Point(154, 189);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 48);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Esegui";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(564, 79);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(390, 161);
            this.txtSQL.TabIndex = 11;
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSQL.Location = new System.Drawing.Point(492, 78);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(56, 23);
            this.lblSQL.TabIndex = 12;
            this.lblSQL.Text = "SQL:";
            // 
            // txtFirstPar
            // 
            this.txtFirstPar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstPar.Location = new System.Drawing.Point(121, 319);
            this.txtFirstPar.Name = "txtFirstPar";
            this.txtFirstPar.Size = new System.Drawing.Size(107, 25);
            this.txtFirstPar.TabIndex = 14;
            // 
            // lblFirstPar
            // 
            this.lblFirstPar.AutoSize = true;
            this.lblFirstPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstPar.Location = new System.Drawing.Point(74, 317);
            this.lblFirstPar.Name = "lblFirstPar";
            this.lblFirstPar.Size = new System.Drawing.Size(27, 23);
            this.lblFirstPar.TabIndex = 13;
            this.lblFirstPar.Text = "1:";
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParameters.Location = new System.Drawing.Point(39, 272);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(102, 23);
            this.lblParameters.TabIndex = 15;
            this.lblParameters.Text = "Parametri:";
            // 
            // txtSecondPar
            // 
            this.txtSecondPar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondPar.Location = new System.Drawing.Point(121, 367);
            this.txtSecondPar.Name = "txtSecondPar";
            this.txtSecondPar.Size = new System.Drawing.Size(107, 25);
            this.txtSecondPar.TabIndex = 17;
            // 
            // lblSecondPar
            // 
            this.lblSecondPar.AutoSize = true;
            this.lblSecondPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondPar.Location = new System.Drawing.Point(74, 365);
            this.lblSecondPar.Name = "lblSecondPar";
            this.lblSecondPar.Size = new System.Drawing.Size(27, 23);
            this.lblSecondPar.TabIndex = 16;
            this.lblSecondPar.Text = "2:";
            // 
            // txtFourthPar
            // 
            this.txtFourthPar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFourthPar.Location = new System.Drawing.Point(293, 367);
            this.txtFourthPar.Name = "txtFourthPar";
            this.txtFourthPar.Size = new System.Drawing.Size(107, 25);
            this.txtFourthPar.TabIndex = 21;
            // 
            // lblFourthPar
            // 
            this.lblFourthPar.AutoSize = true;
            this.lblFourthPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFourthPar.Location = new System.Drawing.Point(246, 365);
            this.lblFourthPar.Name = "lblFourthPar";
            this.lblFourthPar.Size = new System.Drawing.Size(27, 23);
            this.lblFourthPar.TabIndex = 20;
            this.lblFourthPar.Text = "4:";
            // 
            // txtThirdPar
            // 
            this.txtThirdPar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThirdPar.Location = new System.Drawing.Point(293, 319);
            this.txtThirdPar.Name = "txtThirdPar";
            this.txtThirdPar.Size = new System.Drawing.Size(107, 25);
            this.txtThirdPar.TabIndex = 19;
            // 
            // lblThirsPar
            // 
            this.lblThirsPar.AutoSize = true;
            this.lblThirsPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThirsPar.Location = new System.Drawing.Point(246, 317);
            this.lblThirsPar.Name = "lblThirsPar";
            this.lblThirsPar.Size = new System.Drawing.Size(27, 23);
            this.lblThirsPar.TabIndex = 18;
            this.lblThirsPar.Text = "3:";
            // 
            // txtSixthPar
            // 
            this.txtSixthPar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSixthPar.Location = new System.Drawing.Point(475, 367);
            this.txtSixthPar.Name = "txtSixthPar";
            this.txtSixthPar.Size = new System.Drawing.Size(107, 25);
            this.txtSixthPar.TabIndex = 25;
            // 
            // lblSixthPar
            // 
            this.lblSixthPar.AutoSize = true;
            this.lblSixthPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSixthPar.Location = new System.Drawing.Point(428, 365);
            this.lblSixthPar.Name = "lblSixthPar";
            this.lblSixthPar.Size = new System.Drawing.Size(27, 23);
            this.lblSixthPar.TabIndex = 24;
            this.lblSixthPar.Text = "6:";
            // 
            // txtFifthPar
            // 
            this.txtFifthPar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFifthPar.Location = new System.Drawing.Point(475, 319);
            this.txtFifthPar.Name = "txtFifthPar";
            this.txtFifthPar.Size = new System.Drawing.Size(107, 25);
            this.txtFifthPar.TabIndex = 23;
            // 
            // lblFifthPar
            // 
            this.lblFifthPar.AutoSize = true;
            this.lblFifthPar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFifthPar.Location = new System.Drawing.Point(428, 317);
            this.lblFifthPar.Name = "lblFifthPar";
            this.lblFifthPar.Size = new System.Drawing.Size(27, 23);
            this.lblFifthPar.TabIndex = 22;
            this.lblFifthPar.Text = "5:";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExport.Location = new System.Drawing.Point(607, 272);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(85, 23);
            this.lblExport.TabIndex = 27;
            this.lblExport.Text = "Esporta:";
            // 
            // cmboxExport
            // 
            this.cmboxExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmboxExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxExport.FormattingEnabled = true;
            this.cmboxExport.Location = new System.Drawing.Point(645, 319);
            this.cmboxExport.Name = "cmboxExport";
            this.cmboxExport.Size = new System.Drawing.Size(175, 25);
            this.cmboxExport.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(826, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 29;
            this.button1.Text = "Esegui";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmboxExport);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.txtSixthPar);
            this.Controls.Add(this.lblSixthPar);
            this.Controls.Add(this.txtFifthPar);
            this.Controls.Add(this.lblFifthPar);
            this.Controls.Add(this.txtFourthPar);
            this.Controls.Add(this.lblFourthPar);
            this.Controls.Add(this.txtThirdPar);
            this.Controls.Add(this.lblThirsPar);
            this.Controls.Add(this.txtSecondPar);
            this.Controls.Add(this.lblSecondPar);
            this.Controls.Add(this.lblParameters);
            this.Controls.Add(this.txtFirstPar);
            this.Controls.Add(this.lblFirstPar);
            this.Controls.Add(this.lblSQL);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.btnQueryPath);
            this.Controls.Add(this.btnPathDb);
            this.Controls.Add(this.cmboxQuery);
            this.Controls.Add(this.txtQueryPath);
            this.Controls.Add(this.txtPathDB);
            this.Controls.Add(this.lblSelectQuery);
            this.Controls.Add(this.lblQueryPath);
            this.Controls.Add(this.lblPathDB);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblPathDB;
        private Label lblQueryPath;
        private Label lblSelectQuery;
        private TextBox txtPathDB;
        private TextBox txtQueryPath;
        private ComboBox cmboxQuery;
        private Button btnPathDb;
        private Button btnQueryPath;
        private DataGridView dataGridViewDB;
        private Button btnRun;
        private TextBox txtSQL;
        private Label lblSQL;
        private TextBox txtFirstPar;
        private Label lblFirstPar;
        private Label lblParameters;
        private TextBox txtSecondPar;
        private Label lblSecondPar;
        private TextBox txtFourthPar;
        private Label lblFourthPar;
        private TextBox txtThirdPar;
        private Label lblThirsPar;
        private TextBox txtSixthPar;
        private Label lblSixthPar;
        private TextBox txtFifthPar;
        private Label lblFifthPar;
        private Label lblExport;
        private ComboBox cmboxExport;
        private Button button1;
    }
}