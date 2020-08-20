﻿using System;
using CBT1.ViewModels;
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

namespace CBT1.Views
{
    /// <summary>
    /// Interaction logic for StartControl.xaml
    /// </summary>
    public partial class QuestionView : UserControl
    {
        public QuestionView()
        {
            InitializeComponent();
            DataContext = new QuestionViewModel();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
