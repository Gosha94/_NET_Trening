using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace SlidersAndAnimationWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_AnimHeight_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 50;
            anim.To = 300;
            anim.Duration = TimeSpan.FromSeconds(0.5);
            anim.EasingFunction = new QuadraticEase(); // Замедление анимации в конце, для сглаживания
            grd_AnimHeight.BeginAnimation(HeightProperty, anim);
        }

        private void btn_AnimUp_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 50;
            anim.To = 170;
            anim.Duration = TimeSpan.FromSeconds(0.5);
            anim.EasingFunction = new QuadraticEase(); // Замедление анимации в конце, для сглаживания
            grd_AnimUp.BeginAnimation(HeightProperty, anim);
        }

        private void btn_AnimWidth_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.From = 50;
            anim.To = 300;
            anim.Duration = TimeSpan.FromSeconds(0.5);
            anim.EasingFunction = new QuadraticEase(); // Замедление анимации в конце, для сглаживания
            grd_AnimWidth.BeginAnimation(WidthProperty, anim);
        }

        private void btn_AnimTranslate_Click(object sender, RoutedEventArgs e)
        {
            TranslateTransform transform = new TranslateTransform();
            grd_AnimTranslate.RenderTransform = transform;
            DoubleAnimation animX = new DoubleAnimation(0,50,TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.XProperty, animX);
            DoubleAnimation animY = new DoubleAnimation(0, 150, TimeSpan.FromSeconds(1));
            transform.BeginAnimation(TranslateTransform.YProperty, animY);
        }

            

    }
}
