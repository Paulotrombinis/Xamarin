using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Secao1Aula6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativePage : ContentPage
    {
        public RelativePage()
        {
            InitializeComponent();

            //var layout = new RelativeLayout();
            //Content = layout;

            //var aquaBox = new BoxView { Color = Color.Aqua };
            //layout.Children.Add(aquaBox,
            //    widthConstraint:Constraint.RelativeToParent(parent => parent.Width),
            //    heightConstraint:Constraint.RelativeToParent(parant => parant.Height * 0.3)
            //    );

            //var silberBoxView = new BoxView { Color = Color.Silver };

            //layout.Children.Add(silberBoxView,
            //    yConstraint:Constraint.RelativeToView(aquaBox, (RelativeLayout, element) => element.Height + 20));


        }
    }
}