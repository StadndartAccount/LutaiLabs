using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FarmDog.classes;

namespace FarmDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dogsList.ValueMember = "Value";
            dogsList.DisplayMember = "Key";
        }

        private void btnAddDog_Click(object sender, EventArgs e)
        {
            if(textBoxName.TextLength > 0)
            {
                string name = textBoxName.Text;
                int age = trackBarAge.Value;
                bool isHungry = checkBoxHunger.Checked;
                bool isHealthy = checkBoxHealth.Checked;

                Dog dog = new Dog(name, age, isHungry, isHealthy);
                dogsList.Items.Add(new KeyValuePair<string, Dog>(getDogStatus(dog), dog));

                ClearFormsFields();
            } else
            {
                MessageBox.Show("Кличка не должна быть пустой");
            }
            dogsNumber.Text = dogsList.Items.Count.ToString();
        }

        void ClearFormsFields()
        {
            textBoxName.Text = "";
            checkBoxHealth.Checked = false;
            checkBoxHunger.Checked = false;
            trackBarAge.Value = trackBarAge.Minimum;
        }

        string getDogStatus(Dog dog)
        {
            return $"{dog.Name} Возраст: {dog.Age} ({(dog.IsHungry ? "Голодный" : "Сытый")}," +
                    $" {(dog.IsHealthy ? "Здоровый" : "Больной")}," +
                    $" {(dog.IsTrained ? "Дрессированый" : "Недрессированный")})";
        }

        private void btnSetDefaultList_Click(object sender, EventArgs e)
        {
            dogsList.Items.Clear();

            List<Dog> defaultDogsList = new List<Dog> { 
                new Dog("Бобик", 1, false, true),
                new Dog("Шарик", 1, false, true),
                new Dog("Вольт", 1, false, true),
                new Dog("Умка", 1, false, true),
                new Dog("Грей", 1, false, true),
                new Dog("Лада", 1, false, true),
                new Dog("Герда", 1, false, true)
            };

            defaultDogsList.ForEach((dog) =>
            {
                dogsList.Items.Add(new KeyValuePair<string, Dog>(getDogStatus(dog), dog));
            });

            dogsNumber.Text = dogsList.Items.Count.ToString();
        }
    }
}