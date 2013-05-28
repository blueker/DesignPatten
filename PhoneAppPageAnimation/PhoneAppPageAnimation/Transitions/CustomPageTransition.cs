using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using Microsoft.Phone.Controls.Primitives;

namespace PhoneAppPageAnimation.Transitions
{
   public class CustomPageTransition : TransitionElement
    {
       public const string StoryboardPropertyName = "Storybord";

       public Storyboard Storyboard
       {
           get { return (Storyboard)GetValue(StoryboardProperty); }
           set { SetValue(StoryboardProperty, value); }
       }

       public static readonly DependencyProperty StoryboardProperty =
           DependencyProperty.Register(StoryboardPropertyName, typeof(Storyboard),
           typeof(CustomPageTransition), new PropertyMetadata(null));

        public override ITransition GetTransition(System.Windows.UIElement element)
        {
            return new Transition(element, this.Storyboard);

        }
    }
}
