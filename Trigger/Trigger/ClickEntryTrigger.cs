using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Trigger
{
    public class ClickEntryTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = Color.OrangeRed;
        }
    }
}
