using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;

namespace it_School
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //
        // Методы для отображения элементов таблиц
        //
        private async void DisplayClassroom()
        {
                DataTable data = new DataTable();
                var filter = new BsonDocument();
                int count = 0;
                using (var cursor = await DBConnection.Classroom.FindAsync(filter))
                {
                    while (await cursor.MoveNextAsync())
                    {
                        var document = cursor.Current;

                        data.Columns.Add("pid_classroom", typeof(int));
                        data.Columns.Add("fid_school", typeof(int));

                        foreach (var item in document)
                        {
                            data.Rows.Add(item["pid_classroom"],
                                item["fid_school"]);
                        }
                        count++;
                    }
                    dataGridView2.DataSource = data;
                }
        }

        private async void DisplayGroups()
        {
            DataTable data = new DataTable();
            var filter = new BsonDocument();
            int count = 0;
            using (var cursor = await DBConnection.Groups.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var document = cursor.Current;

                    data.Columns.Add("pid_group", typeof(int));
                    data.Columns.Add("pupil_quantity", typeof(int));
                    data.Columns.Add("year_of_study", typeof(int));

                    foreach (var item in document)
                    {
                        data.Rows.Add(item["pid_group"],
                            item["pupil_quantity"],
                            item["year_of_study"]);
                    }
                    count++;
                }
                dataGridView2.DataSource = data;
            }
        }

        private async void DisplayStaff()
        {
            DataTable data = new DataTable();
            var filter = new BsonDocument();
            int count = 0;
            using (var cursor = await DBConnection.Staff.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var document = cursor.Current;

                    data.Columns.Add("pid_staff", typeof(int));
                    data.Columns.Add("fid_school", typeof(int));
                    data.Columns.Add("s_surname", typeof(string));
                    data.Columns.Add("s_name", typeof(string));
                    data.Columns.Add("s_patronymic", typeof(string));
                    data.Columns.Add("post", typeof(string));
                    data.Columns.Add("salary", typeof(decimal));
                    data.Columns.Add("date_of_birth", typeof(DateTime));
                    data.Columns.Add("address", typeof(string));
                    data.Columns.Add("phone_number", typeof(decimal));
                    data.Columns.Add("email", typeof(string));
                    data.Columns.Add("gender", typeof(string));
                    data.Columns.Add("active", typeof(bool));
                    data.Columns.Add("description", typeof(string));

                    foreach (var item in document)
                    {
                        data.Rows.Add(
                            item["pid_staff"],
                            item["fid_school"],
                            item["s_surname"],
                            item["s_name"],
                            item["s_patronymic"],
                            item["post"],
                            item["salary"],
                            item["date_of_birth"],
                            item["address"],
                            item["phone_number"],
                            item["email"],
                            item["gender"],
                            item["active"],
                            item["description"]);
                    }
                    count++;
                }
                dataGridView2.DataSource = data;
            }
        }

        private async void DisplayCurriculum()
        {
            DataTable data = new DataTable();
            var filter = new BsonDocument();
            int count = 0;
            using (var cursor = await DBConnection.Curriculum.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var document = cursor.Current;

                    data.Columns.Add("pid_major", typeof(int));
                    data.Columns.Add("duration", typeof(decimal));
                    data.Columns.Add("subjects", typeof(string));
                    data.Columns.Add("year_of_study", typeof(int));

                    foreach (var item in document)
                    {
                        data.Rows.Add(item["pid_major"],
                            item["duration"],
                            item["subjects"],
                            item["year_of_study"]);
                    }
                    count++;
                }
                dataGridView2.DataSource = data;
            }
        }

        private async void DisplayTeachers()
        {
            DataTable data = new DataTable();
            var filter = new BsonDocument();
            int count = 0;
            using (var cursor = await DBConnection.Teachers.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var document = cursor.Current;

                    data.Columns.Add("fid_staff", typeof(int));
                    data.Columns.Add("fid_group", typeof(int));

                    foreach (var item in document)
                    {
                        data.Rows.Add(item["fid_staff"],
                            item["fid_group"]);
                    }
                    count++;
                }
                dataGridView2.DataSource = data;
            }
        }

        private async void DisplayContract()
        {
            DataTable data = new DataTable();
            var filter = new BsonDocument();
            int count = 0;
            using (var cursor = await DBConnection.Contract.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var document = cursor.Current;

                    data.Columns.Add("pid_contract", typeof(int));
                    data.Columns.Add("date_of_creation", typeof(DateTime));
                    data.Columns.Add("monetary_condition", typeof(decimal));
                    data.Columns.Add("type", typeof(string));
                    data.Columns.Add("fid_group", typeof(int));
                    data.Columns.Add("fid_student", typeof(int));
                    data.Columns.Add("id_major", typeof(int));
                    data.Columns.Add("duties", typeof(string));

                    foreach (var item in document)
                    {
                        data.Rows.Add(
                            item["pid_contract"],
                            item["date_of_creation"],
                            item["monetary_condition"],
                            item["type"],
                            item["fid_group"],
                            item["fid_student"],
                            item["id_major"],
                            item["duties"]);
                    }
                    count++;
                }
                dataGridView2.DataSource = data;
            }
        }

        private async void DisplayStudent()
        {
            DataTable data = new DataTable();
            var filter = new BsonDocument();
            int count = 0;
            using (var cursor = await DBConnection.Students.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var document = cursor.Current;

                    data.Columns.Add("pid_student", typeof(int));
                    data.Columns.Add("s_surname", typeof(string));
                    data.Columns.Add("s_name", typeof(string));
                    data.Columns.Add("s_patronymic", typeof(string));
                    data.Columns.Add("phone_number", typeof(decimal));
                    data.Columns.Add("date_of_birth", typeof(DateTime));
                    data.Columns.Add("description", typeof(string));
                    data.Columns.Add("gender", typeof(string));
                    data.Columns.Add("pc", typeof(bool));
                    data.Columns.Add("payment", typeof(bool));

                    foreach (var item in document)
                    {
                        data.Rows.Add(
                            item["pid_student"],
                            item["s_surname"],
                            item["s_name"],
                            item["s_patronymic"],
                            item["phone_number"],
                            item["date_of_birth"],
                            item["description"],
                            item["gender"],
                            item["pc"],
                            item["payment"]);
                    }
                    count++;
                }
                dataGridView2.DataSource = data;
            }
        }

        private async void DisplayParents()
        {
            DataTable data = new DataTable();
            var filter = new BsonDocument();
            int count = 0;
            using (var cursor = await DBConnection.Parents.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var document = cursor.Current;

                    data.Columns.Add("fid_student", typeof(int));
                    data.Columns.Add("p_surname", typeof(string));
                    data.Columns.Add("p_name", typeof(string));
                    data.Columns.Add("p_patronymic", typeof(string));
                    data.Columns.Add("phone_number", typeof(decimal));
                    data.Columns.Add("address", typeof(string));

                    foreach (var item in document)
                    {
                        data.Rows.Add(
                            item["fid_student"],
                            item["p_surname"],
                            item["p_name"],
                            item["p_patronymic"],
                            item["phone_number"],
                            item["address"]);
                    }
                    count++;
                }
                dataGridView2.DataSource = data;
            }
        }
        
        //Действия при открытии окна
        private void MainForm_Load(object sender, EventArgs e)
        {
            int it = 0;
            dataGridView1.ColumnCount = 10;
            //достаём названия таблиц из базы данных School
            foreach (BsonDocument collection in DBConnection.School.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
            {
                string name = collection["name"].AsString;
                dataGridView1.Columns[it++].Name = name;
            }
        }

        //После нажания на название таблицы, вызываются функция заполнения таблицы данных
        //соответствующая названию таблицы
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    var ht = dataGridView1.HitTest(e.X, e.Y);
                    string tab = dataGridView1.Columns[ht.ColumnIndex].HeaderText;
                    switch (tab)
                    {
                        //Если выбрана таблица "classroom" в верхней таблице
                        case "classroom":
                            {
                                //то вызывается функция заполнения нижней таблицы данных
                                DisplayClassroom();
                                break;
                            }
                        case "groups":
                            {
                                DisplayGroups();
                                break;
                            }
                        case "staff":
                            {
                                DisplayStaff();
                                break;
                            }
                        case "curriculum":
                            {
                                DisplayCurriculum();
                                break;
                            }
                        case "teachers":
                            {
                                DisplayTeachers();
                                break;
                            }
                        case "contract":
                            {
                                DisplayContract();
                                break;
                            }
                        case "student":
                            {
                                DisplayStudent();
                                break;
                            }
                        case "parents":
                            {
                                DisplayParents();
                                break;
                            }
                        //case "equipement":
                        //    {
                        //        DisplayEquipement();
                        //        break;
                        //    }
                        //case "school":
                        //    {
                        //        DisplaySchool();
                        //        break;
                        //    }
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Display Data Error: " + ex);
            }
        }
        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        //INSERT пока не работает
        private void insert_button_Click(object sender, EventArgs e)
        {
            var student = new Student();
            student.pid_student = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            student.s_surname = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            student.s_name = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            student.s_patronymic = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            student.phone_number = long.Parse(dataGridView2.CurrentRow.Cells[4].Value.ToString());
            student.date_of_birth = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            student.description = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            student.gender = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            student.pc = bool.Parse(dataGridView2.CurrentRow.Cells[8].Value.ToString());
            student.payment = bool.Parse(dataGridView2.CurrentRow.Cells[9].Value.ToString());

            var stream1 = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(Student));
            ser.WriteObject(stream1, student);
            stream1.Position = 0;
            var sr = new StreamReader(stream1);
            dataGridView1.DataSource = sr;
            //await collection.InsertOneAsync(DBConnection.Students.==);
        }
    }
}
    
