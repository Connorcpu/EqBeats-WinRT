﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EqBeats_WinRT.Controls;
using EqBeats_WinRT.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EqBeats_WinRT.Pages {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Search {
        public Search() {
            InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e) {
            SearchResultsControl.SearchType = (SearchMode)SearchModeBox.SelectedIndex;
            SearchTopBar.DataContext = State.AppState;
            SearchResultsControl.DataContext = State.AppState;
        }

        private void GoBack(object sender, RoutedEventArgs routedEventArgs) {
            ((Frame)Window.Current.Content).Navigate(typeof(Home));
        }

        private void SearchModeChanged(object sender, SelectionChangedEventArgs e) {
            if (SearchResultsControl == null) return;
            SearchResultsControl.SearchType = (SearchMode)((ComboBox)sender).SelectedIndex;
        }
    }
}
