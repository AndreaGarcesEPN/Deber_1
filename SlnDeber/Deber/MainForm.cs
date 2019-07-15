﻿/*
 * Created by SharpDevelop.
 * User: andre
 * Date: 14/7/2019
 * Time: 20:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Deber
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
		void Escribir(string tipo, DataGridView dgv)
		{
			int posicionNuevoLog = dgv.Rows.Add();
			dgv.Rows[posicionNuevoLog].Cells[0].Value = tipo;
			if(tipo == "error")
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
			string personaje = txbPersonaje.Text;
			string fnacimiento = txbNacimiento.Text;
			string fmuerte = txbMuerte.Text;
			string origen = txbOrigen.Text;
			try
			{
				string path = @"C:\Prueba\ArchivoRegistro.txt";
				//string datosRegistro = personaje + "-" + fnacimiento+ "-" + fmuerte + "-" + origen + "/n";
				StreamWriter escritura = File.CreateText(path);
				escritura.WriteLine(personaje);
				escritura.WriteLine(fnacimiento);
				escritura.WriteLine(fmuerte);
				escritura.WriteLine(origen);
				escritura.Close();
			}
			catch(Exception)
			{
				Escribir("Error", dgvRegistros);
			}
			
		}
		void BtnListarClick(object sender, EventArgs e)
		{
			string personaje = txbPersonaje.Text;
			string fnacimiento = txbNacimiento.Text;
			string fmuerte = txbMuerte.Text;
			string origen = txbOrigen.Text;
			
			try
			{
				string path = @"C:\Prueba\ArchivoRegistro.txt";
				//StreamReader lecturaArchivo = File.OpenText(path);
				string[] lecturaArchivo = File.ReadAllLines(path);
				for (int i = 1; i < 5; i++) 
				{
					for (int j = 0; j < 5; j++) 
					{
						dgvRegistros.Rows[0].Cells[i].Value = lecturaArchivo[j];		
					}
				}
				
			}
			catch(Exception)
			{
				Escribir("Error", dgvRegistros);
			}
		}
	}
}