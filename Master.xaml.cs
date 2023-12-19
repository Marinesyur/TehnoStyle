using System;
using Xamarin.Forms;

namespace TehnoStyle
{
    public partial class Master : ContentPage
    {
        public Master()
        {
            Title = "Мастера"; // Устанавливаем заголовок страницы

            // создаем главный стек для размещения элементов
            var stackLayout = new StackLayout();


            // Создание изображения и установка его источника и высоты
            var image1 = new Image
            {
                Source = ImageSource.FromResource("TehnoStyle.MyImages.Master.image1.jpg"),
                Aspect = Aspect.AspectFit,
                HeightRequest = 250
            };
            // Создание текстовой метки для имени мастера
            var labelImage1 = new Label
            {
                Text = "Елизавета Белова",
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для описания должности мастера
            var labelDesc1 = new Label
            {
                Text = "Дизайнер",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для информации о мастере
            var labelAbout1 = new Label
            {
                Text = "Я работаю дизайнером уже 7 лет. Создание уникальных и стильных моделей - моя страсть. Я стремлюсь сделать вашу одежду комфортной и модной, подчеркнув вашу индивидуальность.",
                FontSize = 14,
                BackgroundColor = Color.Beige,
                Padding = new Thickness(15),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontFamily = "JostIt"
            };

            


            // Создание изображения и установка его источника и высоты
            var image2 = new Image
            {
                Source = ImageSource.FromResource("TehnoStyle.MyImages.Master.image2.jpg"),
                Aspect = Aspect.AspectFit,
                HeightRequest = 250
            };
            // Создание текстовой метки для имени мастера
            var labelImage2 = new Label
            {
                Text = "Александра Лебедева",
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для описания должности мастера
            var labelDesc2 = new Label
            {
                Text = "Швея",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для информации о мастере
            var labelAbout2 = new Label
            {
                Text = "Я - профессиональная швея с более чем 10-летним опытом работы. Я готова принять любой заказ, будь то пошив новой одежды или ремонт старой. Моя цель - сделать вашу одежду превосходной!",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Beige,
                Padding = new Thickness(15),
                FontFamily = "JostIt"
            };

            // Создание изображения и установка его источника и высоты
            var image3 = new Image
            {
                Source = ImageSource.FromResource("TehnoStyle.MyImages.Master.image3.jpg"),
                Aspect = Aspect.AspectFit,
                HeightRequest = 250
            };
            // Создание текстовой метки для имени мастера
            var labelImage3 = new Label
            {
                Text = "Варвара Вишнякова",
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для описания должности мастера
            var labelDesc3 = new Label
            {
                Text = "Швея",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для информации о мастере
            var labelAbout3 = new Label
            {
                Text = "Я занимаюсь пошивом одежды уже 12 лет. Я работаю с различными типами тканей и стилей одежды, чтобы воплотить все ваши модные мечты в реальность.",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Beige,
                Padding = new Thickness(15),
                FontFamily = "JostIt"
            };

            // Создание изображения и установка его источника и высоты
            var image4 = new Image
            {
                Source = ImageSource.FromResource("TehnoStyle.MyImages.Master.image4.jpg"),
                Aspect = Aspect.AspectFit,
                HeightRequest = 250
            };
            // Создание текстовой метки для имени мастера
            var labelImage4 = new Label
            {
                Text = "Софья Филина",
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для описания должности мастера
            var labelDesc4 = new Label
            {
                Text = "Закройщица",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center
            };
            // Создание текстовой метки для информации о мастере
            var labelAbout4 = new Label
            {
                Text = "Мой 9-летний опыт работы в швейной индустрии позволяет мне создавать качественную одежду, которая идеально сидит на вас. Доверьте мне свою одежду и я сделаю ее превосходной.",
                FontSize = 14,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.Beige,
                Padding = new Thickness(15),
                FontFamily = "JostIt"
            };


            // создаем стек для размещения каждого фото с описанием
            var horizontalStackLayout1 = new StackLayout
            {
                Children =
                {
                    image1,
                    labelImage1,
                    labelDesc1,
                    labelAbout1

                }
            };
            // Создание стека для размещения каждого фото с описанием
            var horizontalStackLayout2 = new StackLayout
            {
                Children =
                {
                    image2,
                    labelImage2,
                    labelDesc2,
                    labelAbout2
                }
            };
            // Создание стека для размещения каждого фото с описанием
            var horizontalStackLayout3 = new StackLayout
            {
                Children =
                {
                    image3,
                    labelImage3,
                    labelDesc3,
                    labelAbout3
                }
            };
            // Создание стека для размещения каждого фото с описанием
            var horizontalStackLayout4 = new StackLayout
            {
                Children =
                {
                    image4,
                    labelImage4,
                    labelDesc4,
                    labelAbout4
                }
            };


            // добавляем горизонтальные стеки в главный стек
            var verticalStackLayout = new StackLayout();
            verticalStackLayout.Children.Add(horizontalStackLayout1);
            verticalStackLayout.Children.Add(horizontalStackLayout2);
            verticalStackLayout.Children.Add(horizontalStackLayout3);
            verticalStackLayout.Children.Add(horizontalStackLayout4);

            // добавляем вертикальный стек в элемент ScrollView для прокрутки содержимого
            var scrollView = new ScrollView();
            scrollView.Content = verticalStackLayout;

            // добавляем элемент ScrollView в главный стек
            stackLayout.Children.Add(scrollView);

            Content = stackLayout;
        }
    }
}