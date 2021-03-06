﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuzzleEngineAlpha.Input.Scripts
{
    public class BasicMenuInputScript: IMenuInputScript
    {
        public bool Next
        {
            get
            {
                return InputHandler.IsKeyReleased(ConfigurationManager.Config.EnumerateVNext);
            }
        }

        public bool Previous
        {
            get
            {
                return InputHandler.IsKeyReleased(ConfigurationManager.Config.EnumerateVPrevious);
            }
        }

        public bool Trigger
        {
            get
            {
                return InputHandler.IsKeyReleased(ConfigurationManager.Config.Trigger);
            }
        }
    }
}
