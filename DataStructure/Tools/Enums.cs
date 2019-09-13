using System.ComponentModel;

namespace Atarbashi.DataStructure.Tools
{
    public class Enums
    {
        public enum MessageType : byte
        {
            [Description("")]
            None = 0,
            [Description("ایمیل")]
            Email = 1,
        }

        public enum SliderType : byte
        {
            [Description("")]
            None = 0,
            [Description("اسلابد اصلی")]
            Main = 1
        }

        public enum GalleryType : byte
        {
            [Description("")]
            None = 0,
            [Description("گالری فیلم")]
            Film = 1,
            [Description("گالری عکس")]
            Image = 2
        }
    }
}
