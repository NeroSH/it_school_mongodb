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

        //private static async Task Find(IMongoCollection<BsonDocument> collection)
        //{
        //    //var filter = DBConnection.Classroom;
        //    var people = await collection.Find(DBConnection.Classroom).ToListAsync();
        //    foreach (var p in people)
        //    {
        //        Console.WriteLine(p);
        //    }
        //}

        //private static async Task<bool> UpdateProductsAsync()
        //{
        //    // Create client connection to our MongoDB database
        //    var client = new MongoClient(MongoDBConnectionString);
        //    BsonDocument stun = new BsonDocument({ 
        //        "name",
        //        ""
        //    });
        //    // Create the collection object that represents the "products" collection
        //    var database = client.GetDatabase("MongoDBStore");
        //    var products = database.GetCollection<Product>("products");

        //    // Clean up the collection if there is data in there
        //    await database.DropCollectionAsync("products");

        //    // collections can't be created inside a transaction so create it first
        //    await database.CreateCollectionAsync("products");

        //    // Create a session object that is used when leveraging transactions
        //    using (var session = await client.StartSessionAsync())
        //    {
        //        // Begin transaction
        //        session.StartTransaction();

        //        try
        //        {
        //            // Create some sample data
        //            var tv = new Product
        //            {
        //                Description = "Television",
        //                SKU = 4001,
        //                Price = 2000
        //            };
        //            var book = new Product
        //            {
        //                Description = "A funny book",
        //                SKU = 43221,
        //                Price = 19.99
        //            };
        //            var dogBowl = new Product
        //            {
        //                Description = "Bowl for Fido",
        //                SKU = 123,
        //                Price = 40.00
        //            };

        //            // Insert the sample data 
        //            await products.InsertOneAsync(session, tv);
        //            await products.InsertOneAsync(session, book);
        //            await products.InsertOneAsync(session, dogBowl);

        //            var resultsBeforeUpdates = await products
        //                          .Find<Product>(session, Builders<Product>.Filter.Empty)
        //                          .ToListAsync();
        //            Console.WriteLine("Original Prices:\n");
        //            foreach (Product d in resultsBeforeUpdates)
        //            {
        //                Console.WriteLine(
        //                          String.Format("Product Name: {0}\tPrice: {1:0.00}",
        //                                d.Description, d.Price)
        //                );
        //            }

        //            // Increase all the prices by 10% for all products
        //            var update = new UpdateDefinitionBuilder<Product>()
        //                   .Mul<Double>(r => r.Price, 1.1);
        //            await products.UpdateManyAsync(session,
        //                   Builders<Product>.Filter.Empty,
        //                   update); //,options);

        //            // Made it here without error? Let's commit the transaction
        //            await session.CommitTransactionAsync();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Error writing to MongoDB: " + e.Message);
        //            await session.AbortTransactionAsync();
        //            return false;
        //        }

        //        // Let's print the new results to the console
        //        Console.WriteLine("\n\nNew Prices (10% increase):\n");
        //        var resultsAfterCommit = await products
        //               .Find<Product>(session, Builders<Product>.Filter.Empty)
        //               .ToListAsync();
        //        foreach (Product d in resultsAfterCommit)
        //        {
        //            Console.WriteLine(
        //                String.Format("Product Name: {0}\tPrice: {1:0.00}",
        //                                         d.Description, d.Price)
        //            );
        //        }

        //        return true;
        //    }
        //}

        private async void MainForm_Load(object sender, EventArgs e)
        {
            //var collections = new JavaScriptSerializer();
            //ta
            //tabs.Serialize();
            //var data = collections.SelectMany(pair => ((object[])pair.Value));

            //var dt = new DataTable();

            //dt.Columns.Add(tabs[0].ToString(), typeof(string)).ReadOnly = true;
            //FindPeople().GetAwaiter().GetResult();
            var stream1 = new MemoryStream();
            stream1.Position = 0;
            //var p2 = (Student)new DataContractJsonSerializer(typeof(Student)).ReadObject(DBConnection.Classroom);
            //List<Student> tab = BsonSerializer.Deserialize<List<Student>>(DBConnection.Students.Watch());
            var st = DBConnection.Students.DocumentSerializer;
            //    var sr = new StreamReader(stream1);
            //List<string> collections = new List<string>();
            int it = 0;
            dataGridView1.ColumnCount = 10;
            List<BsonDocument> tables = new List<BsonDocument>();
            foreach (BsonDocument collection in DBConnection.School.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
            {
                tables.Add(collection);
                string name = collection["name"].AsString;
                dataGridView1.Columns[it++].Name = name;
            }
            //var t = DBConnection.School.GetCollection<Student>("student");//.Find(FilterDefinition<BsonDocument>.Empty);
            
            //for (int j = 0; j < 10; j++)
            //{
            //    dataGridView1.Columns[j].Name = collections[j];
            //}
            //string tab = "classroom";
            //var filter = DBConnection.Classroom;
            ////var rows = new List<BsonElement>(tables);
            //foreach (BsonDocument data in DBConnection.School.GetCollection<BsonDocument>(tab).Find())
            //{
            //    int n = 50;
            //    //string name = data["name"].AsString;
            //    //collections.Add(name);
            //}

        }

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
        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                        case "classroom":
                            {
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
                        //case "teacheers":
                        //    {
                        //        DisplayTeachers();
                        //        break;
                        //    }
                        //case "contract":
                        //    {
                        //        DisplayContcract();
                        //        break;
                        //    }
                        //case "student":
                        //    {
                        //        DisplayStudent();
                        //        break;
                        //    }
                        //case "parents":
                        //    {
                        //        DisplayParents();
                        //        break;
                        //    }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

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
    
