﻿using MyDiary.WPF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using MyDiary.WPF.Extensions;
using MyDiary.WPF.Pages;

namespace MyDiary.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNoteButton_OnClick(object sender, RoutedEventArgs e)
        {
            var createNoteWindow = new CreateNoteWindow();
            createNoteWindow.Show();
        }
    }
}
