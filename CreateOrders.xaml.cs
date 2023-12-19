using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TehnoStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateOrders : ContentPage
    {
        
        public CreateOrders()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            ShowOrders();
        }
        private void ShowOrders()
        {
            ordersCollection.ItemsSource = App.Db.GetOrders();
        }

        private async void AddOrderButton(object sender, EventArgs e)
        {
            try
            {
                string name = nameEntry.Text.Trim();
                string phonenumber = phoneNumberEntry.Text.Trim();
                int ordertype = orderTypePicker.SelectedIndex;
                int productmodel = productModelPicker.SelectedIndex;
                string comment = commentsEditor.Text.Trim();
                DateTime measurementdate = measurementDatePicker.Date;
                            
                if (name.Length < 5)
                {
                    await DisplayAlert("Ошибка", "Поле ФИО должно содержать не менее 5 символов", "OK");
                    return;
                }
                if (phonenumber.Length < 11)
                {
                    await DisplayAlert("Ошибка", "Номер телефона должен содержать не менее 11 символов", "OK");
                    return;
                }

                Order order = new Order
                {
                    Name = name,
                    PhoneNumber = phonenumber,
                    OrderType = ordertype,
                    ProductModel = productmodel,
                    Comments = comment,
                    MeasurementDate = measurementdate,
                };
                App.Db.SaveOrder(order);
                ShowOrders();
                await DisplayAlert("Успех", "Спасибо за заказ! Ожидайте звонка в течение часа", "OK");

                nameEntry.Text = "";
                phoneNumberEntry.Text = "";
                orderTypePicker.SelectedIndex = -1;
                productModelPicker.SelectedIndex = -1;
                commentsEditor.Text = "";

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", "Пожалуйста, заполните все поля", "OK");
            }
        }

    }
}