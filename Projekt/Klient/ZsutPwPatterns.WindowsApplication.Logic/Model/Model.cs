﻿namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ZsutPw.Patterns.WindowsApplication.Utilities;

    public partial class Model : PropertyContainerBase, IModel
    {
        public Model(IEventDispatcher dispatch) : base(dispatch)
        {
        }
    }
}
