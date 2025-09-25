using NAudio.Wave;

namespace Sound_Synthesizer
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public Form1()
        {
            InitializeComponent();
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
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();

            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(filePath);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
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
    }
}
