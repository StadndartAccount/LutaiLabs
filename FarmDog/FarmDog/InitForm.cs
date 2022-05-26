using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FarmDog.Objects;

namespace FarmDog
{
    public partial class InitForm : Form
    {
        List<Dog> dogs = new List<Dog>();
        public InitForm()
        {
            InitializeComponent();
            
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            if(textBoxName.TextLength <= 0)
            {
                MessageBox.Show("Кличка не должна быть пустой!");
                return;
            }

            string name = textBoxName.Text;
            int age = trackBarAge.Value;
            bool isFed = checkBoxFed.Checked;
            bool isHealthy = checkBoxHealth.Checked;

            Dog dog = new Dog(name, age, isFed, isHealthy);
            dogs.Add(dog);

            dogsNumber.Text = dogsList.Items.Count.ToString();

            dogsList.DataSource = new BindingSource(dogs, null);
            dogsList.Refresh();

            ClearFormsFields();
        }

        void ClearFormsFields()
        {
            textBoxName.Text = "";
            checkBoxHealth.Checked = false;
            checkBoxFed.Checked = false;
            trackBarAge.Value = trackBarAge.Minimum;
        }


        private void btnSetDefaultList_Click(object sender, EventArgs e)
        {
            dogs.Clear();

            List<Dog> defaultDogsList = new List<Dog> { 
                new Dog("Бобик", 1, false, true),
                new Dog("Шарик", 5, false, true),
                new Dog("Умка", 10, false, true),
            };

            dogs.AddRange(defaultDogsList);

            dogsList.DataSource = new BindingSource(dogs, null);
            dogsList.Refresh();

            dogsNumber.Text = dogs.Count.ToString();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            if (dogs.Count <= 0)
            {
                MessageBox.Show("Массив животных не может быть пустым!");
                return;
            }
                
            MainForm main = new MainForm(dogs);

            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnRandomDog_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string name = dogsNames[random.Next(0, dogsNames.Length)];
            int age = random.Next(1, 15);
            bool isFed = random.Next(100) <= 50 ? true : false;
            bool isHealthy = random.Next(100) <= 50 ? true : false;

            textBoxName.Text = name;
            trackBarAge.Value = age;
            checkBoxFed.Checked = isFed;
            checkBoxFed.Checked = isHealthy;

            Dog dog = new Dog(name, age, isFed, isHealthy);
            dogs.Add(dog);


            dogsList.DataSource = new BindingSource(dogs, null);
            dogsList.Refresh();

            dogsNumber.Text = dogsList.Items.Count.ToString();
        }

        string[] dogsNames =
        {
            "Макс",
            "Майло",
            "Марсель",
            "Малыш",
            "Майк",
            "Мёрфи",
            "Макси",
            "Мартин",
            "Микки",
            "Марс",
            "Мухтар",
            "Мотя",
            "Марти",
            "Мики",
            "Мэни",
            "Марсик",
            "Майкл",
            "Марк",
            "Максик",
            "Мейсон",
            "Майки",
            "Митяй",
            "Мустанг",
            "Марик",
            "Мич",
            "Маврик",
            "Мэлвин",
            "Маркус",
            "Монти",
            "Лео",
            "Лайк",
            "Лари",
            "Локки",
            "Люцифер",
            "Лайт",
            "Ларс",
            "Лаки Стар",
            "Лексус",
            "Лайм",
            "Лeйк",
            "Люк",
            "Лютик",
            "Лион",
            "Луи",
            "Лукас",
            "Ларик",
            "Лойд",
            "Каспер",
            "Кекс",
            "Кузя",
            "Кай",
            "Кент",
            "Карат",
            "Клайд",
            "Кокс",
            "Красавчик",
            "Крис",
            "Кастиэль",
            "Кексик",
            "Кайл",
            "Космос",
            "Курт",
            "Князь",
            "Кубик",
            "Купер",
            "Кэп",
            "Коди",
            "Крош",
            "Кузька",
            "Кнопик",
            "Кирюша",
            "Руслан",
            "Кырус",
            "Кутя",
            "Клык",
            "Кинг",
            "Клаус",
            "Карай",
            "Кольт",
            "Кайзер",
            "Кэш"
        };
    }
}