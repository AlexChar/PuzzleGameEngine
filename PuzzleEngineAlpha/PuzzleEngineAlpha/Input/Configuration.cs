﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace PuzzleEngineAlpha.Input
{
    /// <summary>
    /// TODO: Update to get configuration from an xml using the XMLMapper and inputUtilities
    /// </summary>
    public class Configuration
    {

        #region Properties

        public int GameCameraRotationState
        {
            get;
            set;
        }

        #region Game Keys

        public Keys Up
        {
            get
            {
                return Keys.W;
            }
        }

        public Keys Down
        {
            get
            {
                return Keys.S;
            }
        }

        public Keys Left
        {
            get
            {
                return Keys.A;
            }
        }

        public Keys Right
        {
            get
            {
                return Keys.D;
            }
        }

        public Keys EnumerateVNext
        {
            get
            {
                return Keys.Down;
            }          
        }

        public Keys EnumerateVPrevious
        {
            get
            {
                return Keys.Up;
            }
        }

        public Keys ToggleDiagnostics
        {
            get
            {
                return Keys.F1;
            }
        }

        public Keys ToggleMenu
        {
            get
            {
                return Keys.Escape;
            }
        }

        public Keys Trigger
        {
            get
            {
                return Keys.Enter;
            }
        }

        public Keys ZoomIn
        {
            get
            {
                return Keys.Up;
            }
        }

        public Keys ZoomOut
        {
            get
            {
                return Keys.Down;
            }
        }

        public Keys RotateClockwise
        {
            get
            {
                return Keys.Left;
            }
        }

        public Keys RotateCounterClockwise
        {
            get
            {
                return Keys.Right;
            }
        }

        #endregion

        #endregion
    
        }
    }


