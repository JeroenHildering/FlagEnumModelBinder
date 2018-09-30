using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagEnumModelBinder.Models
{
    [Flags]
    public enum FlagEnum
    {
        Flag1 = 1 << 0,
        Flag2 = 1 << 1,
        Flag3 = 1 << 2,
    }

    public class FlagViewModel
    {
        public FlagEnum FlagProperty { get; set; }
    }
}