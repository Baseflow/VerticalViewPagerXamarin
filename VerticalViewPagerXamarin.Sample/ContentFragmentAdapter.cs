using System;
using System.Collections.Generic;
using Android.Support.V4.App;
using Java.Lang;

namespace VerticalViewPagerXamarin.Sample
{
    public class ContentFragmentAdapter : FragmentPagerAdapter 
    {
        private List<Fragment> fragments = new List<Fragment> ();

        public ContentFragmentAdapter (FragmentManager fm, List<Fragment> fragments) : base (fm)
        {
            this.fragments = fragments;
        }

        public override Fragment GetItem (int position)
        {
            return fragments[position];
        }

        public override int Count {
            get {
                return fragments.Count;
            }
        }

        public override ICharSequence GetPageTitleFormatted (int position)
        {
            return new Java.Lang.String(((ContentFragment)fragments[position]).GetTitle());
        }

        /*
        public static class Holder {
            private final List<Fragment> fragments = new ArrayList<>();
            private FragmentManager manager;
            public Holder(FragmentManager manager) {
                this.manager = manager;
            }

            public Holder add(Fragment f) {
                fragments.add(f);
                return this;
            }

            public ContentFragmentAdapter set() {
                return new ContentFragmentAdapter(manager, fragments);
            }
        }*/
    }
}

