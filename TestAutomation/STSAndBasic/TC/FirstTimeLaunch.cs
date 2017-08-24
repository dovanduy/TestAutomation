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

namespace STSAndBasic.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FirstTimeLaunch recording.
    /// </summary>
    [TestModule("d4467035-47fa-4742-84c7-a19b88ef268c", ModuleType.Recording, 1)]
    public partial class FirstTimeLaunch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static FirstTimeLaunch instance = new FirstTimeLaunch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FirstTimeLaunch()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FirstTimeLaunch Instance
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

            // ##Step Press on the MobileFitting app icon and launch the app
            Report.Log(ReportLevel.Info, "Section", "##Step Press on the MobileFitting app icon and launch the app", new RecordItemIndex(0));
            
            StartApp();
            Delay.Milliseconds(0);
            
            // ## Validation Splash screen is displayed after which Welcome screen is opened with the option to access more info and Accept and Continue.
            Report.Log(ReportLevel.Info, "Section", "## Validation Splash screen is displayed after which Welcome screen is opened with the option to access more info and Accept and Continue.", new RecordItemIndex(2));
            
            ValidateContentsContains("More information", ValueConverter.ArgumentFromString<bool>("isFound", "True"));
            Delay.Milliseconds(0);
            
            ValidateOptionExist("Accept & Continue");
            Delay.Milliseconds(0);
            
            // ##Step Press More Information
            Report.Log(ReportLevel.Info, "Section", "##Step Press More Information", new RecordItemIndex(5));
            
            TapMoreInformation();
            Delay.Milliseconds(0);
            
            // ##Validation Important info regarding the app is displayed.
            Report.Log(ReportLevel.Info, "Section", "##Validation Important info regarding the app is displayed.", new RecordItemIndex(7));
            
            VerifyActionBarTitle("Important Info");
            Delay.Milliseconds(0);
            
            // ##Step Click/Swipe to navigate back
            Report.Log(ReportLevel.Info, "Section", "##Step Click/Swipe to navigate back", new RecordItemIndex(9));
            
            BackAction();
            Delay.Milliseconds(0);
            
            // ##Validation Welcome screen is displayed
            Report.Log(ReportLevel.Info, "Section", "##Validation Welcome screen is displayed", new RecordItemIndex(11));
            
            ValidateContentsContains("More information", ValueConverter.ArgumentFromString<bool>("isFound", "True"));
            Delay.Milliseconds(0);
            
            ValidateOptionExist("Accept & Continue");
            Delay.Milliseconds(0);
            
            // ##Step Tap on Accept and Continue
            Report.Log(ReportLevel.Info, "Section", "##Step Tap on Accept and Continue", new RecordItemIndex(14));
            
            AcceptAndContinueWelcomeScreen();
            Delay.Milliseconds(0);
            
            // ##Validation Country selection screen is displayed.
            //Report.Log(ReportLevel.Info, "Section", "##Validation Country selection screen is displayed.", new RecordItemIndex(16));
            
            VerifyActionBarTitle("Country");
            Delay.Milliseconds(0);
            
            // Step## Select the country and click on done button
            Report.Log(ReportLevel.Info, "Section", "Step## Select the country and click on done button", new RecordItemIndex(18));
            
            TapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // ##Validation Access Code screen is displayed.Initial set-up is done.
            Report.Log(ReportLevel.Info, "Section", "##Validation Access Code screen is displayed.Initial set-up is done.", new RecordItemIndex(20));
            
            VerifyActionBarTitle("Access Code");
            Delay.Milliseconds(0);
            
            // Step## Enter Access Code and tap on Done button
            Report.Log(ReportLevel.Info, "Section", "Step## Enter Access Code and tap on Done button", new RecordItemIndex(22));
            
            EnterCorrectCode();
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap On 'Done'");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(25));
            Delay.Duration(2000, false);
            
            // Validation##A valid code should authorize and Verification Success message should be displayed with continue button
            Report.Log(ReportLevel.Info, "Section", "Validation##A valid code should authorize and Verification Success message should be displayed with continue button", new RecordItemIndex(26));
            
            ValidateContents("Code entered successfully.");
            Delay.Milliseconds(0);
            
            ContinueValidationScreen();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
