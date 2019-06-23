using System;
using UIKit;
using YourHealth.Services;

namespace YourHealth
{
    public partial class LoginController : UIViewController
    {

        public LoginController (IntPtr handle) : base (handle)
        {
        }

        async partial void LoginButton_TouchUpInsideAsync(UIKit.UIButton sender) 
        {
            await Authentication.Login(UsernameField.Text, PasswordField.Text);
        }
    }
}