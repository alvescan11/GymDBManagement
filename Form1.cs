using Microsoft.Data.SqlClient;
using System.Data;

namespace Laborator1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=ALEX\SQLEXPRESS;Database=Gym1;
                Integrated Security=true;TrustServerCertificate=true;";
        DataSet ds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show(connection.State.ToString());
                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM " +
                        "SalaFitness", connection);
                    parentAdapter.Fill(ds, "SalaFitness");
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM " +
                        "Antrenor", connection);
                    childAdapter.Fill(ds, "Antrenor");
                    DataColumn parentColumn = ds.Tables["SalaFitness"].Columns["id"];
                    DataColumn childColumn = ds.Tables["Antrenor"].Columns["id"];
                    DataRelation relation = new DataRelation("FK_SalaFitness_Antrenor",
                        parentColumn, childColumn);
                    ds.Relations.Add(relation);
                    parentBS.DataSource = ds.Tables["SalaFitness"];
                    dataGridParent.DataSource = parentBS;
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "FK_SalaFitness_Antrenor";
                    dataGridChild.DataSource = childBS;
                    textBox1.DataBindings.Add("Text", parentBS, "nume");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridChild.SelectedRows.Count > 0)
            {
                // Get the selected row index and the primary key value
                int selectedIndex = dataGridChild.SelectedRows[0].Index;
                int primaryKeyValue = (int)dataGridChild.SelectedRows[0].Cells["idAnt"].Value;

                // Remove the selected row from the DataTable
                ds.Tables["Antrenor"].Rows.RemoveAt(selectedIndex);

                // Delete the row from the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Antrenor WHERE idAnt = @idAnt", connection);
                    command.Parameters.AddWithValue("@idAnt", primaryKeyValue);
                    command.ExecuteNonQuery();
                }
                childBS.DataSource = parentBS;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridChild.SelectedRows.Count > 0)
            {
                // Get the selected row index and the primary key value
                int selectedIndex = dataGridChild.SelectedRows[0].Index;
                int primaryKeyValue = (int)dataGridChild.SelectedRows[0].Cells["idAnt"].Value;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Deschidem conexiunea si cream comanda
                        connection.Open();
                        SqlCommand updateComand = new SqlCommand("UPDATE Antrenor SET " +
                            "numeAnt=@numeAnt, prenumeAnt=@prenumeAnt, id=@id WHERE idAnt=@idAnt", connection);
                        String numeAnt = textBox2.Text;
                        String prenumeAnt = textBox3.Text;
                        String id = textBox4.Text;

                        updateComand.Parameters.AddWithValue("@idAnt", primaryKeyValue);
                        updateComand.Parameters.AddWithValue("@numeAnt", numeAnt);
                        updateComand.Parameters.AddWithValue("@prenumeAnt", prenumeAnt);
                        updateComand.Parameters.AddWithValue("@id", id);

                        updateComand.ExecuteNonQuery();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();


                        MessageBox.Show("Update succeded!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
    }
}

