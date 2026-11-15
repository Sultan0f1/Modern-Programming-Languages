using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Nici
{
    public partial class Form1
    {
        private readonly List<Panel> spawnedPanels = new List<Panel>();

        private void ConfigureGameAssets(object sender, EventArgs e)
        {
            string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            string bombImagePath = Path.Combine(resourcesPath, "bomba.png");
            string bombSoundPath = Path.Combine(resourcesPath, "bombasesi.wav");

            if (File.Exists(bombImagePath))
            {
                pictureBox1.Image = Image.FromFile(bombImagePath);
            }

            if (File.Exists(bombSoundPath))
            {
                sp.SoundLocation = bombSoundPath;
                sp.Load();
            }
        }

        private void TrackSpawnedPanel(object sender, ControlEventArgs e)
        {
            if (e.Control is Panel panel)
            {
                spawnedPanels.Add(panel);
            }
        }

        private void button1_ClickWithRecovery(object sender, EventArgs e)
        {
            int panelsBeforeClick = spawnedPanels.Count;

            // Keep the supplied Form1.cs click behavior unchanged, then repair the
            // controls it removes so the game can continue after a collision.
            button1_Click(sender, e);

            bool gameEnded = count == 0 && spawnedPanels.Count > panelsBeforeClick;
            if (gameEnded)
            {
                RestartRound();
            }
        }

        private void RestartRound()
        {
            foreach (Panel panel in spawnedPanels.ToArray())
            {
                if (panel.Parent != null)
                {
                    panel.Parent.Controls.Remove(panel);
                }

                panel.Dispose();
            }

            spawnedPanels.Clear();

            EnsureFormControl(pictureBox1);
            EnsureFormControl(button1);
            EnsureFormControl(button2);
            EnsureFormControl(button3);
            EnsureFormControl(label1);
            EnsureFormControl(label2);

            label2.Text = "0";
        }

        private void EnsureFormControl(Control control)
        {
            if (control.Parent != this)
            {
                control.Parent?.Controls.Remove(control);
                Controls.Add(control);
            }
        }
    }
}
