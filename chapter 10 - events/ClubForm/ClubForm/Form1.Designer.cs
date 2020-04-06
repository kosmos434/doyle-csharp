namespace ClubForm
{
    partial class ClubForm
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
            this.txtBxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBxEvents = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxAddNew = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxResult
            // 
            this.txtBxResult.Location = new System.Drawing.Point(139, 510);
            this.txtBxResult.Name = "txtBxResult";
            this.txtBxResult.Size = new System.Drawing.Size(382, 26);
            this.txtBxResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Event(s)";
            // 
            // lstBxEvents
            // 
            this.lstBxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstBxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstBxEvents.FormattingEnabled = true;
            this.lstBxEvents.ItemHeight = 20;
            this.lstBxEvents.Items.AddRange(new object[] {
            "Amusement Park",
            "Boat Tour",
            "Dance",
            "Dinner",
            "Hike",
            "Movie",
            "Sport Event"});
            this.lstBxEvents.Location = new System.Drawing.Point(24, 96);
            this.lstBxEvents.Name = "lstBxEvents";
            this.lstBxEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxEvents.Size = new System.Drawing.Size(150, 184);
            this.lstBxEvents.Sorted = true;
            this.lstBxEvents.TabIndex = 3;
            this.lstBxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBxEvents_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add an Activity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBxAddNew
            // 
            this.txtBxAddNew.Location = new System.Drawing.Point(139, 344);
            this.txtBxAddNew.Name = "txtBxAddNew";
            this.txtBxAddNew.Size = new System.Drawing.Size(382, 26);
            this.txtBxAddNew.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClubForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(666, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxAddNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBxEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClubForm";
            this.Text = "Computer Club Yee-haw!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBxEvents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxAddNew;
        private System.Windows.Forms.Button button1;
    }
}

