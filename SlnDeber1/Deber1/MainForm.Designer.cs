/*
 * Created by SharpDevelop.
 * User: andre
 * Date: 14/7/2019
 * Time: 14:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Deber1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvRegistros;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Personaje;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fnacimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fmuerte;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
		private System.Windows.Forms.TextBox txbPersonaje;
		private System.Windows.Forms.TextBox txbMuerte;
		private System.Windows.Forms.TextBox txbOrigen;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txbNacimiento;
		private System.Windows.Forms.Button btnListar;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvRegistros = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Personaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fnacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fmuerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txbPersonaje = new System.Windows.Forms.TextBox();
			this.txbMuerte = new System.Windows.Forms.TextBox();
			this.txbOrigen = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txbNacimiento = new System.Windows.Forms.TextBox();
			this.btnListar = new System.Windows.Forms.Button();
			this.txbID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRegistros
			// 
			this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ID,
			this.Personaje,
			this.Fnacimiento,
			this.Fmuerte,
			this.Pais});
			this.dgvRegistros.Location = new System.Drawing.Point(12, 184);
			this.dgvRegistros.Name = "dgvRegistros";
			this.dgvRegistros.Size = new System.Drawing.Size(592, 87);
			this.dgvRegistros.TabIndex = 9;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Personaje
			// 
			this.Personaje.HeaderText = "Personaje";
			this.Personaje.Name = "Personaje";
			// 
			// Fnacimiento
			// 
			this.Fnacimiento.HeaderText = "Fecha de nacimiento";
			this.Fnacimiento.Name = "Fnacimiento";
			// 
			// Fmuerte
			// 
			this.Fmuerte.HeaderText = "Fecha de muerte";
			this.Fmuerte.Name = "Fmuerte";
			// 
			// Pais
			// 
			this.Pais.HeaderText = "País de origen";
			this.Pais.Name = "Pais";
			// 
			// txbPersonaje
			// 
			this.txbPersonaje.Location = new System.Drawing.Point(12, 40);
			this.txbPersonaje.Name = "txbPersonaje";
			this.txbPersonaje.Size = new System.Drawing.Size(100, 20);
			this.txbPersonaje.TabIndex = 1;
			// 
			// txbMuerte
			// 
			this.txbMuerte.Location = new System.Drawing.Point(12, 94);
			this.txbMuerte.Name = "txbMuerte";
			this.txbMuerte.Size = new System.Drawing.Size(100, 20);
			this.txbMuerte.TabIndex = 3;
			// 
			// txbOrigen
			// 
			this.txbOrigen.Location = new System.Drawing.Point(12, 120);
			this.txbOrigen.Name = "txbOrigen";
			this.txbOrigen.Size = new System.Drawing.Size(100, 20);
			this.txbOrigen.TabIndex = 4;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(225, 16);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(114, 23);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Agregar Personaje";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 164);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 14);
			this.label1.TabIndex = 9;
			this.label1.Text = "Listar registros:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(118, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Personaje";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(118, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Origen";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(118, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Muerte";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(118, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Nacimiento";
			// 
			// txbNacimiento
			// 
			this.txbNacimiento.Location = new System.Drawing.Point(12, 67);
			this.txbNacimiento.Name = "txbNacimiento";
			this.txbNacimiento.Size = new System.Drawing.Size(100, 20);
			this.txbNacimiento.TabIndex = 2;
			// 
			// btnListar
			// 
			this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnListar.Location = new System.Drawing.Point(499, 155);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(105, 23);
			this.btnListar.TabIndex = 8;
			this.btnListar.Text = "Listar Personajes";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.BtnListarClick);
			// 
			// txbID
			// 
			this.txbID.Location = new System.Drawing.Point(12, 13);
			this.txbID.Name = "txbID";
			this.txbID.Size = new System.Drawing.Size(100, 20);
			this.txbID.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(118, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "ID";
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(225, 42);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(114, 23);
			this.btnEditar.TabIndex = 6;
			this.btnEditar.Text = "Editar Personaje";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(225, 67);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 23);
			this.btnEliminar.TabIndex = 7;
			this.btnEliminar.Text = "Eliminar Personaje";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 283);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txbID);
			this.Controls.Add(this.btnListar);
			this.Controls.Add(this.txbNacimiento);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txbOrigen);
			this.Controls.Add(this.txbMuerte);
			this.Controls.Add(this.txbPersonaje);
			this.Controls.Add(this.dgvRegistros);
			this.Name = "MainForm";
			this.Text = "Deber1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
