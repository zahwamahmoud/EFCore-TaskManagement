using Microsoft.EntityFrameworkCore;
using Project_ef.model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project_ef.views
{
    public partial class fliterTask : Form
    {
        public fliterTask()
        {
            InitializeComponent();
            LoadStatusAndPriority();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadTasks();
        }
        private void LoadStatusAndPriority()
        {
            priorityFilterComboBox.DataSource = Enum.GetValues(typeof(Priority));

            statusFilterComboBox.DataSource = Enum.GetValues(typeof(Status));

            priorityFilterComboBox.SelectedIndex = -1;
            statusFilterComboBox.SelectedIndex = -1;
        }

        private void LoadTasks()
        {
            try
            {
                using (var context = new TaskManagementContext())
                {
                    var tasks = context.TaskItems
                        .Select(p => new
                        {
                            p.Id,
                            p.Title,
                            p.Description,
                            p.DueDate,
                            Status = p.Status.ToString(),
                            Priority = p.Priority.ToString(),
                            Category = p.Category.Name,
                            User = p.User.Name
                        }).ToList();

                    dataGridView1.DataSource = tasks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tasks: {ex.Message}");
            }
        }

        private void fliter_Click(object sender, EventArgs e)
        {
            using (var context = new TaskManagementContext())
            {
                var query = context.TaskItems.AsQueryable();



                if (statusFilterComboBox.SelectedItem is Status selectedStatus)
                {
                    query = query.Where(t => t.Status == selectedStatus);
                }

                if (priorityFilterComboBox.SelectedItem is Priority selectedPriority)
                {
                    query = query.Where(t => t.Priority == selectedPriority);
                }



                var filteredTasks = query.Select(t => new
                {
                    t.Id,
                    t.Title,
                    t.Description,
                    t.DueDate,
                    Status = t.Status.ToString(),
                    Priority = t.Priority.ToString(),
                    Category = t.Category.Name,
                    User = t.User.Name
                }).ToList();

                dataGridView1.DataSource = filteredTasks;
            }
        }

        private void fliterTask_Load(object sender, EventArgs e)
        {

        }

        private void back_op_Click(object sender, EventArgs e)
        {
            index n = new index();
            n.Show();
            this.Hide();
        }

        private async void sort_op_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TaskManagementContext())
                {
                    // Fetch tasks from the database and sort by DueDate
                    var tasks = await context.TaskItems
                        .Select(p => new
                        {
                            p.Id,
                            p.Title,
                            p.Description,
                            p.DueDate,
                            Status = p.Status.ToString(),
                            Priority = p.Priority.ToString(),
                            Category = p.Category.Name,
                            User = p.User.Name
                        })
                        .OrderBy(d => d.DueDate)
                        .ToListAsync(); // Execute the query asynchronously

                    // Bind the sorted tasks to the DataGridView
                    dataGridView1.DataSource = tasks;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show($"An error occurred while sorting tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void sort_des_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TaskManagementContext())
                {
                    // Fetch tasks from the database and sort by DueDate in descending order  
                    var tasks = await context.TaskItems
                        .Select(p => new
                        {
                            p.Id,
                            p.Title,
                            p.Description,
                            p.DueDate,
                            Status = p.Status.ToString(),
                            Priority = p.Priority.ToString(),
                            Category = p.Category.Name,
                            User = p.User.Name
                        })
                        .OrderByDescending(d => d.DueDate)
                        .ToListAsync();

                    dataGridView1.DataSource = tasks;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation  
                MessageBox.Show($"An error occurred while sorting tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
