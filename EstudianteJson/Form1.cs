
namespace EstudianteJson
{
    public partial class Form1 : Form
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private string archivoJson = "estudiantes.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                int.TryParse(txtEdad.Text, out int edad) &&
                !string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                if (!string.IsNullOrEmpty(txtCarnet.Text))
                {
                    string carnet = txtCarnet.Text;

                    var nuevoEstudiante = new Estudiante
                    {
                        Carnet = carnet,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Edad = edad,
                        Carrera = txtCarrera.Text
                    };
                    estudiantes.Add(nuevoEstudiante);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido para el Carnet.");
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Json.GuardarEnJson(estudiantes, archivoJson);
            MessageBox.Show("Estudiantes guardados en JSON.");
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            estudiantes = Json.LeerDesdeJson(archivoJson);

            MessageBox.Show("Estudiantes cargados desde JSON.");
        }



        private void Actualizar_Click(object sender, EventArgs e)
        {
            DatosEstudiantes.Items.Clear();
            foreach (var estudiante in estudiantes)
            {
                DatosEstudiantes.Items.Add($"{estudiante.Carnet} - {estudiante.Nombre} - {estudiante.Apellido}, {estudiante.Edad}, ({estudiante.Carrera})");
            }
        }
        private void LimpiarCampos()
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtCarrera.Clear();

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "¿Estás seguro de que deseas salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


