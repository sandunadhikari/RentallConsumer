﻿using System;
using RentallConsumer.iOS;
using RentallConsumer.Renders;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FocusCustomEntry), typeof(FocusCustomEntryRenderer))]
namespace RentallConsumer.iOS
{
	public class FocusCustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

                Control.BorderStyle = UITextBorderStyle.None;
                Control.Layer.CornerRadius = 10;
                //Control.TextColor = UIColor.White;

            }
        }
    }
}

