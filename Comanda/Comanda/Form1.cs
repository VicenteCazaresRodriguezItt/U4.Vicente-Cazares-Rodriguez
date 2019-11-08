using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comanda
{
    //cambie las etiquetas en las labels, textbox, form, etc. 
    //los table index de cada objeto lo cambie para que siguieran un path lineal
    //hice readonly el dtg y el TxtTotal
    //no sabia que acronimo le pone a los conteiners que puso, asi que puse 2 las dos letras de cada palabra
    //puse public cada clase que hizo, ninguna tenia public 
    //cambie los nombres de las clases para que no fueran plural
    //use como accpet button el BtnAgregar
    //cambie el nombre de la solucion, se llamaba Form1, le puse Restaurante...
    //Habia un get que tenia una coma en vez de un punto y coma
    //5

    public partial class FrmRestaurante : Form
    {
      
        readonly BaseDato menus;
        public FrmRestaurante()
        {
            
            InitializeComponent();
            this.Text = "San Jorge Restaurant";
            this.BackColor = Color.BurlyWood;
            menus = new BaseDato();
            menuActivo();
        }

        //private esta usado solo para ser llamado dentro de la clase, asi que no hay necesidad para ponerlo publico
        private void menuActivo()
        {
            CbMenu.DataSource = menus.Listamenu;
            CbMenu.DisplayMember = "Nombre";
            CbMenu.ValueMember = "Id";
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada uno de las opciones del listBox eran iguales, se arreglaba poniendo . y la lista deseada
            switch (CbMenu.SelectedIndex)
            {
                case 1: LbSeleccionar.DataSource = menus.ListAperitivos;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                    //Aqui en ensalada no tiene el prefijo List
                case 2: LbSeleccionar.DataSource = menus.Ensalada;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 3: LbSeleccionar.DataSource = menus.ListCarnes;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 4: LbSeleccionar.DataSource = menus.ListPescado;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 5: LbSeleccionar.DataSource = menus.ListPollo;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 6: LbSeleccionar.DataSource = menus.ListPasta;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 7: LbSeleccionar.DataSource = menus.ListSandwich;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 8: LbSeleccionar.DataSource = menus.ListPaninis;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 9: LbSeleccionar.DataSource = menus.ListPostre;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
                case 10: LbSeleccionar.DataSource = menus.ListBebida;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;

                default:
                    //la se pone vacio para que aparezca "Nombre" cuando selecciones "None"
                    LbSeleccionar.DataSource = menus.Vacio;
                    LbSeleccionar.DisplayMember = "Nombre";
                    LbSeleccionar.ValueMember = "Id";
                    break;
            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgregarMenu();
        }
        private void AgregarMenu()
        {
            var valor = LbSeleccionar.SelectedIndex;
            if (valor != 0)
            {
                //habia una multiplicacion entre 2 tipo de datos diferente solo era poner uno de esos
                var datos = Convert.ToDouble(TxtCantidad.Text) * Convert.ToDouble(TxtPrecio.Text);
                var total = Convert.ToString(datos);
                DtgData.Rows.Add(LbSeleccionar.Text, TxtCantidad.Text, TxtPrecio.Text, total);


            }

        }
        //estos metodos solo se metian dentro de aqui, ya que estaban fuera de la solucion
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarAgregar();
        }

        private void Limpiar()
        {
            TxtPrecio.Text = "";
            TxtCantidad.Text = "0";
            CbMenu.Text = "None";
            TxtTotal.Text = "";
            DtgData.Rows.Clear();
        }

        private void LimpiarAgregar()
        {
            TxtPrecio.Text = "";
            TxtCantidad.Text = "0";
            CbMenu.Text = "None";
            TxtTotal.Text = "";
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            cobrar();
        }

        private void cobrar()
        {
            decimal suma = 0;
            foreach (DataGridViewRow Celda in DtgData.Rows)

                suma += Convert.ToDecimal(Celda.Cells["Total"].Value);
            //este solo se metia aqui ya que estaba fuera
            TxtTotal.Text = Convert.ToString(suma);
        }


        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)

        {

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarMenu();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarAgregar();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cobrar();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto POO Mayo 2019", "Acerca de..");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

   







}
    


