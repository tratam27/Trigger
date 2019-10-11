using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Trigger
{
    public class PasswordTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            if(entry.Text.Length > 5 && entry.Text.Length <10)
            {
                entry.BackgroundColor = Color.Yellow;
            }
            else if(entry.Text.Length >= 10)
            {
                entry.BackgroundColor = Color.Red;
            }
            else if(entry.Text.Length <= 5)
            {
                entry.BackgroundColor = Color.GreenYellow;
            } 
        }
    }
}
