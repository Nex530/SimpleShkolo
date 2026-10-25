namespace ClassStudent
{
    public partial class Form1 : Form
    { 
       
        public Form1()
        {
            InitializeComponent();

        }
        Student student1 = new Student("Georgi", new List<int> { }, "11E");
        class Student
        {
            public string name="prazno ime";
            public string Class="1a";
            public List<int> grades = new List<int>();
            public Student(string nameinput, List<int> gradesinput, string Classinput)
            {
                name = nameinput;
                grades = gradesinput;
                Class = Classinput;
            }
            public double AverageGrade()
            {
                double averageGrade = 0;
                double sum = 0;
                double count = grades.Count;
                for (int i = 0; i < count; i++)
                {
                    sum += grades[i];
                }
                averageGrade = sum / count;
                return averageGrade;
            }
            public void addGrade(string ocenka)
            {
                if (ocenka == "2" || ocenka == "3" || ocenka == "4" || ocenka == "5" || ocenka == "6")
                {
                    this.grades.Add(int.Parse(ocenka));

                }
                else
                {
                    MessageBox.Show("Въведете оценкa от 2 до 6.");
                }
            }
            public string ShowInfo()
            {
                return ("Име: " + name + "\r\nКлас: " + Class + "\r\nСреден успех: " + AverageGrade());
            }
        }

            private void button1_Click(object sender, EventArgs e)
            {

            string ocenka = textBox3.Text.ToString();
            student1.addGrade(ocenka);
                textBox1.Text = student1.ShowInfo();


        }
    }
}
