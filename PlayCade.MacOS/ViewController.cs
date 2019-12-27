using System;
using AppKit;
using Foundation;
using PlayCade.Managers;
using PlayCade.Core.Chip8;
using PlayCade.Core.Chip8.Emu;

namespace PlayCade.MacOS
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var manager = new CoreManager();
            manager.AvailableCores();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get { return base.RepresentedObject; }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}