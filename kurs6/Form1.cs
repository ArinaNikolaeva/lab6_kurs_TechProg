using static kurs6.Emitter;
using static kurs6.Particle;

namespace kurs6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // добавим поле для эмиттера

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
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

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся


        }


        private void timer_Tick(object sender, EventArgs e)
        {

            emitter.UpdateState();

            // Обновляем количество активных частиц
            ldlParticlesCount.Text = $"Кол-во частиц: {emitter.ParticlesCount}";

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // А ЕЩЕ ЧЕРНЫЙ ФОН СДЕЛАЮ
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }


        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            ldlDirection.Text = $"Направление: {tbDirection.Value}°"; // добавил вывод значения
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            ldlSpreading.Text = $"Разброс: {tbSpreading.Value}"; // добавил вывод значения
        }

        private void tdSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMin = tbSpeed.Value;
            ldlSpeed.Text = $"Скорость: {tbSpeed.Value}"; // добавил вывод значения
            emitter.SpeedMax = tbSpeed.Value;
            ldlSpeed.Text = $"Скорость: {tbSpeed.Value}"; // добавил вывод значения
        }

        private void tbParticlesPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbParticlesPerTick.Value;
            ldlParticlesPerTick.Text = $"Кол-во частиц в тик: {tbParticlesPerTick.Value}"; // добавил вывод значения
        }

        private void tbLife_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMin = tbLife.Value;
            ldlLife.Text = $"Продолжительность жизни: {tbLife.Value}"; // добавил вывод значения
            emitter.LifeMax = tbLife.Value;
            ldlLife.Text = $"Продолжительность жизни: {tbLife.Value}"; // добавил вывод значения
        }

        private void ldlParticlesCount_Click(object sender, EventArgs e)
        {
            ldlParticlesCount.Text = $"Количество частиц: {emitter.ParticlesCount}"; // выводим количество активных частиц        }
        }
    }
}