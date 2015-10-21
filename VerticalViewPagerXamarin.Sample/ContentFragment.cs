using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace VerticalViewPagerXamarin.Sample
{
    public class ContentFragment : Fragment {

        public ContentFragment() {
        }

        public static Fragment NewInstance(string title, int position) {
            Bundle args = new Bundle();
            args.PutString("title", title);
            args.PutInt("position", position);
            ContentFragment fragment = new ContentFragment();
            fragment.Arguments = args;
            return fragment;
        }

        public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.fragment_content, container, false);
            InitToolbar(view);
            SetPosition(view);
            return view;
        }

        private void InitToolbar(View view) {
            Toolbar toolbar = view.FindViewById<Toolbar>(Resource.Id.toolbar);
            toolbar.Title = GetTitle();
        }

        private void SetPosition(View view) {
            TextView textView = view.FindViewById<TextView>(Resource.Id.text);
            textView.Text = GetPosition ().ToString ();
        }

        public string GetTitle() {
            return Arguments.GetString("title");
        }

        public int GetPosition() {
            return Arguments.GetInt("position");
        }
    }
}

