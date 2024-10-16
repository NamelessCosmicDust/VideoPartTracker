using System.Media;
using System.Text.Json;

namespace VideoPartTracker
{
    internal partial class VideoPartTracker : Form
    {
        private string projectName = "";

        private int part = 1;
        private int chapter = 1;
        private int shot = 1;

        private bool isDarkMode = false;

        public VideoPartTracker()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
            LoadData();
            WireUpEventHandlers();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            partNumber.Text = part.ToString();
            chapNumber.Text = chapter.ToString();
            shotNumber.Text = shot.ToString();
        }

        private void LoadData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CountSave.json");
            SaveDataModel? data = null;

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonData = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        data = JsonSerializer.Deserialize<SaveDataModel>(jsonData);
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it as appropriate for your application
                    Console.WriteLine($"Error loading data: {ex.Message}");
                }
            }

            // Use null-coalescing operator to provide default values if data is null
            projectName = data?.ProjectName ?? "";
            part = data?.Part ?? 1;
            chapter = data?.Chapter ?? 1;
            shot = data?.Shot ?? 1;

            projectNameTextBox.Text = projectName;
            UpdateLabels();
        }

        private void SaveData()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CountSave.json");

            using StreamWriter writer = new(filePath);

            SaveDataModel data = new()
            {
                ProjectName = projectName,
                Part = part,
                Chapter = chapter,
                Shot = shot
            };

            // Serialize the object to JSON
            string jsonData = JsonSerializer.Serialize(data);

            writer.Write(jsonData);

        }

        private void WireUpEventHandlers()
        {
            partBtnUp.Click += PartNumUp;
            partBtnDn.Click += PartNumDown;
            chapBtnUp.Click += ChapNumUp;
            chapBtnDn.Click += ChapNumDown;
            shotBtnUp.Click += ShotNumUp;
            shotBtnDn.Click += ShotNumDown;
            soundBtn.Click += PlaySound;
            toggleThemeMenuItem.Click += ToggleTheme;
            projectNameTextBox.TextChanged += ProjectNameChange;
        }

        private void ProjectNameChange(object? sender, EventArgs e)
        {
            projectName = projectNameTextBox.Text;
            SaveData(); // Save automatically on text change
        }

        #region Button controls
        private void PartNumUp(object? sender, EventArgs e)
        {
            part++;
            UpdateLabels();
            SaveData();
        }

        private void PartNumDown(object? sender, EventArgs e)
        {
            if (part > 1)
            {
                part--;
                UpdateLabels();
                SaveData();
            }
        }

        private void ChapNumUp(object? sender, EventArgs e)
        {
            chapter++;
            UpdateLabels();
            SaveData();
        }

        private void ChapNumDown(object? sender, EventArgs e)
        {
            if (chapter > 1)
            {
                chapter--;
                UpdateLabels();
                SaveData();
            }
        }

        private void ShotNumUp(object? sender, EventArgs e)
        {
            shot++;
            UpdateLabels();
            SaveData();
        }

        private void ShotNumDown(object? sender, EventArgs e)
        {
            if (shot > 1)
            {
                shot--;
                UpdateLabels();
                SaveData();
            }
        }
        #endregion

        private void PlaySound(object? sender, EventArgs e)
        {
            string soundPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound.wav");

            if (File.Exists(soundPath))
            {
                using SoundPlayer player = new(soundPath);
                player.Play();
            }
            else
            {
                MessageBox.Show("Sound file not found in " + AppDomain.CurrentDomain.BaseDirectory, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleTheme(object? sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            Color backgroundColor = isDarkMode ? Color.Black : SystemColors.Control;
            Color foregroundColor = isDarkMode ? Color.White : SystemColors.ControlText;
            Color buttonColor = isDarkMode ? Color.DarkGray : SystemColors.Control;

            Color menuBarColor = isDarkMode ? Color.Black : SystemColors.Control;
            Color menuTextColor = isDarkMode ? Color.White : SystemColors.ControlText;

            Color projectNameBoxColor = isDarkMode ? Color.Black : SystemColors.Control;
            Color projectNameTextColor = isDarkMode ? Color.White : SystemColors.ControlText;

            BackColor = backgroundColor;
            ForeColor = foregroundColor;

            menuStrip.BackColor = menuBarColor;
            menuStrip.ForeColor = menuTextColor;

            projectNameTextBox.BackColor = projectNameBoxColor;
            projectNameTextBox.ForeColor = projectNameTextColor;

            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                item.BackColor = menuBarColor;
                item.ForeColor = menuTextColor;
            }

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.BackColor = buttonColor;
                    control.ForeColor = foregroundColor;
                }
                else if (control is Label)
                {
                    control.ForeColor = foregroundColor;
                }
            }

            toggleThemeMenuItem.Text = isDarkMode ? "BRIGHT" : "DARK";
        }

        internal class SaveDataModel
        {
            public string ProjectName { get; set; } = "";
            public int Part { get; set; } = 1;
            public int Chapter { get; set; } = 1;
            public int Shot { get; set; } = 1;
        }
    }
}