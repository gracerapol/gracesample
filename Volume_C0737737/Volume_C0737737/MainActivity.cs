using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Volume_C0737737
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.C0737737_main);
            Button VButton;
            EditText radius;
            EditText height;

           

            SetContentView(Resource.Layout.C0737737_main);
            VButton = FindViewById<Button>(Resource.Id.vButton);
            radius = FindViewById<EditText>(Resource.Id.radius1);
            height = FindViewById<EditText>(Resource.Id.height1);

            VButton.Click += delegate
            {
                int parsedValue;
                Android.App.AlertDialog.Builder dismess = new Android.App.AlertDialog.Builder(this);

                

                if (!int.TryParse(radius.Text, out parsedValue))
                {
                    dismess.SetMessage(string.Format("Please enter a valid number"));

                }
                if (!int.TryParse(height.Text, out parsedValue))
                {
                    dismess.SetMessage(string.Format("Please enter a valid number"));

                }





            double r = double.Parse(radius.Text);
                double h = double.Parse(height.Text);
                double result = 3.14 * r * r * h;

                dismess.SetMessage(string.Format("Volume of Cylinder is {0} ", result));
                dismess.Show();
            };
        }

    }
}
