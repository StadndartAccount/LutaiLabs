using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FarmDog.Objects;
using FarmDog.Objects.Day;


namespace FarmDog
{
    public partial class MainForm : Form
    {
        List<Dog> dogsToShow;
        DayContext dayContext = new DayContext();

        public MainForm(List<Dog> dogs)
        {
            InitializeComponent();

            ConsoleOutput.SetOutputListBox(consoleLogs);

            labelService.Text = $"Обычный сотрудник: {Service.getInstance().Name}";
            labelVeterinarian.Text = $"Ветеринар: {Veterinarian.getInstance().Name}";

            btnNextDayState.Enabled = false;
            dogsToShow = dogs;
            dogsList.DataSource = new BindingSource(dogsToShow, null);
        }

        private void btnNextDayState_Click(object sender, EventArgs e)
        {
            if(trackBarDayState.Value == trackBarDayState.Maximum)
            {
                trackBarDayState.Value = 1;
            } 
            else
            {
                trackBarDayState.Value++;
            }
            // утро -> проверка у ветеринара -> уборка вольеров -> день -> вечер
            dayContext.Request(dogsToShow);

            dogsList.DataSource = new BindingSource(dogsToShow, null);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnNextDayState.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnNextDayState.Enabled = false;
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            consoleLogs.Items.Clear();
        }
    }
}
