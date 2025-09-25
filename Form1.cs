using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace Sound_Synthesizer
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        // Gotowe pliki audio w folderze projektu
        private string soundQ = @"Sounds\soundQ.wav.mp3";
        private string soundW = @"Sounds\soundW.wav.mp3";
        private string soundE = @"Sounds\soundE.mp3";

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var deviceInfo = WaveOut.GetCapabilities(i);
                cmbDevices.Items.Add($"{i}: {deviceInfo.ProductName}");
            }

            if (cmbDevices.Items.Count > 0)
                cmbDevices.SelectedIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pliki audio|*.mp3;*.wav;*.mp4";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PlaySound(ofd.FileName);
                }
            }
        }

        private void PlaySound(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show($"Nie znaleziono pliku: {filePath}");
                return;
            }

            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();

            int deviceNumber = cmbDevices.SelectedIndex;
            outputDevice = new WaveOutEvent() { DeviceNumber = deviceNumber };
            audioFile = new AudioFileReader(filePath);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        // Hotkeye Q/W/E odtwarzaj¹ dŸwiêki od razu
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    PlaySound(soundQ);
                    break;
                case Keys.W:
                    PlaySound(soundW);
                    break;
                case Keys.E:
                    PlaySound(soundE);
                    break;
            }
        }
    }
}
