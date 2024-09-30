using Registro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = TbLastName.Text;
            person.LastName = TbLastName.Text;
            person.BirthDate = DtpBDate.Value;
            persons.Add(new Person());
            ShowPerson();
            CalculateAge();

        }
        private void ShowPerson()
        {
            DtvShow.DataSource = null;
            DtvShow.DataSource = persons;


        }

        private void CleanTb()
        {
            TbName.Clear();
            TbLastName.Clear();
            
        }
        private void CalculateAge()
        {
            DateTime fechaNacimiento = DtpBDate.Value;
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
        }

    }
}
