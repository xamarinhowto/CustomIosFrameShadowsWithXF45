using System;
using CoreGraphics;
using CustomIosFrameShadowsWithXF45.Controls;
using CustomIosFrameShadowsWithXF45.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace CustomIosFrameShadowsWithXF45.iOS.Renderers
{
    /// <summary>
    /// Make iOS frame shadows look more natural than the default Xamarin.Forms implementation
    /// </summary>
    public class CustomFrameRenderer : FrameRenderer
    {
        public override void Draw(CGRect rect)
        {
            try
            {
                base.Draw(rect);

                if ((bool)Element?.HasShadow)
                {
                    foreach (var uiView in Superview.Subviews)
                    {
                        var name = uiView.ToString();

                        // Find the Xamarin.Forms ShadowView and customise the look and feel
                        if (uiView != this && uiView.Layer.ShadowRadius > 0)
                        {
                            var shadowRadius = 2.5f;
                            uiView.Layer.ShadowRadius = shadowRadius;
                            uiView.Layer.ShadowColor = UIColor.Gray.CGColor;
                            uiView.Layer.ShadowOffset = new CGSize(shadowRadius, shadowRadius);
                            uiView.Layer.ShadowOpacity = 0.8f;
                            uiView.Layer.MasksToBounds = false;
                            uiView.Layer.BorderWidth = 1;

                            uiView.Bounds = Bounds;
                            uiView.Frame = Frame;
                        }
                    }

                    Layer.MasksToBounds = true;
                    Layer.BorderColor = UIColor.Clear.CGColor;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
