﻿/*
 * Process Hacker
 * 
 * Copyright (C) 2008 wj32
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessHacker
{
    public partial class ServiceWindow : Form
    {
        private ServiceProperties _serviceProps;

        public ServiceWindow(string service)
            : this(new string[] { service })
        { }

        public ServiceWindow(string[] services)
        {
            InitializeComponent();

            _serviceProps = new ServiceProperties(services);
            _serviceProps.Dock = DockStyle.Fill;
            _serviceProps.NeedsClose += new EventHandler(_serviceProps_NeedsClose);
            this.Controls.Add(_serviceProps);
            this.Text = _serviceProps.Text;
        }

        private void _serviceProps_NeedsClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serviceProps.Deinit();
        }
    }
}
