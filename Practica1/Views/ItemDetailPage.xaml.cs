﻿using Practica1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Practica1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}