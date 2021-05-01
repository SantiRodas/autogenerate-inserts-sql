using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private String[] position = { "Profesor", "Jefe", "Coordinador", "Servicio", "Tecnico" };

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

        // Arrays with the information of the WorksOn

        private String[] dateWorksOn = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };

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
                    // An individual file is created for all automatically generated employees.

                    TextWriter writer = new StreamWriter("Employee-Deparment.sql");

                    for (int i = 0; i < number; i ++)
                    {
                        writer.WriteLine(generateEmployee("A" + i, "D" + i, deptName[generateNumber(0, 9)]));
                    }

                    MessageBox.Show("Archivo completo (Ruta: Bin, Debug)");

                    writer.Close();

                } else if (optionTable3.Checked == true)
                {
                    // An individual file is created for all automatically generated projects.

                    TextWriter writer = new StreamWriter("Project.sql");

                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(generateProject("A" + i, "D" + i));
                    }

                    MessageBox.Show("Archivo completo (Ruta: Bin, Debug)");

                    writer.Close();

                } else if (optionTable4.Checked == true)
                {
                    // An individual file is created for all automatically generated WorksOn.

                    TextWriter writer = new StreamWriter("WorksOn.sql");

                    for (int i = 0; i < number; i++)
                    {
                        writer.Write(generateWorksOn("A" + i, "P" + i));
                    }

                    MessageBox.Show("Archivo completo (Ruta: Bin, Debug)");

                    writer.Close();

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

        public String generateEmployee(String empNo, String deptNo, String deptName)
        {
            String insert = ""; 

            String name = fName[generateNumber(0, 19)];
            String lastName = lName[generateNumber(0, 19)];
            String direction = address[generateNumber(0, 4)] + " " + generateNumber(1, 80).ToString();
            String year = generateNumber(1938, 2000).ToString();
            String day = generateNumber(1, 29).ToString();
            String month = generateNumber(1, 12).ToString();
            char gender = sex[generateNumber(0, 1)];
            String job = position[generateNumber(0, 4)];

            insert += "\n" + "-- Este es un comentario para seperar INSERT de manera ordenada";

            insert += "\n" + "\n" + "INSERT INTO DEPARTMENT (deptNo, deptName) VALUES ('" + deptNo + "', '" + deptName + "');";

            insert += "\n" + "INSERT INTO EMPLOYEE (empNo, fname, lname, address, dob, sex, position, deptNo)";

            insert += " VALUES ('" + empNo + "', '" + name + "', '" + lastName + "', '" + direction + "', TO_DATE('" + year + "' ,'yyyy'), '" + gender + "', '" + job + "', '" + deptNo + "');";

            insert += "\n" + "\n" + "UPDATE DEPARTMENT";

            insert += "\n" + "set mgrempno = '" + empNo + "'";

            insert += "\n" + "WHERE deptno = '" + deptNo + "';";

            return insert;
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate Project

        public String generateProject(String projNo, String deptNo)
        {
            String insert = "";

            String name = projName[generateNumber(0, 9)];

            insert += "\n" + "-- Este es un comentario para seperar INSERT de manera ordenada";

            insert += "\n" + "\n" + "INSERT INTO PROJECT (projNo, projName, deptNo) VALUES ('" + projNo + "', '" + name + "', '" + deptNo + "');";

            return insert;
        }

        // ----------------------------------------------------------------------------------------------------

        // Generate WorksOn

        public String generateWorksOn(String empNo, String projNo)
        {
            String insert = "";

            String hours = generateNumber(1, 16).ToString();
            String date = dateWorksOn[generateNumber(0, 5)];

            insert += "\n" + "-- Este es un comentario para seperar INSERT de manera ordenada";

            insert += "\n" + "\n" + "INSERT INTO WORKSON (empNo, projNo, hours) VALUES ('" + empNo + "', '" + projNo + "', '" + hours + "');" + "\n";

            return insert;
        }

        // ----------------------------------------------------------------------------------------------------

    }
}
