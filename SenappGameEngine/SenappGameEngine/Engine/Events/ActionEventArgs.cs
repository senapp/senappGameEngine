﻿using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senapp.Engine.Events
{
    public class ActionEventArgs : EventArgs
    {
        public ActionEventArgs()
        {
            Instance = 0;
        }

        public ActionEventArgs(int ControllerInstance)
        {
            Instance = ControllerInstance;
        }

        public int Instance { get; set; }

        public GamePadState GamePadState { get { return GamePad.GetState(Instance); } }

        public JoystickState JoystickState { get { return Joystick.GetState(Instance); } }
    }
}
