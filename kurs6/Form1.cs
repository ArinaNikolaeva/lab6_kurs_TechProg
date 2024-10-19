using static kurs6.Emitter;
using static kurs6.Particle;

namespace kurs6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // ������� ���� ��� ��������

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // ������ ������� � ���������� ��� � ���� emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.BlueViolet,
                ColorTo = Color.FromArgb(0, Color.Pink),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // ��� ����� �������� � ������ emitters, ����� �� ���������� � ����������


        }


        private void timer_Tick(object sender, EventArgs e)
        {

            emitter.UpdateState();

            // ��������� ���������� �������� ������
            ldlParticlesCount.Text = $"���-�� ������: {emitter.ParticlesCount}";

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // � ��� ������ ��� ������
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }


        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            ldlDirection.Text = $"�����������: {tbDirection.Value}�"; // ������� ����� ��������
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            ldlSpreading.Text = $"�������: {tbSpreading.Value}"; // ������� ����� ��������
        }

        private void tdSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMin = tbSpeed.Value;
            ldlSpeed.Text = $"��������: {tbSpeed.Value}"; // ������� ����� ��������
            emitter.SpeedMax = tbSpeed.Value;
            ldlSpeed.Text = $"��������: {tbSpeed.Value}"; // ������� ����� ��������
        }

        private void tbParticlesPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbParticlesPerTick.Value;
            ldlParticlesPerTick.Text = $"���-�� ������ � ���: {tbParticlesPerTick.Value}"; // ������� ����� ��������
        }

        private void tbLife_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMin = tbLife.Value;
            ldlLife.Text = $"����������������� �����: {tbLife.Value}"; // ������� ����� ��������
            emitter.LifeMax = tbLife.Value;
            ldlLife.Text = $"����������������� �����: {tbLife.Value}"; // ������� ����� ��������
        }

        private void ldlParticlesCount_Click(object sender, EventArgs e)
        {
            ldlParticlesCount.Text = $"���������� ������: {emitter.ParticlesCount}"; // ������� ���������� �������� ������        }
        }
    }
}