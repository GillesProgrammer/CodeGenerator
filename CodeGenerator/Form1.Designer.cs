namespace CodeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btGenerate = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbGrain = new System.Windows.Forms.Label();
            this.tbGrain = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(232, 22);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(13, 25);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(130, 20);
            this.tbCode.TabIndex = 1;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(59, 9);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(32, 13);
            this.lbCode.TabIndex = 2;
            this.lbCode.Text = "Code";
            // 
            // lbGrain
            // 
            this.lbGrain.AutoSize = true;
            this.lbGrain.Location = new System.Drawing.Point(167, 9);
            this.lbGrain.Name = "lbGrain";
            this.lbGrain.Size = new System.Drawing.Size(32, 13);
            this.lbGrain.TabIndex = 3;
            this.lbGrain.Text = "Grain";
            // 
            // tbGrain
            // 
            this.tbGrain.Location = new System.Drawing.Point(149, 25);
            this.tbGrain.Name = "tbGrain";
            this.tbGrain.Size = new System.Drawing.Size(77, 20);
            this.tbGrain.TabIndex = 4;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(13, 64);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(294, 20);
            this.tbResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 102);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbGrain);
            this.Controls.Add(this.lbGrain);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.btGenerate);
            this.Name = "Form1";
            this.Text = "Code generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbGrain;
        private System.Windows.Forms.TextBox tbGrain;
        private System.Windows.Forms.TextBox tbResult;
    }
}

