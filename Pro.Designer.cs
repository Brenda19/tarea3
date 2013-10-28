using System.Windows.Forms;
namespace t3
{
	partial class A
	{
		
	    string Usuario= "brenda";
		string Contraseña = "abc";
		
		private System.ComponentModel.IContainer comp = null;
		
		
		protected override void Dispose(bool dis)
		{
			if (dis) {
				if (comp != null) {
					comp.Dispose();
				}
			}
			base.Dispose(dis);
		}
				
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(78, 57);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(78, 147);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(90, 194);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Iniciar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(78, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(78, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Contraseña:";
			// 
			// A
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "A";
			this.Text = "Tarea 3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		
		void Button1Click(object sender, System.EventArgs e)
		{
		
			if	(textBox1.Text == Usuario &&  textBox2.Text == Contraseña){
				
				MessageBox.Show("usuario y contraseña correctos");
				
			}
			else 
				MessageBox.Show("datos incorrectos");
			}
		}
	}

