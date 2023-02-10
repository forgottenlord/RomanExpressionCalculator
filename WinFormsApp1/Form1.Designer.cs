
namespace WinFormsApp1;
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(69, 54);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(587, 23);
            this.Input.TabIndex = 0;
            this.Input.Text = "(XV+XLVII)*XIII";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(69, 101);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(587, 23);
            this.Output.TabIndex = 1;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(228, 144);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(285, 23);
            this.execute.TabIndex = 2;
            this.execute.Text = "execute";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.execute);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox Input;
    private TextBox Output;
    private Button execute;
}
