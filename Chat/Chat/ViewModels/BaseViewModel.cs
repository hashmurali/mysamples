﻿using Chat.Interfaces;
using Chat.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.ViewModels
{
   public class BaseViewModel
    {
        protected readonly IWebService service = ServiceContainer.Resolve<IWebService>();
        protected readonly ISettings settings = ServiceContainer.Resolve<ISettings>();

        public event EventHandler IsBusyChanged = delegate { };

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                IsBusyChanged(this, EventArgs.Empty);
            }
        }
    }
}
