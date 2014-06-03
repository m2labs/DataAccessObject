namespace Dao
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImoveisGridView = new System.Windows.Forms.DataGridView();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.proprietarioTextBox = new System.Windows.Forms.TextBox();
            this.modalidadeComboBox = new System.Windows.Forms.ComboBox();
            this.InserirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImoveisGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImoveisGridView
            // 
            this.ImoveisGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImoveisGridView.Location = new System.Drawing.Point(12, 109);
            this.ImoveisGridView.Name = "ImoveisGridView";
            this.ImoveisGridView.Size = new System.Drawing.Size(500, 167);
            this.ImoveisGridView.TabIndex = 0;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "Residencial",
            "Comercial"});
            this.tipoComboBox.Location = new System.Drawing.Point(12, 46);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoComboBox.TabIndex = 1;
            // 
            // proprietarioTextBox
            // 
            this.proprietarioTextBox.Location = new System.Drawing.Point(13, 13);
            this.proprietarioTextBox.Name = "proprietarioTextBox";
            this.proprietarioTextBox.Size = new System.Drawing.Size(445, 20);
            this.proprietarioTextBox.TabIndex = 2;
            // 
            // modalidadeComboBox
            // 
            this.modalidadeComboBox.FormattingEnabled = true;
            this.modalidadeComboBox.Items.AddRange(new object[] {
            "Apartamento",
            "Casa",
            "Loja"});
            this.modalidadeComboBox.Location = new System.Drawing.Point(182, 46);
            this.modalidadeComboBox.Name = "modalidadeComboBox";
            this.modalidadeComboBox.Size = new System.Drawing.Size(142, 21);
            this.modalidadeComboBox.TabIndex = 3;
            // 
            // InserirButton
            // 
            this.InserirButton.Location = new System.Drawing.Point(358, 46);
            this.InserirButton.Name = "InserirButton";
            this.InserirButton.Size = new System.Drawing.Size(75, 23);
            this.InserirButton.TabIndex = 4;
            this.InserirButton.Text = "Inserir";
            this.InserirButton.UseVisualStyleBackColor = true;
            this.InserirButton.Click += new System.EventHandler(this.InserirButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 304);
            this.Controls.Add(this.InserirButton);
            this.Controls.Add(this.modalidadeComboBox);
            this.Controls.Add(this.proprietarioTextBox);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.ImoveisGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImoveisGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ImoveisGridView;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.TextBox proprietarioTextBox;
        private System.Windows.Forms.ComboBox modalidadeComboBox;
        private System.Windows.Forms.Button InserirButton;
    }
}

