using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FarmDog.Objects;
using FarmDog.Objects.Day;


namespace FarmDog
{
    public partial class MainForm : Form
    {
        public static List<Dog> dogsToShow;
        public static DayContext dayContext = new DayContext();
        bool isAutoUpdate = false;

        Service service = new Service("Никита");
        Veterinarian veterinarian = new Veterinarian("Миша");

        public MainForm(List<Dog> dogs)
        {
            InitializeComponent();

            ConsoleOutput.SetOutputListBox(consoleLogs);

            labelService.Text = $"Обычный сотрудник: {service.Name}";
            labelVeterinarian.Text = $"Ветеринар: {veterinarian.Name}";

            label6.Text = $"Авто: {(isAutoUpdate ? "да" : "нет")}";

            dogsToShow = dogs;
            dogsList.DataSource = new BindingSource(dogsToShow, null);

            dayContext.AddObserver(service);
            dayContext.AddObserver(veterinarian);

            foreach(Dog dog in dogsToShow)
            {
                dayContext.AddObserver(dog);
            }
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
            // утро -> проверка у ветеринара -> уборка вольеров -> день -> вечер -> утро
            dayContext.Request(dogsToShow);

            dogsList.DataSource = new BindingSource(dogsToShow, null);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnNextDayState.Enabled = true;
            button1.Enabled = true;
            System.Threading.Tasks.Task.Run(() =>
            {
                while (true)
                {
                    if (isAutoUpdate)
                    {
                        Invoke(new Action(() => { btnNextDayState.PerformClick(); }));
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnNextDayState.Enabled = false;
            this.Close();
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            consoleLogs.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isAutoUpdate = !isAutoUpdate;
            label6.Text = $"Авто: {(isAutoUpdate ? "да" : "нет")}";
        }
    }
}
