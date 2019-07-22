/*
 * Created by SharpDevelop.
 * User: andre
 * Date: 21/7/2019
 * Time: 12:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Deber1._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.Button btnListar;
		private System.Windows.Forms.TextBox txbNacimiento;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txbOrigen;
		private System.Windows.Forms.TextBox txbMuerte;
		private System.Windows.Forms.TextBox txbPersonaje;
		private System.Windows.Forms.DataGridView dgvRegistros;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Informacion;
		
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
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txbID = new System.Windows.Forms.TextBox();
			this.btnListar = new System.Windows.Forms.Button();
			this.txbNacimiento = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txbOrigen = new System.Windows.Forms.TextBox();
			this.txbMuerte = new System.Windows.Forms.TextBox();
			this.txbPersonaje = new System.Windows.Forms.TextBox();
			this.dgvRegistros = new System.Windows.Forms.DataGridView();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Informacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(228, 61);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 23);
			this.btnEliminar.TabIndex = 24;
			this.btnEliminar.Text = "Eliminar Personaje";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(228, 36);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(114, 23);
			this.btnEditar.TabIndex = 23;
			this.btnEditar.Text = "Editar Personaje";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(121, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 32;
			this.label6.Text = "ID";
			// 
			// txbID
			// 
			this.txbID.Location = new System.Drawing.Point(15, 7);
			this.txbID.Name = "txbID";
			this.txbID.Size = new System.Drawing.Size(100, 20);
			this.txbID.TabIndex = 17;
			// 
			// btnListar
			// 
			this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnListar.Location = new System.Drawing.Point(502, 149);
			this.btnListar.Name = "btnListar";
			this.btnListar.Size = new System.Drawing.Size(105, 23);
			this.btnListar.TabIndex = 25;
			this.btnListar.Text = "Listar Personajes";
			this.btnListar.UseVisualStyleBackColor = true;
			this.btnListar.Click += new System.EventHandler(this.BtnListarClick);
			// 
			// txbNacimiento
			// 
			this.txbNacimiento.Location = new System.Drawing.Point(15, 61);
			this.txbNacimiento.Name = "txbNacimiento";
			this.txbNacimiento.Size = new System.Drawing.Size(100, 20);
			this.txbNacimiento.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(121, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 31;
			this.label5.Text = "Nacimiento";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(121, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 30;
			this.label4.Text = "Muerte";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(121, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 29;
			this.label3.Text = "Origen";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(121, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 28;
			this.label2.Text = "Personaje";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 158);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 14);
			this.label1.TabIndex = 26;
			this.label1.Text = "Listar registros:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(228, 10);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(114, 23);
			this.btnAgregar.TabIndex = 22;
			this.btnAgregar.Text = "Agregar Personaje";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txbOrigen
			// 
			this.txbOrigen.Location = new System.Drawing.Point(15, 114);
			this.txbOrigen.Name = "txbOrigen";
			this.txbOrigen.Size = new System.Drawing.Size(100, 20);
			this.txbOrigen.TabIndex = 21;
			// 
			// txbMuerte
			// 
			this.txbMuerte.Location = new System.Drawing.Point(15, 88);
			this.txbMuerte.Name = "txbMuerte";
			this.txbMuerte.Size = new System.Drawing.Size(100, 20);
			this.txbMuerte.TabIndex = 20;
			// 
			// txbPersonaje
			// 
			this.txbPersonaje.Location = new System.Drawing.Point(15, 34);
			this.txbPersonaje.Name = "txbPersonaje";
			this.txbPersonaje.Size = new System.Drawing.Size(100, 20);
			this.txbPersonaje.TabIndex = 18;
			// 
			// dgvRegistros
			// 
			this.dgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Estado,
			this.Informacion});
			this.dgvRegistros.Location = new System.Drawing.Point(15, 178);
			this.dgvRegistros.Name = "dgvRegistros";
			this.dgvRegistros.Size = new System.Drawing.Size(592, 87);
			this.dgvRegistros.TabIndex = 27;
			// 
			// Estado
			// 
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			// 
			// Informacion
			// 
			this.Informacion.HeaderText = "Información";
			this.Informacion.Name = "Informacion";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 273);
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
			this.Text = "Personajes Históricos";
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
