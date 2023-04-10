﻿using RentallConsumerModel;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.Xaml;

namespace RentallConsumer.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermAndConditionPopup : PopupPage
    {
        List<Terms> mTerms = new List<Terms>();
        public TermAndConditionPopup(List<Terms> mTerms)
        {
            InitializeComponent();
            this.mTerms = mTerms;

            termList.ItemsSource = this.mTerms.ToList();
        }

        private void btnClose_Tapped(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}