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
    ///The TabBetterEarSide recording.
    /// </summary>
    [TestModule("6ed0e951-2ac5-463c-96de-901a88b75984", ModuleType.Recording, 1)]
    public partial class TabBetterEarSide : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static TabBetterEarSide instance = new TabBetterEarSide();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TabBetterEarSide()
        {
            H3 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TabBetterEarSide Instance
        {
            get { return instance; }
        }

#region Variables

        string _H3;

        /// <summary>
        /// Gets or sets the value of variable H3.
        /// </summary>
        [TestVariable("09d5b4aa-cb29-45be-9cf4-7a3cc0cfa8cc")]
        public string H3
        {
            get { return _H3; }
            set { _H3 = value; }
        }

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

            // Step## Pre-Condition - Initial setup and Access code setup is done. Customers created with audiogram configured
            Report.Log(ReportLevel.Info, "Section", "Step## Pre-Condition - Initial setup and Access code setup is done. Customers created with audiogram configured", new RecordItemIndex(0));
            
            TapOnSettings("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SwitchSettingUseMold(ValueConverter.ArgumentFromString<bool>("YesNo", "False"));
            Delay.Milliseconds(0);
            
            CreatePatient("Better1", "EarSide");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            BackAction();
            Delay.Milliseconds(0);
            
            CreatePatient("Better2", "EarSide");
            Delay.Milliseconds(0);
            
            SelectCustomerContinue();
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, goto List and select existing Customer
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List and select existing Customer", new RecordItemIndex(9));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("EarSide");
            Delay.Milliseconds(0);
            
            SelectCustomer("Better1", "EarSide");
            Delay.Milliseconds(0);
            
            // Step## Enter Audiogram -Right with values 45, 50, 65, 70 dB and Left with 50, 50, 60, 60 db for the four required frequencies 500Hz, 1kHz, 2kHz, 4 kHz
            Report.Log(ReportLevel.Info, "Section", "Step## Enter Audiogram -Right with values 45, 50, 65, 70 dB and Left with 50, 50, 60, 60 db for the four required frequencies 500Hz, 1kHz, 2kHz, 4 kHz", new RecordItemIndex(13));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,45;1000,50;2000,65;4000,70");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "500,50;1000,50;2000,60;4000,60");
            Delay.Milliseconds(0);
            
            TabTapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Overview screen is displayed with Recommendation given for Left ear side(lesser value after summation of given frequencies)
            Report.Log(ReportLevel.Info, "Section", "Validation## Overview screen is displayed with Recommendation given for Left ear side(lesser value after summation of given frequencies)", new RecordItemIndex(18));
            
            ValidateMonauralHISelected(H3, "Left");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Click Sleeve", "Left");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P3", "Left");
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
            // Step## Open the app, goto List and select another existing Customer
            Report.Log(ReportLevel.Info, "Section", "Step## Open the app, goto List and select another existing Customer", new RecordItemIndex(23));
            
            StartApp();
            Delay.Milliseconds(0);
            
            SearchCustomer("EarSide");
            Delay.Milliseconds(0);
            
            SelectCustomer("Better2", "EarSide");
            Delay.Milliseconds(0);
            
            // Step## Enter Audiogram -Right with values 45, 50, 65, 70 dB and Left with 45, 50, 65, 70 dB for the four required frequencies 500Hz, 1kHz, 2kHz, 4 kHz
            Report.Log(ReportLevel.Info, "Section", "Step## Enter Audiogram -Right with values 45, 50, 65, 70 dB and Left with 45, 50, 65, 70 dB for the four required frequencies 500Hz, 1kHz, 2kHz, 4 kHz", new RecordItemIndex(27));
            
            TapEnterAudiogram();
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Right", "500,45;1000,50;2000,65;4000,70");
            Delay.Milliseconds(0);
            
            DrawAudiogramPoints("Left", "500,45;1000,50;2000,65;4000,70");
            Delay.Milliseconds(0);
            
            TabTapOnRightButton("Click on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Overview screen is displayed with Recommendation given for Right ear side(Identical frequencie summation)
            Report.Log(ReportLevel.Info, "Section", "Validation## Overview screen is displayed with Recommendation given for Right ear side(Identical frequencie summation)", new RecordItemIndex(32));
            
            ValidateMonauralHISelected(H3, "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralCouplingSelected("Click Sleeve", "Right");
            Delay.Milliseconds(0);
            
            ValidateMonauralClusterSelected("P4", "Right");
            Delay.Milliseconds(0);
            
            CloseApp();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
