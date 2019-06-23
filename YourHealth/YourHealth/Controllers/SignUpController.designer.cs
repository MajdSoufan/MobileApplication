// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace YourHealth
{
    [Register ("SignUpController")]
    partial class SignUpController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AddressInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField CityInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ConfPasswordInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EmailInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField FirstNameInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LastNameInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField StateInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SubmitPCPButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SubmitUserButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ZipcodeInput { get; set; }

        [Action ("SubmitPCPButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SubmitPCPButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("SubmitUserButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SubmitUserButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AddressInput != null) {
                AddressInput.Dispose ();
                AddressInput = null;
            }

            if (CityInput != null) {
                CityInput.Dispose ();
                CityInput = null;
            }

            if (ConfPasswordInput != null) {
                ConfPasswordInput.Dispose ();
                ConfPasswordInput = null;
            }

            if (EmailInput != null) {
                EmailInput.Dispose ();
                EmailInput = null;
            }

            if (FirstNameInput != null) {
                FirstNameInput.Dispose ();
                FirstNameInput = null;
            }

            if (LastNameInput != null) {
                LastNameInput.Dispose ();
                LastNameInput = null;
            }

            if (PasswordInput != null) {
                PasswordInput.Dispose ();
                PasswordInput = null;
            }

            if (StateInput != null) {
                StateInput.Dispose ();
                StateInput = null;
            }

            if (SubmitPCPButton != null) {
                SubmitPCPButton.Dispose ();
                SubmitPCPButton = null;
            }

            if (SubmitUserButton != null) {
                SubmitUserButton.Dispose ();
                SubmitUserButton = null;
            }

            if (ZipcodeInput != null) {
                ZipcodeInput.Dispose ();
                ZipcodeInput = null;
            }
        }
    }
}