using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace YourHealth
{
    public partial class SignUpController : UIViewController
    {

        public SignUpController (IntPtr handle) : base (handle)
        {

        }

        partial void SubmitPCPButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        partial void SubmitUserButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }

        private bool ValidateInput() {

            List<string> errors = new List<string>();




            return errors.Count != 0;
        }
    }
}