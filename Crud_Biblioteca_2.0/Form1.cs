using Crud_Biblioteca_2._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Biblioteca_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            //var libros = client.GetLibros();
            //var list = new List<Libro>();
            //foreach (var libro in libros)
            //{
            //    list.Add(new Libro
            //    {
            //        Id = libro.Id,
            //        Titulo = libro.Titulo,
            //        Autor = libro.Autor,
            //        Genero = libro.Genero,
            //        AnioPublicacion = libro.AnioPublicacion
            //    });
            //}
            //dataGridView1.DataSource = list;
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    var libro = new Libro
        //    {
        //        Titulo = txtTitulo.Text,
        //        Autor = txtAutor.Text,
        //        Genero = txtGenero.Text,
        //        AnioPublicacion = int.Parse(txtAnioPublicacion.Text)
        //    };
        //    client.AddLibro(libro.Titulo, libro.Autor, libro.Genero, libro.AnioPublicacion);
        //    LoadData();
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    var libro = new Libro
        //    {
        //        Id = int.Parse(txtId.Text),
        //        Titulo = txtTitulo.Text,
        //        Autor = txtAutor.Text,
        //        Genero = txtGenero.Text,
        //        AnioPublicacion = int.Parse(txtAnioPublicacion.Text)
        //    };
        //    client.UpdateLibro(libro.Id, libro.Titulo, libro.Autor, libro.Genero, libro.AnioPublicacion);
        //    LoadData();
        //}

        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    var id = int.Parse(txtId.Text);
        //    client.DeleteLibro(id);
        //    LoadData();
        //}

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        var row = dataGridView1.Rows[e.RowIndex];
        //        txtId.Text = row.Cells["Id"].Value.ToString();
        //        txtTitulo.Text = row.Cells["Titulo"].Value.ToString();
        //        txtAutor.Text = row.Cells["Autor"].Value.ToString();
        //        txtGenero.Text = row.Cells["Genero"].Value.ToString();
        //        txtAnioPublicacion.Text = row.Cells["AnioPublicacion"].Value.ToString();
        //    }
        //}
    }
}
