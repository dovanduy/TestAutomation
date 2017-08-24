﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace STSAndTouchControl.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SettingsMenu recording.
    /// </summary>
    [TestModule("dad3f571-37c5-4687-8af1-533285d7405d", ModuleType.Recording, 1)]
    public partial class SettingsMenu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndTouchControl.STSAndTouchControlRepository repository.
        /// </summary>
        public static STSAndTouchControl.STSAndTouchControlRepository repo = STSAndTouchControl.STSAndTouchControlRepository.Instance;

        static SettingsMenu instance = new SettingsMenu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SettingsMenu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SettingsMenu Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Step## Open application and Press Settings/Menu button .
            Report.Log(ReportLevel.Info, "Section", "Step## Open application and Press Settings/Menu button .", new RecordItemIndex(0));
            
            TapOnSettings();
            Delay.Milliseconds(0);
            
            // Validation## Settings screen is opened and following controls are displayed:Back button, Sound Balance, Sound Settings, Setup, Advanced Setup, Language, Rate our App, Usage statistics, Help, Imprint, App Version
            Report.Log(ReportLevel.Info, "Section", "Validation## Settings screen is opened and following controls are displayed:Back button, Sound Balance, Sound Settings, Setup, Advanced Setup, Language, Rate our App, Usage statistics, Help, Imprint, App Version", new RecordItemIndex(2));
            
            ValidateContents("Broadcast level;Setup;Advanced Setup;Language;Rate our app;Usage Statistics;Help;Imprint;App Version");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
