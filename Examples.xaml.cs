using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TehnoStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Examples : ContentPage
    {
        public Examples()
        {
            Title = "Примеры работ";// Установка заголовка страницы

            // Создание объектов Image для отображения изображений
            var image1 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image1.jpg") };
            var image2 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image2.jpg") };
            var image3 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image3.jpg") };
            var image4 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image4.jpg") };
            var image5 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image5.jpg") };
            var image6 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image6.jpg") };
            var image7 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image7.jpg") };
            var image8 = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.Examples.image8.jpg") };

            // Создание объекта Grid для размещения изображений
            var grid = new Grid
            {
                // Определение строк и столбцов в сетке
                RowDefinitions =
                {
                    new RowDefinition { Height = 250 },
                    new RowDefinition { Height = 250 },
                    new RowDefinition { Height = 250 },
                    new RowDefinition { Height = 250 }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },

            };

            grid.RowSpacing = -10; // Отрицательный отступ между строками
            
            // Добавление изображений в сетку по указанным позициям
            grid.Children.Add(image1, 0, 0);
            grid.Children.Add(image2, 1, 0);
            grid.Children.Add(image3, 0, 1);
            grid.Children.Add(image4, 1, 1);
            grid.Children.Add(image5, 0, 2);
            grid.Children.Add(image6, 1, 2);
            grid.Children.Add(image7, 0, 3);
            grid.Children.Add(image8, 1, 3);

            // Установка содержимого страницы в виде прокручиваемой области, содержащей сетку изображений
            Content = new ScrollView { Content = grid };

            

        }
    }
}