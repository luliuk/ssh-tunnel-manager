﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuttyManager.Domain;

namespace PuttyManager.Business
{
    public class Host
    {
        private readonly Config _config;

        public Host(HostInfo info, Config config)
        {
            _config = config;
            Info = info;
            _puttyLink = new PuttyLink(Info, _config);
        }
        
        public HostInfo Info { get; private set; }
        public IPuttyLink Link { get { return _puttyLink; } }

        private IViewModel<Host> _viewModel;
        public IViewModel<Host> ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                _viewModel.Model = this;
            }
        }

        private readonly PuttyLink _puttyLink;
    }
}
