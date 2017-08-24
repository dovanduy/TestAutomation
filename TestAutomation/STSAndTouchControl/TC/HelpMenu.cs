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
    ///The HelpMenu recording.
    /// </summary>
    [TestModule("24884655-6072-4905-9389-133d940f53c6", ModuleType.Recording, 1)]
    public partial class HelpMenu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndTouchControl.STSAndTouchControlRepository repository.
        /// </summary>
        public static STSAndTouchControl.STSAndTouchControlRepository repo = STSAndTouchControl.STSAndTouchControlRepository.Instance;

        static HelpMenu instance = new HelpMenu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HelpMenu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HelpMenu Instance
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

            // Precondition - Pair the app with standard HI s
            Report.Log(ReportLevel.Info, "Section", "Precondition - Pair the app with standard HI s", new RecordItemIndex(0));
            
            // Step## Launch the app and navigate to settings screen
            Report.Log(ReportLevel.Info, "Section", "Step## Launch the app and navigate to settings screen", new RecordItemIndex(1));
            
            TapOnSettings();
            Delay.Milliseconds(0);
            
            TapOn("Help");
            Delay.Milliseconds(0);
            
            // Validation## Help screen appears with the below options: App Info, FAQ, Contact Us
            Report.Log(ReportLevel.Info, "Section", "Validation## Help screen appears with the below options: App Info, FAQ, Contact Us", new RecordItemIndex(4));
            
            ValidateContents("Help;App Info;FAQ;Contact Us");
            Delay.Milliseconds(0);
            
            // Step## Select App Info
            Report.Log(ReportLevel.Info, "Section", "Step## Select App Info", new RecordItemIndex(6));
            
            TapOn("App Info");
            Delay.Milliseconds(0);
            
            // Validation## App Info screen is displayed
            Report.Log(ReportLevel.Info, "Section", "Validation## App Info screen is displayed", new RecordItemIndex(8));
            
            ValidateContents("App Info;Intended Use;Device Compatibility;Control Signals");
            Delay.Milliseconds(0);
            
            BackAction();
            Delay.Milliseconds(0);
            
            // Step## Select FAQ
            Report.Log(ReportLevel.Info, "Section", "Step## Select FAQ", new RecordItemIndex(11));
            
            TapOn("FAQ");
            Delay.Milliseconds(0);
            
            // Validation## Brand dependent FAQ screen is displayed
            Report.Log(ReportLevel.Info, "Section", "Validation## Brand dependent FAQ screen is displayed", new RecordItemIndex(13));
            
            ValidateContents("FAQ;Q: Why are the hearing aids not reacting to a change I make in the App?;Q: Why are the hearing aids not reacting to a change I make in the App?");
            Delay.Milliseconds(0);
            
            BackAction();
            Delay.Milliseconds(0);
            
            // Step## Select Contact Us
            Report.Log(ReportLevel.Info, "Section", "Step## Select Contact Us", new RecordItemIndex(16));
            
            TapOn("Contact Us");
            Delay.Milliseconds(0);
            
            // Validation## Contact Us screen appears .
            Report.Log(ReportLevel.Info, "Section", "Validation## Contact Us screen appears .", new RecordItemIndex(18));
            
            PermissionPopUpHandle();
            Delay.Milliseconds(0);
            
            ValidateContentsContains("Contact Us;To;Subject", ValueConverter.ArgumentFromString<bool>("isFound", "True"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
