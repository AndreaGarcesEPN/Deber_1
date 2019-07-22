/*
 * Created by SharpDevelop.
 * User: andre
 * Date: 21/7/2019
 * Time: 12:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Deber1._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string path = @"C:\Prueba\ArchivoRegistro.txt";
		void Escribir(string tipo, string log, DataGridView dgv)
		{
			int posicionNuevoLog = dgv.Rows.Add();
			dgv.Rows[posicionNuevoLog].Cells[0].Value = tipo;
			dgv.Rows[posicionNuevoLog].Cells[1].Value = log;
			if(tipo == "Error")
			{
				dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Red;	
			}
			else
			{
				dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Aquamarine;
			}
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			try
			{
				string id = txbID.Text;
				string personaje = txbPersonaje.Text;
				string fnacimiento = txbNacimiento.Text;
				string fmuerte = txbMuerte.Text;
				string origen = txbOrigen.Text;
				//string datosRegistro = id + "-" + personaje + "-" + fnacimiento + "-" + fmuerte + "-" + origen;
	            string datosRegistro = "ID: " + id + " - Nombre: " + personaje + " - Año Nacimiento: " + fnacimiento + " - Año de Muerte: " 
	           	+ fmuerte + " - Lugar de origen: " + origen;
	            string[] registroArray = File.ReadAllLines(path);
	            String registroFinal = File.ReadAllText(path);
	            StreamWriter escritura = File.CreateText(path);
	            escritura.WriteLine(registroFinal + datosRegistro);
	            escritura.Close();
			}
			catch(Exception)
			{
				Escribir("Error", "Datos no válidos", dgvRegistros);
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			try
			{
				string id = txbID.Text;
				int idEntero = Int32.Parse(id);
				string[] registroArray = File.ReadAllLines(path);
				int finalString = registroArray[idEntero].Length;
				registroArray[idEntero] = registroArray[idEntero].Replace(registroArray[idEntero], " ");
				File.Delete(path);
				File.WriteAllLines(path, registroArray);
			}
			catch(Exception)
			{
				Escribir("Error", "No se pudo completar la acción", dgvRegistros);
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			try
			{
				string id = txbID.Text;
				string personaje = txbPersonaje.Text;
				string fnacimiento = txbNacimiento.Text;
				string fmuerte = txbMuerte.Text;
				string origen = txbOrigen.Text;
				int idEntero = Int32.Parse(id);
				string[] registroArray = File.ReadAllLines(path);
				int finalString = registroArray[idEntero].Length;
				//string datosRegistro = id + "-" + personaje + "-" + fnacimiento + "-" + fmuerte + "-" + origen;
				string datosRegistro = "ID: " + id + " - Nombre: " + personaje + " - Año Nacimiento: " + fnacimiento + " - Año de Muerte: " 
	           	+ fmuerte + " - Lugar de origen: " + origen;
				registroArray[idEntero] = registroArray[idEntero].Replace(registroArray[idEntero], datosRegistro);
				File.Delete(path);
				File.WriteAllLines(path, registroArray);
			}
			catch(Exception)
			{
				Escribir("Error", "No se pudo completar la acción", dgvRegistros);
			}
		}
		void BtnListarClick(object sender, EventArgs e)
		{
			string[] registroArray = File.ReadAllLines(path);
			foreach (string registro in registroArray)
			{
				Escribir("Info", registro, dgvRegistros);	
			}
		}

	}
}
