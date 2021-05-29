﻿using System;
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
using System.Windows.Shapes;

namespace Dof_Login
{
    /// <summary>
    /// RegisterWindow.xaml 的交互逻辑
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text.Trim()) || string.IsNullOrWhiteSpace(Password.Password.Trim()) || string.IsNullOrWhiteSpace(QQ.Text.Trim()))
            {
                MessageBox.Show("账号或密码为空！");
                return;
            }
            switch (Login.RegisterUser(UserName.Text.Trim(), Password.Password.Trim(), QQ.Text.Trim()))
            {
                case "Registered Success":
                    MessageBox.Show(UserName.Text.Trim() +" 注册成功！");
                    break;
                case "Registered Fail":
                    MessageBox.Show("注册失败！");
                    break;
                case "Registered Repeat":
                    MessageBox.Show(UserName.Text.Trim() + " 该用户已存在！");
                    break;
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}