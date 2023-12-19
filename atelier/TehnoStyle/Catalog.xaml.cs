using System;
using Xamarin.Forms;

namespace TehnoStyle
{
    public partial class Catalog : ContentPage
    {
        public Catalog()
        {
            Title = "Каталог услуг"; // Устанавливаем заголовок страницы

            var labelTitle = new Label // Добавляем надпись перед фреймами
            {
                Text = "Цены",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(10),
                FontFamily = "JostBold"
            };

            // создаем главный стек для размещения элементов
            var stackLayout = new StackLayout();

            // Создание текстовой метки для названия услуги           
            var labelImage1 = new Label
            {
                Text = "Машинная обработка",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc1 = new Label
            {
                Text = "от 400 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid1 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid1.Children.Add(labelImage1, 0, 0); // Размещаем labelImage6 в первой колонке
            grid1.Children.Add(labelDesc1, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame1 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid1 // Используем Grid в качестве содержимого фрейма
            };


            // Создание текстовой метки для названия услуги
            var labelImage2 = new Label
            {
                Text = "Ручная обработка",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc2 = new Label
            {
                Text = "от 600 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid2 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid2.Children.Add(labelImage2, 0, 0); // Размещаем labelImage6 в первой колонке
            grid2.Children.Add(labelDesc2, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame2 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid2 // Используем Grid в качестве содержимого фрейма
            };


            // Создание текстовой метки для названия услуги
            var labelImage3 = new Label
            {
                Text = "Реставрация одежды из любой ткани",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc3 = new Label
            {
                Text = "от 1000 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid3 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid3.Children.Add(labelImage3, 0, 0); // Размещаем labelImage6 в первой колонке
            grid3.Children.Add(labelDesc3, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame3 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid3 // Используем Grid в качестве содержимого фрейма
            };


            // Создание текстовой метки для названия услуги
            var labelImage4 = new Label
            {
                Text = "Машинная вышивка",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc4 = new Label
            {
                Text = "от 400 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid4 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid4.Children.Add(labelImage4, 0, 0); // Размещаем labelImage6 в первой колонке
            grid4.Children.Add(labelDesc4, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame4 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid4 // Используем Grid в качестве содержимого фрейма
            };

            // Создание текстовой метки для названия услуги
            var labelImage5 = new Label
            {
                Text = "Замена фурнитуры",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc5 = new Label
            {
                Text = "от 250 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid5 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid5.Children.Add(labelImage5, 0, 0); // Размещаем labelImage6 в первой колонке
            grid5.Children.Add(labelDesc5, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame5 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid5 // Используем Grid в качестве содержимого фрейма
            };

            // Создание текстовой метки для названия услуги
            var labelImage6 = new Label
            {
                Text = "Склеивание поврежденных полотен",
                FontFamily = "JostBold",
                FontSize = 16
            };

            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc6 = new Label
            {
                Text = "от 400 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid6 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid6.Children.Add(labelImage6, 0, 0); // Размещаем labelImage6 в первой колонке
            grid6.Children.Add(labelDesc6, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame6 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid6 // Используем Grid в качестве содержимого фрейма
            };


            // Создание текстовой метки для названия услуги
            var labelImage7 = new Label
            {
                Text = "Декорирование одежды стразами, бисером, другими элементами отделки",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc7 = new Label
            {
                Text = "от 2000 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid7 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid7.Children.Add(labelImage7, 0, 0); // Размещаем labelImage6 в первой колонке
            grid7.Children.Add(labelDesc7, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame7 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid7 // Используем Grid в качестве содержимого фрейма
            };

            // Создание текстовой метки для названия услуги
            var labelImage8 = new Label
            {
                Text = "Перенос и обработка петель",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc8 = new Label
            {
                Text = "от 500 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid8 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid8.Children.Add(labelImage8, 0, 0); // Размещаем labelImage6 в первой колонке
            grid8.Children.Add(labelDesc8, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame8 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid8 // Используем Grid в качестве содержимого фрейма
            };

            // Создание текстовой метки для названия услуги
            var labelImage9 = new Label
            {
                Text = "Замена подкладки",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc9 = new Label
            {
                Text = "от 1400 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid9 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid9.Children.Add(labelImage9, 0, 0); // Размещаем labelImage6 в первой колонке
            grid9.Children.Add(labelDesc9, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame9 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid9 // Используем Grid в качестве содержимого фрейма
            };

            // Создание текстовой метки для названия услуги
            var labelImage10 = new Label
            {
                Text = "Коррекция по фигуре",
                FontFamily = "JostBold",
                FontSize = 16
            };

            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc10 = new Label
            {
                Text = "от 1300 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid10 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid10.Children.Add(labelImage10, 0, 0); // Размещаем labelImage6 в первой колонке
            grid10.Children.Add(labelDesc10, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame10 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid10 // Используем Grid в качестве содержимого фрейма
            };

            // Создание текстовой метки для названия услуги
            var labelImage11 = new Label
            {
                Text = "Отпаривание",
                FontFamily = "JostBold",
                FontSize = 16,
                HorizontalOptions = LayoutOptions.Start
            };
            // Создание текстовой метки для отображения стоимости услуги
            var labelDesc11 = new Label
            {
                Text = "от 500 руб",
                FontFamily = "JostIt",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.End
            };
            // Создание сетки для размещения текстовых меток в одной строке
            var grid11 = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Star }, // Первая колонка займет всю доступную ширину
                    new ColumnDefinition { Width = GridLength.Auto }  // Вторая колонка подстроится под содержимое
                }
            };

            grid11.Children.Add(labelImage11, 0, 0); // Размещаем labelImage6 в первой колонке
            grid11.Children.Add(labelDesc11, 1, 0); // Размещаем labelDesc6 во второй колонке

            var imageFrame11 = new Frame
            {
                BackgroundColor = Color.FromHex("#BDEFFF"), // Цвет фона
                CornerRadius = 10, // Скругленные углы
                Padding = new Thickness(10), // Отступы внутри фрейма
                Content = grid11 // Используем Grid в качестве содержимого фрейма
            };

            // Создаем отдельный горизонтальный стек для каждого фрейма
            var horizontalStackLayout1 = new StackLayout
            {
                Children =
                {
                    imageFrame1

                }
            };
            // Аналогично для других фреймов
            var horizontalStackLayout2 = new StackLayout
            {
                Children =
                {
                    imageFrame2
                }
            };
            var horizontalStackLayout3 = new StackLayout
            {
                Children =
                {
                    imageFrame3
                }
            };
            var horizontalStackLayout4 = new StackLayout
            {
                Children =
                {
                    imageFrame4
                }
            };
            var horizontalStackLayout5 = new StackLayout
            {
                Children =
                {
                    imageFrame5
                }
            };
            var horizontalStackLayout6 = new StackLayout
            {
                Children =
                {
                    imageFrame6
                }
            };
            var horizontalStackLayout7 = new StackLayout
            {
                Children =
                {
                    imageFrame7
                }
            };
            var horizontalStackLayout8 = new StackLayout
            {
                Children =
                {
                    imageFrame8
                }
            };
            var horizontalStackLayout9 = new StackLayout
            {
                Children =
                {
                    imageFrame9
                }
            };
            var horizontalStackLayout10 = new StackLayout
            {
                Children =
                {
                    imageFrame10
                }
            };
            var horizontalStackLayout11 = new StackLayout
            {
                Children =
                {
                    imageFrame11
                }
            };

            // добавляем горизонтальные стеки в главный стек
            var verticalStackLayout = new StackLayout();
            verticalStackLayout.Children.Add(labelTitle);
            verticalStackLayout.Children.Add(horizontalStackLayout1);
            verticalStackLayout.Children.Add(horizontalStackLayout2);
            verticalStackLayout.Children.Add(horizontalStackLayout3);
            verticalStackLayout.Children.Add(horizontalStackLayout4);
            verticalStackLayout.Children.Add(horizontalStackLayout5);
            verticalStackLayout.Children.Add(horizontalStackLayout6);
            verticalStackLayout.Children.Add(horizontalStackLayout7);
            verticalStackLayout.Children.Add(horizontalStackLayout8);
            verticalStackLayout.Children.Add(horizontalStackLayout9);
            verticalStackLayout.Children.Add(horizontalStackLayout10);
            verticalStackLayout.Children.Add(horizontalStackLayout11);

            // добавляем вертикальный стек в элемент ScrollView для прокрутки содержимого
            var scrollView = new ScrollView();
            scrollView.Content = verticalStackLayout;

            // добавляем элемент ScrollView в главный стек
            stackLayout.Children.Add(scrollView);

            Content = stackLayout;


        }

    }
}
