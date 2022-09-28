namespace Agenda_Form
{
    partial class FormAgenda
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
            this.buttonNovo = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonGrava = new System.Windows.Forms.Button();
            this.buttonExclui = new System.Windows.Forms.Button();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonLista = new System.Windows.Forms.Button();
            this.textBoxTelefones = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBoxPrincipal = new System.Windows.Forms.CheckBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.listBoxTelefones = new System.Windows.Forms.ListBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTelefones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(11, 226);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(77, 29);
            this.buttonNovo.TabIndex = 7;
            this.buttonNovo.Text = "NOVO";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(103, 72);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(125, 27);
            this.textBoxEmail.TabIndex = 0;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(103, 123);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(125, 27);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(103, 175);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(125, 27);
            this.textBoxData.TabIndex = 2;
            // 
            // buttonGrava
            // 
            this.buttonGrava.Location = new System.Drawing.Point(94, 226);
            this.buttonGrava.Name = "buttonGrava";
            this.buttonGrava.Size = new System.Drawing.Size(69, 29);
            this.buttonGrava.TabIndex = 8;
            this.buttonGrava.Text = "GRAVAR";
            this.buttonGrava.UseVisualStyleBackColor = true;
            this.buttonGrava.Click += new System.EventHandler(this.buttonGrava_Click);
            // 
            // buttonExclui
            // 
            this.buttonExclui.Location = new System.Drawing.Point(169, 226);
            this.buttonExclui.Name = "buttonExclui";
            this.buttonExclui.Size = new System.Drawing.Size(70, 29);
            this.buttonExclui.TabIndex = 9;
            this.buttonExclui.Text = "EXCLUI";
            this.buttonExclui.UseVisualStyleBackColor = true;
            this.buttonExclui.Click += new System.EventHandler(this.buttonExclui_Click);
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Location = new System.Drawing.Point(245, 226);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(91, 29);
            this.buttonPesquisa.TabIndex = 10;
            this.buttonPesquisa.Text = "PESQUISA";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.buttonPesquisa_Click);
            // 
            // buttonLista
            // 
            this.buttonLista.Location = new System.Drawing.Point(342, 226);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(70, 29);
            this.buttonLista.TabIndex = 11;
            this.buttonLista.Text = "LISTAR";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // textBoxTelefones
            // 
            this.textBoxTelefones.Location = new System.Drawing.Point(371, 71);
            this.textBoxTelefones.Name = "textBoxTelefones";
            this.textBoxTelefones.Size = new System.Drawing.Size(136, 27);
            this.textBoxTelefones.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(528, 72);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 29);
            this.button6.TabIndex = 4;
            this.button6.Text = "ADICIONAR ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBoxPrincipal
            // 
            this.checkBoxPrincipal.AutoSize = true;
            this.checkBoxPrincipal.Location = new System.Drawing.Point(528, 122);
            this.checkBoxPrincipal.Name = "checkBoxPrincipal";
            this.checkBoxPrincipal.Size = new System.Drawing.Size(88, 24);
            this.checkBoxPrincipal.TabIndex = 6;
            this.checkBoxPrincipal.Text = "Principal";
            this.checkBoxPrincipal.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Móvel"});
            this.comboBoxTipo.Location = new System.Drawing.Point(371, 117);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(136, 28);
            this.comboBoxTipo.TabIndex = 5;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 20;
            this.listBoxContatos.Location = new System.Drawing.Point(31, 290);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(598, 244);
            this.listBoxContatos.TabIndex = 12;
            this.listBoxContatos.SelectedIndexChanged += new System.EventHandler(this.listBoxContatos_SelectedIndexChanged);
            // 
            // listBoxTelefones
            // 
            this.listBoxTelefones.FormattingEnabled = true;
            this.listBoxTelefones.ItemHeight = 20;
            this.listBoxTelefones.Location = new System.Drawing.Point(434, 175);
            this.listBoxTelefones.Name = "listBoxTelefones";
            this.listBoxTelefones.Size = new System.Drawing.Size(195, 84);
            this.listBoxTelefones.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(18, 75);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email: ";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(18, 126);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 20);
            this.labelNome.TabIndex = 15;
            this.labelNome.Text = "Nome:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(18, 178);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(80, 20);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Data Nasc.";
            // 
            // labelTelefones
            // 
            this.labelTelefones.AutoSize = true;
            this.labelTelefones.Location = new System.Drawing.Point(292, 74);
            this.labelTelefones.Name = "labelTelefones";
            this.labelTelefones.Size = new System.Drawing.Size(73, 20);
            this.labelTelefones.TabIndex = 17;
            this.labelTelefones.Text = "Telefone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tipo: ";
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTelefones);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.listBoxTelefones);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.checkBoxPrincipal);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxTelefones);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.buttonPesquisa);
            this.Controls.Add(this.buttonExclui);
            this.Controls.Add(this.buttonGrava);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonNovo);
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonNovo;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private TextBox textBoxData;
        private Button buttonGrava;
        private Button buttonExclui;
        private Button buttonPesquisa;
        private Button buttonLista;
        private TextBox textBoxTelefones;
        private Button button6;
        private CheckBox checkBoxPrincipal;
        private ComboBox comboBoxTipo;
        private ListBox listBoxContatos;
        private ListBox listBoxTelefones;
        private Label labelEmail;
        private Label labelNome;
        private Label labelData;
        private Label labelTelefones;
        private Label label5;
    }
}