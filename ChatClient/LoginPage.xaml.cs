﻿using ChatClient.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatClient
{
    /// <summary>
    /// LoginPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void RegisterBtnClick(object sender, RoutedEventArgs e)
        {
            App.PageFrame.Navigate(new RegisterPage());
        }

        private void LoginBtnClick(object sender, RoutedEventArgs e)
        {
            string id = IDTextBox.Text;
            string password = PasswordTextBox.Password;

            LoginModel model = new LoginModel(id, password);
<<<<<<< HEAD
            RestRequest request = new RestRequest("http://localhost:3000/user/signIn", Method.Post);
            request.AddBody(model);

            var response = App.client.Execute<ResponseModel<AccessTokenModel>>(request);
=======
            RestClient client = new RestClient();
            RestRequest request = new RestRequest("http://localhost:3000/signIn", Method.Post);
            request.AddBody(model);
            
            var response = client.Execute<ResponseModel<AccessTokenModel>>(request);
>>>>>>> 6a1d140258e665c9376aafc4701a303190fcaa02

            if (response.IsSuccessStatusCode && response.Data?.Options != null)
            {
                App.AccessToken = response.Data.Options;
                App.PageFrame.Navigate(new ChatPage());
            }
            else
<<<<<<< HEAD
            {
=======
            { 
>>>>>>> 6a1d140258e665c9376aafc4701a303190fcaa02
                MessageBox.Show(response.Data?.Message ?? "Unknown error");
            }
        }
    }
}
