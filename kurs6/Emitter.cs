using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static kurs6.Particle;

namespace kurs6
{

    public class Emitter
    {

        public int X; // координата X центра эмиттера
        public int Y; // координата Y 
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 5; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 2; // минимальный радиус частицы
        public int RadiusMax = 10; // максимальный радиус частицы
        public int LifeMin = 20; // минимальное время жизни частицы
        public int LifeMax = 100; // максимальное время жизни частицы

        public Color ColorFrom = Color.Pink; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.MediumPurple); // конечный цвет частиц



        List<Particle> particles = new List<Particle>();
        public float GravitationX = 0;
        public float GravitationY = 1; // пусть гравитация будет силой один пиксель за такт

        public List<Point> gravityPoints = new List<Point>(); // тут буду хранится точки притяжения

        

        public int ParticlesPerTick = 1; // кол-во частиц в тик


        public int ParticlesCount => particles.Count(p => p.Life > 0); // возвращаем количество частиц с жизнью > 0

        public void UpdateState()     //метод обновляет состояние эмиттера. Он удаляет частицы, у которых закончилась жизнь, и создает новые
        {
            particles.RemoveAll(p => p.Life <= 0);  // Удаляем мертвые частицы
            int particlesToCreate = ParticlesPerTick;// кол-во частиц в тик

            foreach (var particle in particles)
            {
                if (particle.Life <= 0) // Если частица мертва
                {
                    if (particlesToCreate > 0)
                    {
                        particlesToCreate -= 1; // Создаем новую частицу через сброс
                        ResetParticle(particle);
                    }
                }
                else
                {
                    // Обновляем положение частицы
                    foreach (var point in gravityPoints)
                    {
                        float gX = point.X - particle.X;
                        float gY = point.Y - particle.Y;
                        float r2 = (float)Math.Max(100, gX * gX + gY * gY); // Ограничение минимального расстояния
                        float M = 100;

                        particle.SpeedX += (gX) * M / r2;
                        particle.SpeedY += (gY) * M / r2;
                    }

                    // Применение общей гравитации
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                    // Обновляем положение частицы
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    // Уменьшаем жизнь частицы
                    particle.Life -= 1;
                }
            }

            // Создаем новые частицы, если нужно
            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        public virtual void ResetParticle(Particle particle)  //Метод сбрасывает параметры частицы, назначая ей новые координаты, скорость и направление
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.X = X;
            particle.Y = Y;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }
        public class TopEmitter : Emitter
        {
            public int Width; // длина экрана

            public override void ResetParticle(Particle particle)
            {
                base.ResetParticle(particle); // вызываем базовый сброс частицы, там жизнь переопределяется и все такое

                // а теперь тут уже подкручиваем параметры движения
                particle.X = Particle.rand.Next(Width); // позиция X -- произвольная точка от 0 до Width
                particle.Y = 0;  // ноль -- это верх экрана 

                particle.SpeedY = 1; // падаем вниз по умолчанию
                particle.SpeedX = Particle.rand.Next(-2, 2); // разброс влево и вправа у частиц 
            }
        }
        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }

        public void Render(Graphics g) //Этот метод отрисовывает все частицы, создавая визуальный эффект
        {
   
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
            foreach (var point in gravityPoints)
            {
                g.FillEllipse(
                    new SolidBrush(Color.Red),
                    point.X - 5,
                    point.Y - 5,
                    10,
                    10
                );
            }
        }

    }
}
