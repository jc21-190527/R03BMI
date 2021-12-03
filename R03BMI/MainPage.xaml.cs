using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A28 髙橋大樹";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
{
            double height = double.Parse(heighit.Text);
            double weight = double.Parse(weighit.Text);
            string sin = "m";
            string tai = "kg";
            int flag1 = 0;
            int flag2 = 0;
            if (height > 10)
{
height = height / 100;



            flag1 = 1;
               sin = "cm";

}
            if (weight > 1000)
{
               weight = weight / 1000;
               flag2 = 1;
               tai = "g";

}
               double BMI = Math.Round(weight / (height * height),1);



            string i;
            if (BMI < 18.5)
{
i = "低体重";
}
else if (BMI < 25)
{
i = "普通体重";
}
else if (BMI<30)
{
i = "肥満(1度)";
}
else if (BMI < 35)
{
i = "肥満(2度)";
}
else if (BMI < 40)
{
i = "肥満(3度)";
}
else
{
i = "肥満(4度)";
}
if(flag1>0)
{
height = height* 100;
}
if(flag2>0)
{
weight = weight * 1000;
}




//身長1.6m　体重４６ｋｇのＢＭＩは？？？肥満１です。
result.Text ="身長"+height+sin+"体重"+weight+tai+"のBMIは"+BMI+i+"です";
}
catch (FormatException ex)

{
Console.WriteLine(ex);
result.Text = "!!!";




            }
        }
    }
}

