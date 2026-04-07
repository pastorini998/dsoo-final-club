namespace ClubDeportivo

{

    partial class frmPrincipal

    {

      
        private System.ComponentModel.IContainer components = null;




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




        private void InitializeComponent()

        {

            this.label1 = new System.Windows.Forms.Label();

            this.SuspendLayout();

          

            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(344, 188);

            this.label1.Name = "label1";

            this.label1.Size = new System.Drawing.Size(46, 13);

            this.label1.TabIndex = 0;

            this.label1.Text = "";

           

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.label1);

            this.Name = "frmPrincipal";

            this.Text = "frmPrincipal";

            this.ResumeLayout(false);

            this.PerformLayout();



        }



        #endregion



        private System.Windows.Forms.Label label1;

    }

}