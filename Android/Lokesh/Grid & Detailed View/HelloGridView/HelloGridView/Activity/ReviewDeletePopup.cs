using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HelloGridView
{
   
    class ReviewDeletePopup : DialogFragment
    {
       
        //RatingBar userRatingBar;
        //EditText txtReviewComments;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.ReviewDelete, container, false);

            //userRatingBar = view.FindViewById<RatingBar>(Resource.Id.rtbProductRating);
            //txtReviewComments = view.FindViewById<EditText>(Resource.Id.txtReviewComments);
            //Button btnSubmitReview = view.FindViewById<Button>(Resource.Id.btnSubmitReview);

          //  btnSubmitReview.Click += BtnSubmitReview_Click;
            return view;
        }
        public override Dialog OnCreateDialog(Bundle Saved)
        {
            Dialog dialog = base.OnCreateDialog(Saved);
            dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            return dialog;
        }


    }
}