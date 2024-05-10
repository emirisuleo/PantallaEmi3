using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PantallaEmi3
{
    public partial class OrdenesPreparacion : Form
    {
        public OrdenesPreparacion()
        {
            InitializeComponent();
            LoadDataFromFile("C:\\Users\\risu_\\OneDrive\\Escritorio\\CAI\\Almacenes\\maestroOrdenesPreparaci�n.txt");
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                // Leer todas las l�neas del archivo de texto
                string[] lines = File.ReadAllLines(filePath);

                // Agregar cada l�nea al ListBox
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el ListBox de detalles
            DetalleOrdenPreparacion.Items.Clear();

            // Obtener el �ndice del elemento seleccionado en el ListBox principal
            int selectedIndex = listBox1.SelectedIndex;

            // Verificar si se seleccion� un elemento v�lido
            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                // Obtener el detalle del elemento seleccionado
                string selectedItem = listBox1.Items[selectedIndex].ToString();
                string detail = ObtenerDetalle(selectedItem); // M�todo que obtiene los detalles, deber�s implementarlo

                // Mostrar el detalle en el ListBox de detalles
                DetalleOrdenPreparacion.Items.Add(detail);
            }
        }


        // M�todo para obtener los detalles del elemento seleccionado
        private string ObtenerDetalle(string selectedItem)
        {
            try
            {
                // Ruta de la carpeta de detalles
                string detallesFolder = @"C:\Users\risu_\OneDrive\Escritorio\CAI\Almacenes\DetalleOrdenesPreparaci�n";
                // Construir la ruta del archivo de detalle
                string detalleFilePath = Path.Combine(detallesFolder, selectedItem + ".txt"); // Suponiendo que los archivos de detalle tienen el mismo nombre que los elementos seleccionados en el primer ListBox

                // Verificar si el archivo de detalle existe
                if (File.Exists(detalleFilePath))
                {
                    // Leer todas las l�neas del archivo de detalle
                    string[] lines = File.ReadAllLines(detalleFilePath);

                    // Limpiar ListBox de detalles
                    DetalleOrdenPreparacion.Items.Clear();

                    // Agregar cada l�nea del archivo como un elemento separado en el ListBox
                    foreach (string line in lines)
                    {
                        this.DetalleOrdenPreparacion.Items.Add(line);
                    }

                    // Devolver un mensaje vac�o (ya que los detalles se han agregado al ListBox)
                    return "";
                }
                else
                {
                    return "No se encontraron detalles para: " + selectedItem;
                }
            }
            catch (Exception ex)
            {
                return "Error al obtener detalles: " + ex.Message;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en los TextBox
            string dato1 = textBox1.Text;
            string dato2 = textBox2.Text;
            string dato3 = textBox3.Text;

            // Crear una cadena con los datos ingresados
            string datosCombinados = $"{dato1}, {dato2}, {dato3}";

            // Agregar los datos combinados a la ListBox2
            listBox2.Items.Add(datosCombinados);

            // Limpiar los TextBox para el pr�ximo ingreso
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en la ListBox
            if (listBox2.SelectedIndex != -1)
            {
                // Eliminar el elemento seleccionado de la ListBox
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ning�n elemento para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardar los datos de la listBox2 en un archivo .txt
                string maestroOrdenesSeleccionadasFilePath = @"C:\Users\risu_\OneDrive\Escritorio\CAI\Almacenes\maestroOrdenesSeleccionadas.txt";
                File.WriteAllLines(maestroOrdenesSeleccionadasFilePath, listBox2.Items.Cast<string>());

                // Eliminar el elemento en maestroOrdenesPreparaci�n que coincida con el elemento en textBox1
                string elementoAEliminar = textBox1.Text;
                string maestroOrdenesPreparacionFilePath = @"C:\Users\risu_\OneDrive\Escritorio\CAI\Almacenes\maestroOrdenesPreparaci�n.txt";
                string[] lineas = File.ReadAllLines(maestroOrdenesPreparacionFilePath);
                List<string> nuevasLineas = new List<string>();
                foreach (string linea in lineas)
                {
                    if (!linea.Equals(elementoAEliminar))
                    {
                        nuevasLineas.Add(linea);
                    }
                }
                File.WriteAllLines(maestroOrdenesPreparacionFilePath, nuevasLineas);

                // Mostrar un mensaje de �xito
                MessageBox.Show("La orden de selecci�n se ha generado correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al finalizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

