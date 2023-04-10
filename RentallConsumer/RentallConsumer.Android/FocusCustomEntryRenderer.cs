using System;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using RentallConsumer.Droid;
using RentallConsumer.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(FocusCustomEntry), typeof(FocusCustomEntryRenderer))]
namespace RentallConsumer.Droid
{
    [Obsolete]
    public class FocusCustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetTextIsSelectable(false);
                this.Control.SetCursorVisible(false);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                //Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
            }
        }
    }
}

