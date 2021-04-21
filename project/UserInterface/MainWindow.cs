using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.UserInterface
{
    public partial class MainWindow : Form
    {

        // Create a Random References

        private readonly Random random = new Random();

        // Arrays with the information of the all employees

        private String[] fName = { "Santiago", "Luisa", "Camilo", "Erika", "Nolberto", "Valentina", "David", "Susana",
        "Guido", "Soranyely", "Sebastian", "Viviana", "Carlos", "Elena", "Victor", "Maria", "Diego", "Laura",
        "Miguel", "Aura"};

        private String[] lName = { "Rodas", "Quintero", "Escobar", "Rodriguez", "Osorio", "Ortiz", "Payan", "Yugueros",
        "Lopez", "Castillo", "Moys", "Leyton", "Valderrama", "Silva", "Torres", "Vivas", "Parra", "Muñoz",
        "Valdes", "Gonzales"};

        private String[] adress = { "Calle", "Carrera", "Transversal", "Avenida", "Kilometro" };

        private char[] sex = { 'M', 'F' };

        private String[] position = { "Profesor", "Asistente", "Coordinador", "Servicio", "Tecnico" };

        // ----------------------------------------------------------------------------------------------------

        // MainWindow constructor

        public MainWindow()
        {
            InitializeComponent();
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate inserts - button method

        private void generateButton_Click(object sender, EventArgs e)
        {

            try
            {
                int number = Int32.Parse(numberInsertsTX.Text);

                if (optionTable1.Checked == true)
                {

                } else if (optionTable2.Checked == true)
                {

                } else if (optionTable3.Checked == true)
                {

                } else if (optionTable4.Checked == true)
                {

                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Texto no valido, por favor ingrese un numero");
            }

        }

        // ----------------------------------------------------------------------------------------------------

        // Generate a random number

        public int generateNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate employee

        public String generateEmployee()
        {
            return "";
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate Deparment

        public String generateDepartmen()
        {
            return "";
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate Project

        public String generateProject()
        {
            return "";
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate WorksOn

        public String generateWorksOn()
        {
            return "";
        }

        // ----------------------------------------------------------------------------------------------------

    }
}
