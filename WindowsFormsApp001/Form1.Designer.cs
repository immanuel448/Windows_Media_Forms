namespace WindowsFormsApp001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.media001 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnRepro = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.file001 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.media001)).BeginInit();
            this.SuspendLayout();
            // 
            // media001
            // 
            this.media001.Enabled = true;
            this.media001.Location = new System.Drawing.Point(12, 12);
            this.media001.Name = "media001";
            this.media001.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media001.OcxState")));
            this.media001.Size = new System.Drawing.Size(278, 235);
            this.media001.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Futura Md BT", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(12, 253);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(65, 33);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnRepro
            // 
            this.btnRepro.Font = new System.Drawing.Font("Futura Md BT", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepro.Location = new System.Drawing.Point(83, 253);
            this.btnRepro.Name = "btnRepro";
            this.btnRepro.Size = new System.Drawing.Size(65, 33);
            this.btnRepro.TabIndex = 2;
            this.btnRepro.Text = "Repro";
            this.btnRepro.UseVisualStyleBackColor = true;
            this.btnRepro.Click += new System.EventHandler(this.btnRepro_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Font = new System.Drawing.Font("Futura Md BT", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.Location = new System.Drawing.Point(154, 253);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(65, 33);
            this.btnPausar.TabIndex = 3;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Font = new System.Drawing.Font("Futura Md BT", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(225, 253);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(65, 33);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // file001
            // 
            this.file001.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 298);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnRepro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.media001);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buenas Prácticas";
            ((System.ComponentModel.ISupportInitialize)(this.media001)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer media001;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnRepro;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.OpenFileDialog file001;
    }
}

