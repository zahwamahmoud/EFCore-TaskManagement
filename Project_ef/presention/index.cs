using Microsoft.EntityFrameworkCore;
using Project_ef.model;
using Project_ef.views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Project_ef
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            priority.DataSource = Enum.GetValues(typeof(Priority));
            status.DataSource = Enum.GetValues(typeof(Status)); // This should be fine if Status is an enum  
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();

            try
            {
                using (var context = new TaskManagementContext())
                {
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
                        }).ToListAsync();

                    dataGridView1.DataSource = tasks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tasks: {ex.Message}");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            using (var context = new TaskManagementContext())
            {
                var st = textBox1.Text.ToLower();
                var filter = context.TaskItems
                    .Where(s => s.Title.ToLower().StartsWith(st))
                    .ToList();

                dataGridView1.DataSource = filter;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (var context = new TaskManagementContext())
            {
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
                    }).ToListAsync();

                dataGridView1.DataSource = tasks;
            }
        }

        private void LoadCategories()
        {
            using (var context = new TaskManagementContext())
            {
                var catg = context.Categories
                    .Select(d => new { Id = d.Id, Name = d.Name })
                    .ToList();

                categ.DataSource = catg;
                categ.DisplayMember = "Name";
                categ.ValueMember = "Id";
            }
        }

        private async void add_Op_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Date
                if (!DateTime.TryParse(date.Value.ToString(), out DateTime dueDate))
                {
                    MessageBox.Show("Please select a valid Due Date.");
                    return;
                }

                // Validate Input Fields
                if (string.IsNullOrWhiteSpace(title.Text))
                {
                    MessageBox.Show("Please enter a Title.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(desc.Text))
                {
                    MessageBox.Show("Please enter a Description.");
                    return;
                }

                // Validate Priority & Status
                if (!Enum.TryParse(priority.SelectedValue.ToString(), out Priority selectedPriority) ||
                    !Enum.TryParse(status.SelectedValue.ToString(), out Status selectedStatus))
                {
                    MessageBox.Show("Please select valid priority and status values.");
                    return;
                }

                // Validate Category Selection
                if (categ.SelectedValue == null || !int.TryParse(categ.SelectedValue.ToString(), out int categoryId))
                {
                    MessageBox.Show("Please select a valid category.");
                    return;
                }

                // Validate User Selection (Modify this based on your UI)
                int userId = 1;


                using (var context = new TaskManagementContext())
                {
                    // Check if the UserId exists in the database
                    var userExists = await context.Users.AnyAsync(u => u.Id == userId);
                    if (!userExists)
                    {
                        MessageBox.Show($"User with ID {userId} does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Create Task Object
                    TaskItem task = new TaskItem
                    {
                        Title = title.Text.Trim(),
                        Description = desc.Text.Trim(),
                        DueDate = dueDate,
                        Priority = selectedPriority,
                        Status = selectedStatus,
                        CategoryId = categoryId,
                        UserId = userId
                    };

                    // Save Task
                    context.TaskItems.Add(task);
                    int result = await context.SaveChangesAsync();

                    if (result > 0)
                    {
                        MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Task was not saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Exception: {ex}");
            }
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle category selection changes if necessary  
        }

        private void priority_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle priority selection changes if necessary  
        }

        private async void delete_Op_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a task to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get Task ID from selected row
                int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Ask for confirmation
                var confirmResult = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes)
                {
                    return; // If the user cancels, stop the function
                }

                using (var context = new TaskManagementContext())
                {
                    // Find task in the database
                    var taskToDelete = await context.TaskItems.FindAsync(taskId);
                    if (taskToDelete == null)
                    {
                        MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Delete task
                    context.TaskItems.Remove(taskToDelete);
                    await context.SaveChangesAsync();

                    // Show success message
                    MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void update_op_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a task to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get Task ID from selected row
                int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                using (var context = new TaskManagementContext())
                {
                    // Find task in the database
                    var taskToUpdate = await context.TaskItems.FindAsync(taskId);
                    if (taskToUpdate == null)
                    {
                        MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validate input fields
                    if (string.IsNullOrWhiteSpace(title.Text))
                    {
                        MessageBox.Show("Please enter a Title.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(desc.Text))
                    {
                        MessageBox.Show("Please enter a Description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DateTime dueDate;
                    if (!DateTime.TryParse(date.Value.ToString(), out dueDate))
                    {
                        MessageBox.Show("Please select a valid Due Date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update task properties
                    taskToUpdate.Title = title.Text.Trim();
                    taskToUpdate.Description = desc.Text.Trim();
                    taskToUpdate.DueDate = dueDate;

                    // Validate priority and status selection
                    if (!Enum.TryParse(priority.SelectedValue.ToString(), out Priority selectedPriority) ||
                        !Enum.TryParse(status.SelectedValue.ToString(), out Status selectedStatus))
                    {
                        MessageBox.Show("Please select valid priority and status values.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    taskToUpdate.Priority = selectedPriority;
                    taskToUpdate.Status = selectedStatus;

                    // Validate category selection
                    if (categ.SelectedValue is int categoryId)
                    {
                        taskToUpdate.CategoryId = categoryId;
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Save changes to the database
                    await context.SaveChangesAsync();

                    // Show success message
                    MessageBox.Show("Task updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TaskManagementContext())
                {
                    // Fetch and group tasks by status
                    var reportData = await context.TaskItems
                        .GroupBy(t => t.Status)
                        .Select(g => new
                        {
                            Status = g.Key.ToString(),
                            TaskCount = g.Count()
                        }).ToListAsync();

                    if (reportData.Count == 0)
                    {
                        MessageBox.Show("No task data available for reporting.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Display in DataGridView (if available)
                    dataGridView1.DataSource = reportData;

                    // Convert to a readable format
                    string reportText = "Task Status Report:\n\n";
                    foreach (var item in reportData)
                    {
                        reportText += $"{item.Status}: {item.TaskCount} tasks\n";
                    }

                    // Show report
                    MessageBox.Show(reportText, "Task Status Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fliter_Click(object sender, EventArgs e)
        {
            fliterTask t = new fliterTask();
            t.Show();
            this.Hide();
        }


     

        private void logout_op_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void reporting_op_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Load tasks from the database asynchronously
                var tasks = await LoadTasksFromDatabaseAsync();

                // Count tasks by status
                int pendingCount = tasks.Count(t => t.Status == Status.Pending);
                int inProgressCount = tasks.Count(t => t.Status == Status.InProgress);
                int completedCount = tasks.Count(t => t.Status == Status.Completed);

                int totalTasks = tasks.Count;

                // Generate a report message
                string reportMessage = $"Task Status Report:\n\n" +
                                       $"Total Tasks: {totalTasks}\n" +
                                       $"Pending: {pendingCount}\n" +
                                       $"In Progress: {inProgressCount}\n" +
                                       $"Completed: {completedCount}\n\n" +
                                       $"Percentage Completed: {(double)completedCount / totalTasks * 100:0.00}%";

                // Display the report in a message box
                MessageBox.Show(reportMessage, "Task Status Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<TaskItem>> LoadTasksFromDatabaseAsync()
        {
            using (var context = new TaskManagementContext())
            {
                return await context.TaskItems.ToListAsync();
            }
        }
    }
}
