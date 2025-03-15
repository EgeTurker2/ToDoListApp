using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Speech.Recognition;

namespace ToDoListApp
{
    public partial class frmToDoList : Form
    {
        private List<string> tasks = new List<string>();
        public frmToDoList()
        {
            InitializeComponent();
            lstTasks.DrawMode = DrawMode.OwnerDrawFixed;
            lstTasks.DrawItem += new DrawItemEventHandler(lstTasks_DrawItem);
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
            if(lstTasks.SelectedItem != null)
            {
                string selectedTask = lstTasks.SelectedItem.ToString();//Selecting an Item
                lstTasks.Items.Remove(lstTasks.SelectedItem);//Removing the selected Item
                tasks.Remove(selectedTask);
                UpdateTaskCount();
                SaveToTxt();
            }
        }
        private void SaveToTxt()
        {
            try
            {
                List<string> taskData = tasks.Select(t =>
                    (t.StartsWith("✅ ") ? "✅ " : "") + t).ToList();//Saving the task the way I wanted it to be saved as

                File.WriteAllLines("tasks.txt", taskData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if(lstTasks.SelectedIndex != -1)
            {
                int index = lstTasks.SelectedIndex;
                string selectedTask = tasks[index];

                if(!selectedTask.StartsWith("✅ "))//If the selected Item does not contain tick it will skip ip
                {
                    tasks[index] = "✅ " + selectedTask;
                    lstTasks.Items[index] = "✅ " + selectedTask;
                    SaveToTxt() ;
                }
                else
                {
                    MessageBox.Show("This task is already marked as completed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblTotalTasks_Click(object sender, EventArgs e)
        {

        }
        private void UpdateTaskCount()
        {
            lblTotalTasks.Text = $"Total Tasks : {tasks.Count}";//Keeps the tasks counted
        }
        private void frmToDoList_Load(object sender, EventArgs e)
        {
            RedRadioButton.Checked = true;//I wanted the default to be red
            lstTasks.DrawMode = DrawMode.OwnerDrawFixed;

            InitializeVoiceRecognition();//Voice recognition feature initialization
        }
        private string GetSelectedPriority()//Holds the information of the radio button for further purposes
        {
            if (RedRadioButton.Checked)
                return "Red";
            else if (BlueRadioButton.Checked)
                return "Blue";
            else if (GreenRadioButton.Checked)
                return "Green";
            else
                return "No Priority";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userInput = txtTask.Text.Trim();

            if (!string.IsNullOrEmpty(userInput))
            {
                string priority = GetSelectedPriority();//Retrieves the information
                string taskWithPriority = userInput;
                Color taskcolor = Color.Black;

                if(RedRadioButton.Checked)
                    taskcolor = Color.Red;
                else if(BlueRadioButton.Checked)
                    taskcolor = Color.Blue;
                else if(GreenRadioButton.Checked)
                    taskcolor = Color.Green;
                DateTime now = DateTime.Now;

                ColoredTask newTask = new ColoredTask(userInput, taskcolor, priority, false);
                newTask.CreatedAt = now;//DateTime for now

                lstTasks.Items.Add(newTask);
                tasks.Add($"{userInput} - {now:yyyy-MM-dd HH:mm:ss}");//I wanted this to be written in this format
                lstTasks.ForeColor = taskcolor;

                SaveToTxt();
                txtTask.Clear();
                UpdateTaskCount();
            }
            else
            {
                MessageBox.Show("Please enter a task!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int index = lstTasks.SelectedIndex;
                string selectedTask = tasks[index];

                txtTask.Text = selectedTask;

                string taskPriority = selectedTask.StartsWith("✅") ? selectedTask.Substring(12) : selectedTask;

                if (taskPriority.Contains("Red"))//With this code it will still remain as its original 
                    RedRadioButton.Checked = true;
                else if (taskPriority.Contains("Blue"))
                    BlueRadioButton.Checked = true;
                else if (taskPriority.Contains("Green"))
                    GreenRadioButton.Checked = true;
            }
            else
            {
                MessageBox.Show("Please select a task to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public class ColoredTask
        {
            public string Task { get; set; }//This is for changing the colors
            public Color TaskColor { get; set; }
            public string Priority { get; set; }
            public bool IsCompleted { get; set; }
            public DateTime CreatedAt { get; set; } 

            public ColoredTask(string task, Color color, string priority, bool isCompleted)
            {
                Task = task;
                TaskColor = color;
                Priority = priority;
                IsCompleted = isCompleted;
                CreatedAt = DateTime.Now; 
            }

            public override string ToString()
            {
                return $"{Task} - {CreatedAt:yyyy-MM-dd HH:mm:ss}";
            }
        }
        private void lstTasks_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            var task = lstTasks.Items[e.Index] as ColoredTask;
            if (task != null)
            {
                e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);//I used rectangle for coloring
                e.Graphics.DrawString($"{task.Task} - {task.CreatedAt:yyyy-MM-dd HH:mm:ss}",
                    e.Font, new SolidBrush(task.TaskColor), e.Bounds);
            }
        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)//I couldn't change the backcolor of the form even if I change it
        {
            if (chkDarkMode.Checked)
            {
                // Dark mode: Set dark theme for the form
                this.BackColor = Color.FromArgb(30, 30, 30); // Dark background for the form
                lblTotalTasks.ForeColor = Color.White; // White text for labels
                txtTask.BackColor = Color.FromArgb(50, 50, 50); // Dark text box background
                txtTask.ForeColor = Color.White; // White text for the text box
                lstTasks.BackColor = Color.FromArgb(50, 50, 50); // Dark list box background
                //lstTasks.ForeColor = Color.White; // White text for the list box
                btnAdd.BackColor = Color.FromArgb(60, 60, 60); // Dark button background
                btnAdd.ForeColor = Color.White; // White text for button
                btnDelete.BackColor = Color.FromArgb(60, 60, 60); // Dark button background
                btnDelete.ForeColor = Color.White; // White text for button
                btnMarkComplete.BackColor = Color.FromArgb(60, 60, 60); // Dark button background
                btnMarkComplete.ForeColor = Color.White; // White text for button
            }
            else
            {
                // Light mode: Set light theme for the form
                this.BackColor = Color.White; // Light background for the form
                lblTotalTasks.ForeColor = Color.Black; // Black text for labels
                txtTask.BackColor = Color.White; // Light text box background
                txtTask.ForeColor = Color.Black; // Black text for the text box
                lstTasks.BackColor = Color.White; // Light list box background
                //lstTasks.ForeColor = Color.Black; // Black text for the list box
                btnAdd.BackColor = Color.FromArgb(240, 240, 240); // Light button background
                btnAdd.ForeColor = Color.Black; // Black text for button
                btnDelete.BackColor = Color.FromArgb(240, 240, 240); // Light button background
                btnDelete.ForeColor = Color.Black; // Black text for button
                btnMarkComplete.BackColor = Color.FromArgb(240, 240, 240); // Light button background
                btnMarkComplete.ForeColor = Color.Black; // Black text for button
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)//Edited tasks will be saved
        {
            if (lstTasks.SelectedIndex != -1)
            {
                int index = lstTasks.SelectedIndex;
                string updatedTask = txtTask.Text.Trim();

                if (!string.IsNullOrEmpty(updatedTask))
                {
                    string priority = GetSelectedPriority();
                    Color taskColor = Color.Black;

                    if (RedRadioButton.Checked)
                        taskColor = Color.Red;
                    else if (BlueRadioButton.Checked)
                        taskColor = Color.Blue;
                    else if (GreenRadioButton.Checked)
                        taskColor = Color.Green;
                    ColoredTask updatedColoredTask = new ColoredTask(updatedTask, taskColor, priority, false);
                    tasks[index] = updatedTask;
                    lstTasks.Items[index] = updatedColoredTask;
                    lstTasks.Invalidate();

                    SaveToTxt();
                    UpdateTaskCount();
                    txtTask.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid task!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private SpeechRecognitionEngine recognizer;

        private void InitializeVoiceRecognition()//I am not sure if it's working
        {
            recognizer = new SpeechRecognitionEngine();
            recognizer.SetInputToDefaultAudioDevice();

            Choices commands = new Choices();
            commands.Add(new string[] { "add task", "delete task", "mark complete" });//I added several commands here

            Grammar grammar = new Grammar(new GrammarBuilder(commands));
            recognizer.LoadGrammar(grammar);

            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string command = e.Result.Text;

            if (command == "add task")//It will execute the btnAdd and other commands when Voice recognition recognizes any of them
            {
                if (!string.IsNullOrEmpty(txtTask.Text))
                {
                    btnAdd.PerformClick();
                }
            }
            else if (command == "delete task")
            {
                if (lstTasks.SelectedIndex != -1)
                {
                    btnDelete.PerformClick();
                }
            }
            else if (command == "mark complete")
            {
                if (lstTasks.SelectedIndex != -1)
                {
                    btnMarkComplete.PerformClick();
                }
            }
        }

        private void btnCustomTheme_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Change the background of the form and all controls except the ListBox
                    this.BackColor = colorDialog.Color;          // Form background
                    lstTasks.BackColor = SystemColors.Window;    // Do not change the background of the ListBox
                    txtTask.BackColor = SystemColors.Window;     // Do not change the TextBox background
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
