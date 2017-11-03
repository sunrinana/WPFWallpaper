﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFWallpaper.Windows;

namespace WPFWallpaper
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum TABS
        {
            Youtube,
            Video,
            GIF,
            Setting
        }

        private TABS TabFlag = TABS.Youtube;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            switch((sender as ToggleButton).Name)
            {
                case "YoutubeToggle":
                    TabFlag = TABS.Youtube;
                    break;
                case "VideoToggle":
                    TabFlag = TABS.Video;
                    break;
                case "GifToggle":
                    TabFlag = TABS.GIF;
                    break;
                case "SettingToggle":
                    TabFlag = TABS.Setting;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            YoutubeWindow youtubeWindow = new YoutubeWindow();
            youtubeWindow.Show();
        }
    }
}
