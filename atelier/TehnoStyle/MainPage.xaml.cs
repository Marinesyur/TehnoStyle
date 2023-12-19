using System;
using Xamarin.Forms;


namespace TehnoStyle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "ТехноСтиль"; // Устанавливаем заголовок страницы

            var image = new Image { Source = ImageSource.FromResource("TehnoStyle.MyImages.TechnoStyle.jpg") }; // Изображение с логотипом

            // Кнопка для перехода на страницу "Мастера"
            Button toMasterBtn = new Button
            {
                Text = "Мастера",
                BackgroundColor = Color.Thistle,
                FontFamily = "JostReg",
                BorderWidth = 1,
                WidthRequest = 400
            };
            toMasterBtn.Clicked += ToMaster; // Устанавливаем обработчик события нажатия на кнопку

            // Кнопка для перехода на страницу "Каталог услуг"
            Button toCatalogBtn = new Button
            {
                Text = "Каталог услуг",
                BackgroundColor = Color.FromHex("#BDEFFF"),
                FontFamily = "JostReg",
                BorderWidth = 1,
                WidthRequest = 400
            };
            toCatalogBtn.Clicked += ToCatalog; // Устанавливаем обработчик события нажатия на кнопку

            // Кнопка для перехода на страницу "Примеры работ"
            Button toExamplesBtn = new Button
            {
                Text = "Примеры работ",
                BackgroundColor = Color.Lavender,
                FontFamily = "JostReg",
                BorderWidth = 1,
                WidthRequest = 400
            };
            toExamplesBtn.Clicked += ToExamples; // Устанавливаем обработчик события нажатия на кнопку

            // Кнопка для перехода на страницу "Создать заказ"
            Button toCreateOrderBtn = new Button
            {
                Text = "Создать заказ",
                BackgroundColor = Color.Moccasin,
                FontFamily = "JostReg",
                BorderWidth = 1,
                WidthRequest = 400
            };
            toCreateOrderBtn.Clicked += ToCreateOrder; // Устанавливаем обработчик события нажатия на кнопку

            
            // Устанавливаем содержимое страницы как вертикальную композицию изображения и кнопок
            Content = new StackLayout 
            { 
                Children = { image, toMasterBtn, toCatalogBtn, toExamplesBtn, toCreateOrderBtn},
                Padding = new Thickness(15),
                Spacing = 5
            };
        }

        // Метод для перехода на страницу "Каталог услуг"
        private async void ToCatalog(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Catalog());
        }

        // Метод для перехода на страницу "Примеры работ"
        private async void ToExamples(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Examples());
        }

        // Метод для перехода на страницу "Мастера"
        private async void ToMaster(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Master());
        }

        // Метод для перехода на страницу "Создать заказ"
        private async void ToCreateOrder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOrders());
        }

    }
}