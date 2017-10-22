

using System;

namespace GoogleAutomation.Execeptions
{
    public class ImageNotPresentException : Exception
    {
        public ImageNotPresentException()
        {
        }

        public ImageNotPresentException(string message)
        : base(message)
        {
        }

    }
}
