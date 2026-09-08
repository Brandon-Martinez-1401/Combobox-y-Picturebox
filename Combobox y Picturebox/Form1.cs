namespace Combobox_y_Picturebox
{
    public partial class Form1 : Form
    {
        //Ruta donde se encuentran las imágenes
        private readonly string rutaRecursos =
            Path.Combine(Application.StartupPath, "Resources");


        public Form1()
        {
            InitializeComponent();
            //Cargar las distribuciones al iniciar
            CargarDistribuciones();

            //Configurarar  el picturebox 
            PicLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            //

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //========================================
        //Cargar las distribuciones en el combobox
        //========================================
        private void CargarDistribuciones()
        {
            comboDistro.Items.Clear();

            comboDistro.Items.Add("Puppy Linux");
            comboDistro.Items.Add("Slax");
            comboDistro.Items.Add("AntiX");
            comboDistro.Items.Add("Debian");
            comboDistro.Items.Add("Tiny Core Linux");
            //No seleccionamos ningun item al iniciar
            comboDistro.SelectedIndex = -1;

        }

        private void comboDistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Revisar que el comboBox tenga informacion
            if (comboDistro.SelectedIndex == -1)
            {
                return;
            }
            string distroSeleccionada =
                comboDistro.SelectedItem.ToString();
            switch(distroSeleccionada) {
                case "Puppy Linux":
                    MostrarDistro(
                        "Puppy Linux",
                        "Puppy Linux es una distribución de Linux ligera"+
                        "Diseñada para ser funcioar correctamente en"+
                        "equipos con pocos recursos\r\n\r\n"+
                        "Requisitos aproximados:\r\n"+
                        "-Procesador: x86 o compatible\r\n" +
                        "-RAM: 1GB o más\r\n" +
                        "Espacio reducido en disco",
                        "puppy.png",
                        "https://puppylinux-woof-ce.github.io/"
                        );
                    break;
                    MostrarDistro(
                        "Slax",
                        "Slax es una distribución de Linux ligera" +
                        "Portable que se puede ejecutar desde" +
                        "una memoria USB\r\n\r\n"+
                        "Requisitos aproximados:\r\n" +
                        "-Procesador: x86_64 o compatible\r\n" +
                        "-RAM: 512 MB o más\r\n" +
                        "Espacio reducido en disco",
                        "slax.png",
                        "https://slax.org/"
                        );
                    break;
            }
        }
    }
}
