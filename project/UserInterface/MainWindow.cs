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

        // ----------------------------------------------------------------------------------------------------

        // Arrays with the information of the all employees

        private String[] fName = { "Santiago", "Luisa", "Camilo", "Erika", "Nolberto", "Valentina", "David", "Susana",
        "Guido", "Soranyely", "Sebastian", "Viviana", "Carlos", "Elena", "Victor", "Maria", "Diego", "Laura",
        "Miguel", "Aura"};

        private String[] lName = { "Rodas", "Quintero", "Escobar", "Rodriguez", "Osorio", "Ortiz", "Payan", "Yugueros",
        "Lopez", "Castillo", "Moys", "Leyton", "Valderrama", "Silva", "Torres", "Vivas", "Parra", "Muñoz",
        "Valdes", "Gonzales"};

        private String[] address = { "Calle", "Carrera", "Transversal", "Avenida", "Kilometro" };

        private char[] sex = { 'M', 'F' };

        private String[] position = { "Profesor", "Asistente", "Coordinador", "Servicio", "Tecnico" };

        // ----------------------------------------------------------------------------------------------------

        // Arrays with the information of the all departaments

        private String[] deptName = { "Matematica", "Quimica", "Ingenieria", "Administracion", "Mercadeo", 
        "Ciencias", "Servicios", "Contabilidad", "Lenguaje", "Desarollo"};

        // ----------------------------------------------------------------------------------------------------

        // Arrays with the information of the all project

        private String[] projName = { "Infinito numerico", "Estados de la materia", "Programacion reducida", 
        "Ecuaciones lineales", "Clientes y bienestar", "Cuerpo humano", "Nuevo panorama", 
        "Balance general", "Nuevos idiomas", "Nuevas aplicaciones"};

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

        public String generateEmployee(String empNo, String deptNo)
        {
            String name = fName[generateNumber(0, 19)];
            String lastName = lName[generateNumber(0, 19)];
            String direction = address[generateNumber(0, 4)] + " " + generateNumber(1, 80).ToString();
            String date = generateNumber(1, 28).ToString() + "-" + generateNumber(1, 12).ToString();
            char gender = sex[generateNumber(0, 1)];
            String job = position[generateNumber(0, 4)];

            String insert = "INSERT INTO Employee VALUES ('" + empNo + "', '" + name + "', '" + lastName + "', '" +
            direction + "', '" + date + "', '" + gender + "', '" + job + ", '" + deptNo + "');";

            return insert;
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate Deparment

        public String generateDepartmen(String deptNo, String mgrEmpNo)
        {
            String name = deptName[generateNumber(0, 9)];

            String insert = "INSERT INTO Department VALUES ('" + deptNo + "', '" + name + "', '" + mgrEmpNo + "');";

            return insert;
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate Project

        public String generateProject(String projNo, String deptNo)
        {
            String name = projName[generateNumber(0, 9)];

            String insert = "INSERT INTO Project VALUES ('" + projNo + "', '" + name + "', '" + deptNo + "');";

            return insert;
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate WorksOn

        public String generateWorksOn(String empNo, String projNo, String dateworked)
        {
            String hours = generateNumber(1, 16).ToString();

            String insert = "INSERT INTO WorksOn VALUES ('" + empNo + "', '" + projNo + "', '" + dateworked + 
            "', '" + hours + "');";

            return insert;
        }

        // ----------------------------------------------------------------------------------------------------

    }
}
